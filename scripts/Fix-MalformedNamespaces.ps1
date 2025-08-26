param(
    [string]$Root = (Resolve-Path '..' -ErrorAction SilentlyContinue | Select-Object -First 1 | ForEach-Object Path),
    [string[]]$Include = @('*.cs'),
    [string[]]$Exclude = @('*/bin/*','*/obj/*','*/.vs/*'),
    [switch]$Preview
)

# Scans .cs files and fixes files where the first non-using line is a bare namespace path
# like "Roblox.Platform.*" instead of a proper "namespace ... {" block. Also fixes lines
# where the namespace is glued to the next token (e.g. "...Authenticationinternal class").

$ErrorActionPreference = 'Stop'

Write-Host "Scanning root: $Root" -ForegroundColor Cyan

function Get-FirstLogicalLineMatch {
    param([string]$Text)
    # Match: beginning + any using directives + blank lines, then capture the first code line
    $pattern = "^(?<prefix>(?:\s*using\s+[^;\n\r]+;\s*\r?\n|\s*\r?\n)*)\s*(?<line>[^\r\n]+)"
    return [regex]::Match($Text, $pattern, [System.Text.RegularExpressions.RegexOptions]::Multiline)
}

function HasProperNamespace {
    param([string]$Text)
    return ($Text -match "^\s*namespace\s+[A-Za-z_][\w]*(?:\.[A-Za-z_][\w]*)*\s*\{")
}

$all = Get-ChildItem -Path $Root -Recurse -File -Include $Include
if ($Exclude.Count -gt 0) {
    $regex = ($Exclude | ForEach-Object { [regex]::Escape($_).Replace('\*\*/','.*').Replace('\*','[^\\/]*').Replace('\?','.') }) -join '|'
    $files = $all | Where-Object { $_.FullName -notmatch $regex }
} else {
    $files = $all
}

Write-Host ("Found {0} file(s); after excludes: {1}" -f $all.Count, $files.Count) -ForegroundColor DarkCyan

$patched = 0
$wouldChange = New-Object System.Collections.Generic.List[string]
$scanned = 0
foreach ($f in $files) {
    $scanned++
    $text = Get-Content -LiteralPath $f.FullName -Raw -ErrorAction Stop

    # Special fix: split glued '...Authenticationinternal {' into proper namespace and internal class
    $didSpecial = $false
    if ($text -match '^(\s*)namespace\s+([^\r\n\{]+)internal\s*\{\s*\r?\n' ) {
        $indent = $matches[1]
        $ns = $matches[2].Trim()
        $text = [regex]::Replace($text, '^(\s*)namespace\s+([^\r\n\{]+)internal\s*\{', { param($m) "$($m.Groups[1].Value)namespace $ns {" }, [System.Text.RegularExpressions.RegexOptions]::Multiline)
        # If next non-empty line starts with 'static class', make it 'internal static class'
        $text = [regex]::Replace($text, '^(\s*)static\s+class\s+', '$1internal static class ', [System.Text.RegularExpressions.RegexOptions]::Multiline)
        $didSpecial = $true
    }

    if (HasProperNamespace $text -and -not $didSpecial) { continue }

    $m = Get-FirstLogicalLineMatch $text
    if (-not $m.Success) { continue }

    $line = $m.Groups['line'].Value.Trim()
    if ($line -like 'namespace *') { continue }

    # Extract a leading namespace candidate: identifier(.identifier)*
    $m2 = [regex]::Match($line, '^(?<ns>[A-Za-z_][\w]*(?:\.[A-Za-z_][\w]*)*)(?<rest>.*)$')
    if (-not $m2.Success) { continue }

    $ns = $m2.Groups['ns'].Value.Trim()
    $rest = $m2.Groups['rest'].Value.TrimStart()

    if ([string]::IsNullOrWhiteSpace($ns)) { continue }

    # Build replacement for the captured first code line only
    $replacementLine = "namespace $ns {"
    if (-not [string]::IsNullOrWhiteSpace($rest)) {
        $replacementLine += "`r`n    $rest"
    }

    # Reconstruct file: keep prefix (including usings), replace only the first code line
    $lineGroup = $m.Groups['line']
    $prefix = $text.Substring(0, $lineGroup.Index)
    $suffix = $text.Substring($lineGroup.Index + $lineGroup.Length)

    # Ensure suffix ends with newline
    if (-not $suffix.EndsWith("`r`n")) { $suffix += "`r`n" }

    $newText = $prefix + $replacementLine + "`r`n" + $suffix

    # Append a namespace closing brace if we added an opening one and there isn't an unmatched close.
    # Simple heuristic: if the file now starts with a single namespace and has no matching close, add one.
    if (-not ($text -match '\bnamespace\s+')) {
        if (-not ($newText.TrimEnd() -like '*}')) { $newText += '}' }
        else { $newText += "`r`n}" }
    }

    if ($newText -ne $text) {
        $wouldChange.Add($f.FullName)
        if ($Preview) {
            Write-Host "Would patch: $($f.FullName)" -ForegroundColor Yellow
        } else {
            Set-Content -LiteralPath $f.FullName -Value $newText -Encoding UTF8
            Write-Host "Patched: $($f.FullName)" -ForegroundColor Green
            $patched++
        }
    }
}

if ($Preview) {
    Write-Host "----- Preview Summary -----" -ForegroundColor Cyan
    Write-Host ("Scanned: {0}" -f $scanned)
    Write-Host ("Would patch: {0}" -f $wouldChange.Count)
    if ($wouldChange.Count -gt 0) {
        Write-Host "List of files to patch:" -ForegroundColor DarkYellow
        $wouldChange | ForEach-Object { Write-Host " - $_" }
    }
} else {
    Write-Host "Total patched files: $patched" -ForegroundColor Cyan
}

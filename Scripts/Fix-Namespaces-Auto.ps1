<#
Fix-Namespaces-Auto.ps1

Purpose:
- Scan all C# projects under the Assemblies/ folder
- For each project, derive its base namespace (RootNamespace -> AssemblyName -> csproj name)
- For each .cs file, compute expected namespace as BaseNamespace + relative folder path (dot-separated)
- Show a preview list of files whose namespace differs from expected
- Ask for Y/N confirmation before applying changes
- Update only the first namespace declaration in each file, preserving file-scoped or block style

Notes:
- Skips common generated files (Designer, .g.cs, .generated.cs) and AssemblyInfo.cs
- Excludes bin/ obj/ .vs/ packages/ folders
- Only updates files that contain a namespace declaration

Usage:
- Double-click Fix-Namespaces-Auto.cmd, or run this script directly
- Optional parameters exist for advanced usage (see Param block)
#>

[CmdletBinding()]
Param(
    # Root to scan for projects (default: ../Assemblies relative to this script)
    [string]$ProjectsRoot,

    # Include additional glob for csproj selection (default: **/*.csproj)
    [string]$CsprojPattern = '**/*.csproj',

    # If set, apply changes without prompting (still prints summary)
    [switch]$Yes,

    # If set, prints extra diagnostics
    [switch]$VerboseLog,

    # Controls how subfolders are appended to the base namespace: LeafOnly or FullPath
    [ValidateSet('LeafOnly','FullPath')]
    [string]$NamespaceAppend = 'LeafOnly',

    # If set, the computed namespace will be just the leaf folder name (no base namespace prefix)
    [switch]$UseLeafAsAbsolute,

    # If set, the computed namespace will be the ENTIRE folder name (dots preserved), no base prefix
    [switch]$UseFolderAsAbsolute
)

function Write-Info($msg) { Write-Host "[INFO] $msg" -ForegroundColor Cyan }
function Write-Warn($msg) { Write-Host "[WARN] $msg" -ForegroundColor Yellow }
function Write-Err ($msg) { Write-Host "[ERR ] $msg" -ForegroundColor Red }

# Clean console output
try { Clear-Host } catch { }

# Compute default ProjectsRoot if not provided
if (-not $ProjectsRoot) {
    $scriptDir = $null
    if ($PSScriptRoot) {
        $scriptDir = $PSScriptRoot
    } elseif ($MyInvocation -and $MyInvocation.MyCommand -and $MyInvocation.MyCommand.Path) {
        $scriptDir = Split-Path -LiteralPath $MyInvocation.MyCommand.Path -Parent
    } else {
        # Fallback to current directory
        $scriptDir = (Get-Location).Path
    }
    $ProjectsRoot = Join-Path $scriptDir '..\\Assemblies'
}

Write-Info "Fix-Namespaces-Auto starting..."
Write-Info "ProjectsRoot: $ProjectsRoot"

if (-not (Test-Path -LiteralPath $ProjectsRoot)) {
    Write-Err "ProjectsRoot does not exist: $ProjectsRoot"
    exit 1
}

# Helper: get base namespace from csproj
function Get-BaseNamespaceFromCsproj {
    param(
        [Parameter(Mandatory)] [string] $CsprojPath
    )
    try {
        [xml]$xml = Get-Content -LiteralPath $CsprojPath -Raw -ErrorAction Stop
    } catch {
        Write-Warn "Failed to load XML: $CsprojPath. Using filename as base namespace. ($_ )"
        return [IO.Path]::GetFileNameWithoutExtension($CsprojPath)
    }

    # Look for Sdk-style PropertyGroup or legacy
    $rootNs = $xml.Project.PropertyGroup.RootNamespace | Select-Object -First 1
    if ([string]::IsNullOrWhiteSpace($rootNs)) {
        $asmName = $xml.Project.PropertyGroup.AssemblyName | Select-Object -First 1
        if ([string]::IsNullOrWhiteSpace($asmName)) {
            return [IO.Path]::GetFileNameWithoutExtension($CsprojPath)
        } else {
            return $asmName
        }
    } else {
        return $rootNs
    }
}

# Helper: compute relative path (PowerShell 5/.NET Framework compatible)
function Get-RelativePath {
    param(
        [Parameter(Mandatory)] [string] $BasePath,
        [Parameter(Mandatory)] [string] $TargetPath
    )
    if ([string]::IsNullOrWhiteSpace($TargetPath)) { return '.' }
    if ([string]::IsNullOrWhiteSpace($BasePath)) { return $TargetPath }
    try {
        $baseFull = [IO.Path]::GetFullPath($BasePath)
        $targetFull = [IO.Path]::GetFullPath($TargetPath)
        # Ensure base ends with a separator so MakeRelativeUri treats it as a folder
        $baseWithSep = if ($baseFull.TrimEnd([IO.Path]::DirectorySeparatorChar) -ne $baseFull) { $baseFull } else { $baseFull + [IO.Path]::DirectorySeparatorChar }
        $uBase = New-Object System.Uri($baseWithSep)
        $uTarget = New-Object System.Uri($targetFull)
        $rel = $uBase.MakeRelativeUri($uTarget).ToString()
        $rel = [Uri]::UnescapeDataString($rel)
        # Convert URI separators to platform-specific
        $rel = $rel -replace '/', [IO.Path]::DirectorySeparatorChar
        if ([string]::IsNullOrWhiteSpace($rel)) { return '.' }
        return $rel
    } catch {
        return $TargetPath
    }
}

# Helper: compute expected namespace from relative folder path
function Get-ExpectedNamespace {
    param(
        [Parameter(Mandatory)] [string] $BaseNamespace,
        [Parameter(Mandatory)] [string] $ProjectDir,
        [Parameter(Mandatory)] [string] $CsFilePath
    )
    $fileDir = $null
    try {
        if ($CsFilePath) { $fileDir = [IO.Path]::GetDirectoryName([IO.Path]::GetFullPath($CsFilePath)) }
    } catch { $fileDir = $null }

    # Compute relative directory path
    if (-not $fileDir) { return $BaseNamespace }
    
    # Always use the immediate folder name as the namespace
    $leafRaw = ''
    try { $leafRaw = [IO.Path]::GetFileName($fileDir) } catch { $leafRaw = '' }
    if (-not [string]::IsNullOrWhiteSpace($leafRaw)) { return $leafRaw }
    # Fallback
    return $BaseNamespace

    # FullPath behavior: safer relative computation without dropping characters
    # Force LeafOnly behavior even if FullPath was requested, per current requirements
    $relDir = $null
    try {
        $projFull = [IO.Path]::GetFullPath($ProjectDir)
        $dirFull  = [IO.Path]::GetFullPath($fileDir)
        if ($dirFull.StartsWith($projFull, [System.StringComparison]::OrdinalIgnoreCase)) {
            $relDir = $dirFull.Substring($projFull.Length).TrimStart([IO.Path]::DirectorySeparatorChar, [IO.Path]::AltDirectorySeparatorChar)
        } else {
            $relDir = Get-RelativePath -BasePath $ProjectDir -TargetPath $fileDir
        }
    } catch {
        $relDir = Get-RelativePath -BasePath $ProjectDir -TargetPath $fileDir
    }

    # Normalize separators and trim
    $relDir = $relDir -replace '[\\/]+','/'
    if ($relDir -eq '.' -or [string]::IsNullOrWhiteSpace($relDir)) {
        return $BaseNamespace
    }

    # Exclude common meta folders from namespace path expansion
    $parts = $relDir.Split('/') | Where-Object { $_ -and $_ -ne '.' -and $_ -ne 'bin' -and $_ -ne 'obj' -and $_ -ne '.vs' -and $_ -ne 'packages' }

    if ($parts.Count -eq 0) { return $BaseNamespace }

    # Avoid duplicating base namespace or its last segment
    $baseSegments = $BaseNamespace.Split('.')
    $baseLast = $baseSegments[-1]
    $filtered = $parts | Where-Object { $_ -and ($_ -ne $BaseNamespace) -and ($_ -ne $baseLast) }

    if (-not $filtered -or $filtered.Count -eq 0) { return $BaseNamespace }

    $tail = ($filtered -join '.')
    return "$BaseNamespace.$tail"
}

# Helper: determine current namespace and its style
function Get-CurrentNamespace {
    param(
        [Parameter(Mandatory)] [string] $Content
    )
    # file-scoped: namespace Foo.Bar;
    $fileScoped = [regex]::Match($Content, '^[\s\uFEFF]*namespace\s+([A-Za-z_][\w\.]*)\s*;\s*', 'Multiline')
    if ($fileScoped.Success) {
        return [pscustomobject]@{ Style='FileScoped'; Name=$fileScoped.Groups[1].Value; Match=$fileScoped }
    }
    # block: namespace Foo.Bar { ... }
    $block = [regex]::Match($Content, '^[\s\uFEFF]*namespace\s+([A-Za-z_][\w\.]*)\s*\{', 'Multiline')
    if ($block.Success) {
        return [pscustomobject]@{ Style='Block'; Name=$block.Groups[1].Value; Match=$block }
    }
    return $null
}

# Helper: update namespace in content preserving style
function Set-NamespaceInContent {
    param(
        [Parameter(Mandatory)] [string] $Content,
        [Parameter(Mandatory)] [string] $NewNamespace
    )
    $ns = Get-CurrentNamespace -Content $Content
    if (-not $ns) { return $Content }
    switch ($ns.Style) {
        'FileScoped' {
            $pattern = '(^[\s\uFEFF]*namespace\s+)([A-Za-z_][\w\.]*)(\s*;\s*)'
            return [regex]::Replace($Content, $pattern, "$1$NewNamespace$3", 'Multiline', [TimeSpan]::FromSeconds(2))
        }
        'Block' {
            $pattern = '(^[\s\uFEFF]*namespace\s+)([A-Za-z_][\w\.]*)(\s*\{)'
            return [regex]::Replace($Content, $pattern, "$1$NewNamespace$3", 'Multiline', [TimeSpan]::FromSeconds(2))
        }
    }
}

# Load ignore list from ignore.txt in the script directory
$IgnoreList = @()
$IgnoreFile = Join-Path (Split-Path -Parent $MyInvocation.MyCommand.Path) 'ignore.txt'
if (Test-Path -LiteralPath $IgnoreFile) {
    try {
        $IgnoreList = Get-Content -LiteralPath $IgnoreFile -ErrorAction Stop | ForEach-Object { $_.Trim() } |
            Where-Object { $_ -and -not $_.StartsWith('#') }
    } catch { Write-Warn "Failed to read ignore.txt ($_ )" }
}

function Is-IgnoredPath {
    param([Parameter(Mandatory)][string]$Path)
    if (-not $IgnoreList -or $IgnoreList.Count -eq 0) { return $false }
    foreach ($token in $IgnoreList) {
        $pattern = [regex]::Escape($token)
        if ($null -ne $Path -and $Path -imatch $pattern) { return $true }
    }
    return $false
}

function Is-IgnoredByText {
    param([Parameter(Mandatory)][string[]]$Texts)
    if (-not $IgnoreList -or $IgnoreList.Count -eq 0) { return $false }
    foreach ($token in $IgnoreList) {
        $pattern = [regex]::Escape($token)
        foreach ($t in $Texts) {
            if ($null -ne $t -and $t -imatch $pattern) { return $true }
        }
    }
    return $false
}

if ($IgnoreList.Count -gt 0) {
    Write-Host "Ignore list loaded (ignore.txt):" -ForegroundColor DarkGray
    $IgnoreList | ForEach-Object { Write-Host (" - {0}" -f $_) -ForegroundColor DarkGray }
}

# Enumerate projects (hardened for PS5)
$csprojPaths = @()
try {
    $csprojPaths = Get-ChildItem -Path $ProjectsRoot -Recurse -Filter '*.csproj' -File |
        Where-Object { $_.FullName -imatch $CsprojPattern.Replace('**/','').Replace('*','.*') -or $CsprojPattern -eq '**/*.csproj' } |
        ForEach-Object { $_.FullName }
} catch {
    Write-Warn "Failed to enumerate .csproj under $ProjectsRoot ($_ )"
}
$csprojPaths = $csprojPaths | Where-Object { $_ -and (Test-Path -LiteralPath $_) } | Select-Object -Unique
if (-not $csprojPaths -or $csprojPaths.Count -eq 0) {
    Write-Warn "No .csproj files found under $ProjectsRoot"
    exit 0
}

$changes = New-Object System.Collections.Generic.List[object]
$projTotal = $csprojPaths.Count
$projIndex = 0
$ignoredMismatchesTotal = 0
$ignoredItems = New-Object System.Collections.Generic.List[object]

foreach ($proj in $csprojPaths) {
    $projIndex++
    if (-not $proj) { continue }
    $projIgnored = Is-IgnoredPath $proj
    if ($projIgnored) {
        Write-Host ("Ignored scope (project path matched ignore): {0}" -f (Get-RelativePath -BasePath $ProjectsRoot -TargetPath $proj)) -ForegroundColor DarkGray
    }
    $projDir = [IO.Path]::GetDirectoryName($proj)
    if (-not $projDir -or -not (Test-Path -LiteralPath $projDir)) {
        Write-Warn "Project directory missing or inaccessible: $proj"
        continue
    }
    $baseNs = Get-BaseNamespaceFromCsproj -CsprojPath $proj
    $projRel = Get-RelativePath -BasePath $ProjectsRoot -TargetPath $proj
    Write-Host ("Analyzing [{0}/{1}] {2}" -f $projIndex, $projTotal, $projRel) -ForegroundColor Magenta
    if ($VerboseLog) { Write-Info "BaseNamespace: $baseNs" }

    # Collect .cs files
    $csFiles = @()
    try {
        $csFiles = Get-ChildItem -Path $projDir -Recurse -Filter '*.cs' -File |
            Where-Object {
                $path = $_.FullName
                $path -notmatch "\\bin\\" -and $path -notmatch "\\obj\\" -and $path -notmatch "\\.vs\\" -and $path -notmatch "\\packages\\" -and
                $path -notmatch "\\TemporaryGeneratedFile_" -and
                $_.Name -notmatch '\\.Designer\\.cs$' -and
                $_.Name -notmatch '\\.g\\.cs$' -and
                $_.Name -notmatch '\\.generated\\.cs$' -and
                $_.Name -ne 'AssemblyInfo.cs'
            } |
            ForEach-Object { $_.FullName }
    } catch {
        Write-Warn "Failed to enumerate .cs files in $projDir ($_ )"
        continue
    }

    $scanned = 0
    $mismatches = 0
    foreach ($file in $csFiles) {
        $scanned++
        try {
            $content = Get-Content -LiteralPath $file -Raw -ErrorAction Stop
        } catch {
            Write-Warn "Cannot read: $file ($_ )"
            continue
        }
        $curr = Get-CurrentNamespace -Content $content
        if (-not $curr) { continue }

        $expected = Get-ExpectedNamespace -BaseNamespace $baseNs -ProjectDir $projDir -CsFilePath $file

        $isIgnored = $projIgnored -or (Is-IgnoredPath $file) -or (Is-IgnoredPath ([IO.Path]::GetDirectoryName($file))) -or (Is-IgnoredByText @($curr.Name, $expected))
        if ($curr.Name -ne $expected) {
            $rel = Get-RelativePath -BasePath $ProjectsRoot -TargetPath $file
            if ($isIgnored) {
                $mismatches++
                $ignoredMismatchesTotal++
                $ignoredItems.Add([pscustomobject]@{
                    Project  = $proj
                    File     = $file
                    Relative = $rel
                    From     = $curr.Name
                    To       = $expected
                }) | Out-Null
                Write-Host ("  [ignored] mismatch: {0}" -f $rel) -ForegroundColor Green
            } else {
                $changes.Add([pscustomobject]@{
                    Project     = $proj
                    File        = $file
                    Relative    = $rel
                    From        = $curr.Name
                    To          = $expected
                    Style       = $curr.Style
                }) | Out-Null
                $mismatches++
                Write-Host ("  mismatch: {0}" -f $rel) -ForegroundColor DarkYellow
            }
        }

        if (($scanned % 200) -eq 0) {
            Write-Host ("   ... scanned {0} files, mismatches {1}" -f $scanned, $mismatches) -ForegroundColor DarkGray
        }
    }
    Write-Host ("   done: scanned {0} files, mismatches {1}" -f $scanned, $mismatches) -ForegroundColor DarkGray
}

# Summary and preview
try { Clear-Host } catch { }
Write-Host "" 
Write-Host "========================================" -ForegroundColor DarkGray
Write-Host "Namespace Fix Preview" -ForegroundColor Green
Write-Host "Projects scanned: $($csprojPaths.Count)" -ForegroundColor Gray
Write-Host "Files to change: $($changes.Count)" -ForegroundColor Gray
if ($ignoredMismatchesTotal -gt 0) {
    Write-Host "Ignored (show-only) mismatches: $ignoredMismatchesTotal" -ForegroundColor DarkGreen
}
Write-Host "========================================" -ForegroundColor DarkGray

if ($changes.Count -gt 0) {
    $changes | Sort-Object Relative | ForEach-Object {
        Write-Host (" - {0}" -f $_.Relative) -ForegroundColor White
        Write-Host ("     {0} -> {1}" -f $_.From, $_.To) -ForegroundColor DarkCyan
    }
} else {
    Write-Info "No namespace mismatches found."
}

# Show ignored items in green (not included in apply list)
if ($ignoredItems.Count -gt 0) {
    Write-Host "" 
    Write-Host "Ignored (show-only) mismatches:" -ForegroundColor DarkGreen
    $ignoredItems | Sort-Object Relative | ForEach-Object {
        Write-Host (" - {0}" -f $_.Relative) -ForegroundColor Green
        Write-Host ("     {0} -> {1}" -f $_.From, $_.To) -ForegroundColor DarkGreen
    }
}

if ($changes.Count -eq 0) { exit 0 }

$apply = $false
if ($Yes) {
    $apply = $true
} else {
    $answer = Read-Host "Apply these changes to $($changes.Count) file(s)? (Y/N)"
    if ($answer -match '^(?i)(y|yes)$') { $apply = $true }
}

if (-not $apply) {
    Write-Warn "Aborted by user. No changes applied."
    exit 0
}

# Apply changes
$updated = 0
foreach ($c in $changes) {
    try {
        $text = Get-Content -LiteralPath $c.File -Raw -ErrorAction Stop
        $newText = Set-NamespaceInContent -Content $text -NewNamespace $c.To
        if ($newText -ne $text) {
            Set-Content -LiteralPath $c.File -Value $newText -Encoding UTF8 -ErrorAction Stop
            $updated++
        } else {
            Write-Warn "No textual change made (pattern not matched): $($c.Relative)"
        }
    } catch {
        Write-Err "Failed to update: $($c.Relative) ($_ )"
    }
}

Write-Host "" 
Write-Info "Completed. Updated $updated file(s)."
exit 0

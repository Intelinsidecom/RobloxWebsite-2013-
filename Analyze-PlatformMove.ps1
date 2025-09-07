param(
    [string]$Root = $PSScriptRoot,
    [string]$ReportPath,
    [switch]$Verbose,
    [switch]$ScanScripts, # optional: include scanning of script files for literal .csproj paths
    [switch]$Fix          # when set, rewrite broken paths where a unique candidate is found
)

$ErrorActionPreference = 'Stop'

# Resolve paths (robust)
try {
    # If Root is empty, default to script directory
    if (-not $Root -or [string]::IsNullOrWhiteSpace($Root)) { $Root = $PSScriptRoot }

function Get-RelativePath {
    param(
        [Parameter(Mandatory=$true)][string]$FromFile,
        [Parameter(Mandatory=$true)][string]$ToFile
    )
    $fromDir = [System.IO.Path]::GetDirectoryName($FromFile)
    $uriFrom = New-Object System.Uri(($fromDir.TrimEnd([System.IO.Path]::DirectorySeparatorChar) + [System.IO.Path]::DirectorySeparatorChar))
    $uriTo   = New-Object System.Uri($ToFile)
    $relUri  = $uriFrom.MakeRelativeUri($uriTo)
    $relPath = [System.Uri]::UnescapeDataString($relUri.ToString())
    return ($relPath -replace '/', '\\')
}
    # If Root points to a file, use its parent directory
    if (Test-Path -LiteralPath $Root -PathType Leaf) { $Root = Split-Path -LiteralPath $Root -Parent }
    $rootResolved = Resolve-Path -LiteralPath $Root -ErrorAction Stop
    $rootPath = $rootResolved.Path
} catch {
    Write-Warning "Failed to resolve -Root ('$Root'). Falling back to script directory. Details: $($_.Exception.Message)"
    $rootPath = $PSScriptRoot
}

if (-not $ReportPath -or [string]::IsNullOrWhiteSpace($ReportPath)) {
    $ReportPath = Join-Path $rootPath 'PlatformMoveImpactReport.txt'
} else {
    # If a file path was passed, ensure its directory exists or can be derived
    try {
        $reportDir = Split-Path -LiteralPath $ReportPath -Parent
        if (-not $reportDir -or -not (Test-Path -LiteralPath $reportDir)) {
            $ReportPath = Join-Path $rootPath 'PlatformMoveImpactReport.txt'
        }
    } catch {
        $ReportPath = Join-Path $rootPath 'PlatformMoveImpactReport.txt'
    }
}

Write-Host "Analyzing repository root:" -NoNewline; Write-Host " $rootPath" -ForegroundColor Cyan
Write-Host "Report will be written to:" -NoNewline; Write-Host " $ReportPath" -ForegroundColor Cyan

# Build an index of all *.csproj in the repo
Write-Host "\nIndexing projects (*.csproj)..." -ForegroundColor Cyan
$allProjects = Get-ChildItem -LiteralPath $rootPath -Recurse -File -Filter *.csproj -Force
$projectByLeaf = @{}
foreach ($p in $allProjects) {
    $leaf = $p.Name
    if (-not $projectByLeaf.ContainsKey($leaf)) { $projectByLeaf[$leaf] = @() }
    $projectByLeaf[$leaf] += $p.FullName
    if ($Verbose) { Write-Host "Indexed: $leaf -> $($p.FullName)" -ForegroundColor DarkCyan }
}
Write-Host ("Total projects indexed: {0}" -f $allProjects.Count)

# Helpers
function Resolve-RefPath {
    param([string]$BaseFile, [string]$IncludePath)
    try {
        $baseDir = [System.IO.Path]::GetDirectoryName($BaseFile)
        $full = Resolve-Path -LiteralPath (Join-Path $baseDir $IncludePath) -ErrorAction Stop
        return $full.Path
    } catch { return $null }
}

# Collect results
$brokenProjectRefs = New-Object System.Collections.Generic.List[object]
$brokenSlnEntries  = New-Object System.Collections.Generic.List[object]

# 1) Analyze .csproj -> <ProjectReference Include="...">
Write-Host "\nScanning ProjectReference includes in .csproj files..." -ForegroundColor Cyan
foreach ($csproj in $allProjects) {
    try {
        [xml]$xml = Get-Content -LiteralPath $csproj.FullName -Raw
    } catch {
        Write-Warning "Failed to parse XML: $($csproj.FullName): $($_.Exception.Message)"
        continue
    }
    $nodes = $xml.Project.ItemGroup.ProjectReference
    if (-not $nodes) { continue }
    foreach ($n in $nodes) {
        $inc = $n.Include
        if (-not $inc) { continue }
        $resolved = Resolve-RefPath -BaseFile $csproj.FullName -IncludePath $inc
        if (-not $resolved -or -not (Test-Path -LiteralPath $resolved)) {
            $leaf = [System.IO.Path]::GetFileName($inc)
            $candidates = @()
            if ($leaf -and $projectByLeaf.ContainsKey($leaf)) { $candidates = $projectByLeaf[$leaf] }
            $brokenProjectRefs.Add([pscustomobject]@{
                Referencer   = $csproj.FullName
                IncludePath  = $inc
                ResolvedPath = $resolved
                Exists       = $false
                Candidates   = ($candidates -join '; ')
            }) | Out-Null
            Write-Host "Missing ProjectReference ->" -NoNewline; Write-Host " $($csproj.FullName) :: $inc" -ForegroundColor Yellow
            if ($candidates.Count -gt 0) { Write-Host "  Suggested: $($candidates -join '; ')" -ForegroundColor DarkYellow }

            # Attempt auto-fix when requested
            if ($Fix -and $candidates.Count -ge 1) {
                # Prefer the first candidate; compute relative path
                $target = $candidates[0]
                try {
                    $newRel = Get-RelativePath -FromFile $csproj.FullName -ToFile $target
                    if ($Verbose) { Write-Host "  Rewriting -> $newRel" -ForegroundColor Cyan }
                    $n.Include = $newRel
                    $xml.Save($csproj.FullName)
                    Write-Host "  Fixed ProjectReference in: $($csproj.FullName)" -ForegroundColor Green
                } catch {
                    Write-Warning "  Failed to rewrite ProjectReference in $($csproj.FullName): $($_.Exception.Message)"
                }
            }
        } elseif ($Verbose) {
            Write-Host "OK ProjectReference -> $($csproj.FullName) :: $inc" -ForegroundColor DarkGreen
        }
    }
}

# 2) Analyze .sln entries (Project lines)
Write-Host "\nScanning solution files (.sln) for broken project paths..." -ForegroundColor Cyan
$slnFiles = Get-ChildItem -LiteralPath $rootPath -Recurse -File -Filter *.sln -Force
foreach ($sln in $slnFiles) {
    $lines = Get-Content -LiteralPath $sln.FullName
    for ($i=0; $i -lt $lines.Count; $i++) {
        $line = $lines[$i]
        if ($line -match '^Project\("\{[^}]+\}"\) = "[^"]+", "([^"]+\.csproj)", "\{[^}]+\}"') {
            $rel = $Matches[1]
            $slnDir = [System.IO.Path]::GetDirectoryName($sln.FullName)
            $full = Join-Path $slnDir $rel
            if (-not (Test-Path -LiteralPath $full)) {
                $leaf = [System.IO.Path]::GetFileName($rel)
                $candidates = @()
                if ($leaf -and $projectByLeaf.ContainsKey($leaf)) { $candidates = $projectByLeaf[$leaf] }
                $brokenSlnEntries.Add([pscustomobject]@{
                    Solution    = $sln.FullName
                    LineNumber  = $i+1
                    IncludePath = $rel
                    Resolved    = $full
                    Exists      = $false
                    Candidates  = ($candidates -join '; ')
                }) | Out-Null
                Write-Host "Missing .sln project ->" -NoNewline; Write-Host " $($sln.FullName) :: $rel" -ForegroundColor Yellow
                if ($candidates.Count -gt 0) { Write-Host "  Suggested: $($candidates -join '; ')" -ForegroundColor DarkYellow }

                if ($Fix -and $candidates.Count -ge 1) {
                    try {
                        $target = $candidates[0]
                        $newRel = Get-RelativePath -FromFile $sln.FullName -ToFile $target
                        $lines[$i] = $line -replace [regex]::Escape($rel), ($newRel -replace '\\','/')
                        Set-Content -LiteralPath $sln.FullName -Value $lines -Encoding UTF8
                        Write-Host "  Fixed .sln entry in: $($sln.FullName)" -ForegroundColor Green
                    } catch {
                        Write-Warning "  Failed to rewrite .sln entry in $($sln.FullName): $($_.Exception.Message)"
                    }
                }
            } elseif ($Verbose) {
                Write-Host "OK .sln project -> $($sln.FullName) :: $rel" -ForegroundColor DarkGreen
            }
        }
    }
}

# 3) Optional: scan build scripts for literal csproj paths (lightweight)
if ($ScanScripts) {
    $scriptTotalMatches = 0
    $scriptUnresolvedMatches = 0
    Write-Host "\nScanning build scripts for literal csproj paths..." -ForegroundColor Cyan
    $scriptFiles = Get-ChildItem -LiteralPath $rootPath -Recurse -File -Force -Include *.ps1,*.cmd,*.bat,*.props,*.targets
    $literalIssues = New-Object System.Collections.Generic.List[object]
    foreach ($sf in $scriptFiles) {
        # Skip analyzing this script to avoid self-matching its regex/source strings
        if ([System.IO.Path]::GetFileName($sf.FullName) -eq 'Analyze-PlatformMove.ps1') { continue }
        $txt = Get-Content -LiteralPath $sf.FullName -Raw
        # Tightened pattern: avoid matching escape sequences like \n, \r, \t as path separators
        $matches = [System.Text.RegularExpressions.Regex]::Matches($txt, "(?im)([^\r\n]*?)((?:\\\\|/)(?![nrt](?![A-Za-z0-9]))[^\r\n]*?\.csproj)")
        foreach ($m in $matches) {
            $scriptTotalMatches++
            $rel = $m.Groups[2].Value
            # Normalize quotes/whitespace around the captured path
            $rel = $rel.Trim()
            if ($rel.StartsWith('"') -and $rel.EndsWith('"')) { $rel = $rel.Trim('"') }
            # Try resolve relative to file dir when appears relative
            $resolved = $null
            try {
                $resolved = Resolve-Path -LiteralPath (Join-Path ([System.IO.Path]::GetDirectoryName($sf.FullName)) $rel) -ErrorAction Stop
                $resolved = $resolved.Path
            } catch { }
            if ($resolved -and (Test-Path -LiteralPath $resolved)) {
                # Always show resolved detections so users see progress
                Write-Host "OK script reference ->" -NoNewline; Write-Host " $($sf.FullName) :: $rel" -ForegroundColor DarkGreen
                continue
            }
            # Derive leaf safely; $rel may contain illegal path characters from script literals
            $leaf = $null
            try {
                if ($rel -and ($rel -notmatch '[<>:"\|\?\*]')) { $leaf = [System.IO.Path]::GetFileName($rel) }
            } catch { $leaf = $null }
            $candidates = @()
            if ($leaf -and $projectByLeaf.ContainsKey($leaf)) { $candidates = $projectByLeaf[$leaf] }
            $scriptUnresolvedMatches++
            $literalIssues.Add([pscustomobject]@{
                File        = $sf.FullName
                Snippet     = $m.Groups[0].Value.Trim()
                IncludePath = $rel
                Resolved    = $resolved
                Exists      = $false
                Candidates  = ($candidates -join '; ')
            }) | Out-Null
            # Always inform the user about unresolved script literal references
            Write-Host "Potential script reference ->" -NoNewline; Write-Host " $($sf.FullName) :: $rel" -ForegroundColor Yellow
            Write-Host "  Snippet:     $($m.Groups[0].Value.Trim())" -ForegroundColor DarkYellow
            Write-Host "  Detected:    $($(if ($leaf) { $leaf } else { '<unparseable>' }))" -ForegroundColor DarkYellow
            if ($resolved) { Write-Host "  Resolved:    $resolved" -ForegroundColor DarkYellow }
            if ($candidates.Count -gt 0) { Write-Host "  Suggested:   $($candidates -join '; ')" -ForegroundColor DarkYellow } else { Write-Host "  Suggested:   <none>" -ForegroundColor DarkYellow }
        }
    }
    # Summary for script scan
    Write-Host ("Build scripts scan: processed {0} reference(s), unresolved {1}." -f $scriptTotalMatches, $scriptUnresolvedMatches) -ForegroundColor Cyan
}

# Write report
$sb = New-Object System.Text.StringBuilder
$null = $sb.AppendLine("Platform Projects Move Impact Report")
$null = $sb.AppendLine(("Generated: {0}" -f (Get-Date)))
$null = $sb.AppendLine(("Repository root: {0}" -f $rootPath))
$null = $sb.AppendLine("")

$null = $sb.AppendLine(("Broken ProjectReference includes: {0}" -f $brokenProjectRefs.Count))
foreach ($r in $brokenProjectRefs) {
    $null = $sb.AppendLine("- Referencer:  " + $r.Referencer)
    $null = $sb.AppendLine("  Include:     " + $r.IncludePath)
    $null = $sb.AppendLine("  Resolved:    " + ($(if ($null -ne $r.ResolvedPath -and $r.ResolvedPath -ne '') { $r.ResolvedPath } else { '<null>' })))
    if ($r.Candidates) { $null = $sb.AppendLine("  Candidates:  " + $r.Candidates) }
    $null = $sb.AppendLine("")
}

$null = $sb.AppendLine(("Broken .sln project entries: {0}" -f $brokenSlnEntries.Count))
foreach ($s in $brokenSlnEntries) {
    $null = $sb.AppendLine("- Solution:   " + $s.Solution)
    $null = $sb.AppendLine("  Line:       " + $s.LineNumber)
    $null = $sb.AppendLine("  Include:    " + $s.IncludePath)
    $null = $sb.AppendLine("  Resolved:   " + $s.Resolved)
    if ($s.Candidates) { $null = $sb.AppendLine("  Candidates: " + $s.Candidates) }
    $null = $sb.AppendLine("")
}

$null = $sb.AppendLine(("Potential script literal references to .csproj: {0}" -f $literalIssues.Count))
foreach ($i in $literalIssues) {
    $null = $sb.AppendLine("- File:       " + $i.File)
    $null = $sb.AppendLine("  Snippet:    " + $i.Snippet)
    $null = $sb.AppendLine("  Include:    " + $i.IncludePath)
    $null = $sb.AppendLine("  Resolved:   " + ($(if ($null -ne $i.Resolved -and $i.Resolved -ne '') { $i.Resolved } else { '<null>' })))
    if ($i.Candidates) { $null = $sb.AppendLine("  Candidates: " + $i.Candidates) }
    $null = $sb.AppendLine("")
}

$null = $sb.AppendLine("Done.")

$sb.ToString() | Out-File -FilePath $ReportPath -Encoding UTF8 -Force

Write-Host "\nReport written to: $ReportPath" -ForegroundColor Green

# Targeted regex patch for known folder moves (optional extra safety)
if ($Fix) {
    Write-Host "\nApplying targeted path rewrites for known moves (Entities) ..." -ForegroundColor Cyan
    Get-ChildItem -LiteralPath $rootPath -Recurse -File -Filter *.csproj -Force | ForEach-Object {
        try {
            $p = $_.FullName
            $txt = Get-Content -LiteralPath $p -Raw
            $new = $txt -replace 'Roblox[\\/]+Roblox\.Entities\.Mssql', 'Entities/Roblox.Entities.Mssql' `
                          -replace 'Roblox[\\/]+Roblox\.Entities',       'Entities/Roblox.Entities'
            if ($new -ne $txt) {
                Set-Content -LiteralPath $p -Value $new -Encoding UTF8 -NoNewline
                Write-Host "  Updated: $p" -ForegroundColor Green
            }
        } catch {
            Write-Warning "  Failed path rewrite for $($_.FullName): $($_.Exception.Message)"
        }
    }
}

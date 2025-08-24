param(
    [string]$Root = $PSScriptRoot,
    [string]$ReportPath,
    [switch]$Verbose
)

$ErrorActionPreference = 'Stop'

# Resolve paths (robust)
try {
    # If Root is empty, default to script directory
    if (-not $Root -or [string]::IsNullOrWhiteSpace($Root)) { $Root = $PSScriptRoot }
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
            } elseif ($Verbose) {
                Write-Host "OK .sln project -> $($sln.FullName) :: $rel" -ForegroundColor DarkGreen
            }
        }
    }
}

# 3) Optional: scan build scripts for literal csproj paths (lightweight)
Write-Host "\nScanning build scripts for literal csproj paths..." -ForegroundColor Cyan
$scriptFiles = Get-ChildItem -LiteralPath $rootPath -Recurse -File -Force -Include *.ps1,*.cmd,*.bat,*.props,*.targets
$literalIssues = New-Object System.Collections.Generic.List[object]
foreach ($sf in $scriptFiles) {
    $txt = Get-Content -LiteralPath $sf.FullName -Raw
    $matches = [System.Text.RegularExpressions.Regex]::Matches($txt, "(?im)([^\r\n]*?)([\\/][^\r\n]*?\.csproj)")
    foreach ($m in $matches) {
        $rel = $m.Groups[2].Value
        # Try resolve relative to file dir when appears relative
        $resolved = $null
        try {
            $resolved = Resolve-Path -LiteralPath (Join-Path ([System.IO.Path]::GetDirectoryName($sf.FullName)) $rel) -ErrorAction Stop
            $resolved = $resolved.Path
        } catch { }
        if ($resolved -and (Test-Path -LiteralPath $resolved)) { continue }
        $leaf = [System.IO.Path]::GetFileName($rel)
        $candidates = @()
        if ($leaf -and $projectByLeaf.ContainsKey($leaf)) { $candidates = $projectByLeaf[$leaf] }
        $literalIssues.Add([pscustomobject]@{
            File        = $sf.FullName
            Snippet     = $m.Groups[0].Value.Trim()
            IncludePath = $rel
            Resolved    = $resolved
            Exists      = $false
            Candidates  = ($candidates -join '; ')
        }) | Out-Null
        if ($Verbose) {
            Write-Host "Potential script reference -> $($sf.FullName) :: $rel" -ForegroundColor DarkYellow
        }
    }
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

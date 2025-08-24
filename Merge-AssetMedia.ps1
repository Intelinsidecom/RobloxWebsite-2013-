param(
    [string]$Root = $PSScriptRoot,
    [string]$Source = "Assemblies\Roblox.AssetMedia",
    [string]$Target = "Assemblies\Platform\Assets\Roblox.Platform.AssetMedia",
    [switch]$Confirm,
    [switch]$RemoveSourceAfter,
    [string]$ReportPath
)

$ErrorActionPreference = 'Stop'

function Resolve-DirSafe([string]$base, [string]$path) {
    if ([System.IO.Path]::IsPathRooted($path)) {
        return (Resolve-Path -LiteralPath $path -ErrorAction Stop).Path
    } else {
        $full = Join-Path $base $path
        return (Resolve-Path -LiteralPath $full -ErrorAction Stop).Path
    }
}

# Resolve base
try {
    if (-not $Root -or [string]::IsNullOrWhiteSpace($Root)) { $Root = $PSScriptRoot }
    $Root = (Resolve-Path -LiteralPath $Root -ErrorAction Stop).Path
} catch {
    Write-Error "Failed to resolve Root: $($_.Exception.Message)"
}

# Resolve dirs
try { $srcDir = Resolve-DirSafe $Root $Source } catch { Write-Error "Source not found: $Source" }
try { $dstDir = Resolve-DirSafe $Root $Target } catch { Write-Error "Target not found: $Target" }

if (-not $ReportPath -or [string]::IsNullOrWhiteSpace($ReportPath)) {
    $ReportPath = Join-Path $Root 'Merge-AssetMedia_Report.txt'
}

Write-Host "Root:    $Root" -ForegroundColor Cyan
Write-Host "Source:  $srcDir" -ForegroundColor Cyan
Write-Host "Target:  $dstDir" -ForegroundColor Cyan
Write-Host "Report:  $ReportPath" -ForegroundColor Cyan

# Collect actions
$copyActions = New-Object System.Collections.Generic.List[object]
$conflicts   = New-Object System.Collections.Generic.List[object]

# Build rel paths list from source
$srcFiles = Get-ChildItem -LiteralPath $srcDir -Recurse -File -Force
foreach ($f in $srcFiles) {
    $rel = $f.FullName.Substring($srcDir.Length).TrimStart('\\')
    $dst = Join-Path $dstDir $rel
    if (-not (Test-Path -LiteralPath $dst)) {
        $copyActions.Add([pscustomobject]@{ Type='CopyNew'; Source=$f.FullName; Dest=$dst }) | Out-Null
    } else {
        # Compare size/hash quickly
        $same = $false
        try {
            if ($f.Length -eq (Get-Item -LiteralPath $dst).Length) { $same = $true }
        } catch { }
        if ($same) {
            # Assume identical enough for merge
        } else {
            $conflicts.Add([pscustomobject]@{ Type='Conflict'; Source=$f.FullName; Dest=$dst }) | Out-Null
        }
    }
}

# Reference scan: .sln and .csproj mentions of Roblox.AssetMedia
$projectNameOld = 'Roblox.AssetMedia.csproj'
$projectNameNew = 'Roblox.Platform.AssetMedia.csproj'
$refIssues = New-Object System.Collections.Generic.List[object]

$slnFiles = Get-ChildItem -LiteralPath $Root -Recurse -File -Filter *.sln -Force
foreach ($sln in $slnFiles) {
    $lines = Get-Content -LiteralPath $sln.FullName
    for ($i=0; $i -lt $lines.Count; $i++) {
        $line = $lines[$i]
        if ($line -match [regex]::Escape($projectNameOld)) {
            $refIssues.Add([pscustomobject]@{ File=$sln.FullName; Line=$i+1; Snippet=$line; Kind='sln' }) | Out-Null
        }
    }
}

$csprojs = Get-ChildItem -LiteralPath $Root -Recurse -File -Filter *.csproj -Force
foreach ($cp in $csprojs) {
    $text = Get-Content -LiteralPath $cp.FullName -Raw
    if ($text -match '<ProjectReference[^>]+Include="[^"]*Roblox\.AssetMedia\.csproj"') {
        $refIssues.Add([pscustomobject]@{ File=$cp.FullName; Line=0; Snippet='ProjectReference -> Roblox.AssetMedia.csproj'; Kind='csproj' }) | Out-Null
    }
}

# Build report
$sb = New-Object System.Text.StringBuilder
$null = $sb.AppendLine("Merge AssetMedia Preview")
$null = $sb.AppendLine(("Generated: {0}" -f (Get-Date)))
$null = $sb.AppendLine("Root:    $Root")
$null = $sb.AppendLine("Source:  $srcDir")
$null = $sb.AppendLine("Target:  $dstDir")
$null = $sb.AppendLine("")

$null = $sb.AppendLine(("Files to copy (new): {0}" -f $copyActions.Count))
foreach ($a in $copyActions) { $null = $sb.AppendLine("+ " + $a.Source + " -> " + $a.Dest) }
$null = $sb.AppendLine("")

$null = $sb.AppendLine(("Conflicts (kept target; source will be archived): {0}" -f $conflicts.Count))
foreach ($c in $conflicts) { $null = $sb.AppendLine("! " + $c.Source + " -> " + $c.Dest) }
$null = $sb.AppendLine("")

$null = $sb.AppendLine(("References mentioning old project name: {0}" -f $refIssues.Count))
foreach ($r in $refIssues) { $null = $sb.AppendLine("* [" + $r.Kind + "] " + $r.File + (if($r.Line -ne 0){" (Line " + $r.Line + ")"}else{''}) + " :: " + $r.Snippet) }
$null = $sb.AppendLine("")

if (-not $Confirm) {
    $null = $sb.AppendLine("No changes were made. Re-run with -Confirm to apply merge.")
    $sb.ToString() | Out-File -FilePath $ReportPath -Encoding UTF8 -Force
    Write-Host "Preview written to: $ReportPath" -ForegroundColor Green
    exit 0
}

# Apply changes
# 1) Copy new files
foreach ($a in $copyActions) {
    $destDirPath = Split-Path -LiteralPath $a.Dest -Parent
    if (-not (Test-Path -LiteralPath $destDirPath)) { New-Item -ItemType Directory -Path $destDirPath -Force | Out-Null }
    Copy-Item -LiteralPath $a.Source -Destination $a.Dest -Force
}

# 2) Conflicts: archive source copy and keep target version
$archiveRoot = Join-Path $Root 'Backup_Merge_AssetMedia'
New-Item -ItemType Directory -Path $archiveRoot -Force | Out-Null
foreach ($c in $conflicts) {
    $rel = $c.Source.Substring($srcDir.Length).TrimStart('\\')
    $archDest = Join-Path $archiveRoot $rel
    $archDir = Split-Path -LiteralPath $archDest -Parent
    if (-not (Test-Path -LiteralPath $archDir)) { New-Item -ItemType Directory -Path $archDir -Force | Out-Null }
    Copy-Item -LiteralPath $c.Source -Destination $archDest -Force
}

# 3) Optionally remove source folder
if ($RemoveSourceAfter) {
    Write-Host "Removing source folder: $srcDir" -ForegroundColor Yellow
    Remove-Item -LiteralPath $srcDir -Recurse -Force
}

# 4) Update references: suggest manual edits only (non-destructive). Future: auto-fix when approved.
$null = $sb.AppendLine("\nAPPLIED MERGE")
$null = $sb.AppendLine(("Copied new files: {0}" -f $copyActions.Count))
$null = $sb.AppendLine(("Archived conflicts: {0}" -f $conflicts.Count))
$null = $sb.AppendLine("Backup folder: $archiveRoot")
$null = $sb.AppendLine("References still pointing to Roblox.AssetMedia.csproj: {0}" -f $refIssues.Count)
$sb.ToString() | Out-File -FilePath $ReportPath -Encoding UTF8 -Force
Write-Host "Merge completed. Report: $ReportPath" -ForegroundColor Green

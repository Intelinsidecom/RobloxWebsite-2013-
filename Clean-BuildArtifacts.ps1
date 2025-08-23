param(
    [switch]$Confirm,
    [switch]$IncludeWebsiteBin,
    [string[]]$AdditionalExclude = @(),
    [string]$Root = $PSScriptRoot
)

$ErrorActionPreference = 'Stop'

function Get-FolderSizeBytes {
    param([string]$Path)
    try {
        $sum = (Get-ChildItem -LiteralPath $Path -Recurse -Force -ErrorAction SilentlyContinue | Where-Object { -not $_.PSIsContainer } | Measure-Object -Property Length -Sum).Sum
        if (-not $sum) { return 0 }
        return [int64]$sum
    } catch { return 0 }
}

function Format-Bytes {
    param([Int64]$Bytes)
    if ($Bytes -ge 1GB) { '{0:N2} GB' -f ($Bytes/1GB) }
    elseif ($Bytes -ge 1MB) { '{0:N2} MB' -f ($Bytes/1MB) }
    elseif ($Bytes -ge 1KB) { '{0:N2} KB' -f ($Bytes/1KB) }
    else { "$Bytes B" }
}

# Resolve and validate root
$rootPath = (Resolve-Path -LiteralPath $Root).Path
if (-not (Test-Path -LiteralPath $rootPath -PathType Container)) {
    Write-Error "Root path not found: $rootPath"
}

Write-Host "Repository root:" -NoNewline; Write-Host " $rootPath" -ForegroundColor Cyan

# Discover candidates: directories named 'bin' or 'obj' (stream findings in real time)
Write-Host "\nSearching for bin/obj folders..." -ForegroundColor Cyan
$candidates = @()
Get-ChildItem -LiteralPath $rootPath -Recurse -Directory -Force |
    Where-Object { $_.Name -in @('bin','obj') } |
    ForEach-Object {
        $candidates += $_
        Write-Host "Found: " -NoNewline; Write-Host $_.FullName -ForegroundColor DarkCyan
    }
Write-Host ("Total found (before exclusions): {0}" -f $candidates.Count)

# Build default exclusions
$defaultExcludePatterns = @(
    "\\.git\\",
    "\\.vs\\",
    "\\.idea\\",
    "\\.vscode\\",
    "\\node_modules\\",
    "\\packages\\"
)

# Protect Website/bin unless explicitly included
$websiteBinRegex = [regex]::Escape("\Website\") + ".*" + [regex]::Escape("\bin") + "(\\|$)"

# Compile exclusions
$allExcludePatterns = @()
$allExcludePatterns += $defaultExcludePatterns
$allExcludePatterns += $AdditionalExclude | Where-Object { $_ -and $_.Trim().Length -gt 0 }

function Test-ExcludedPath {
    param([string]$Path)
    foreach ($p in $allExcludePatterns) {
        if ($Path -like "*${p}*") { return $true }
    }
    return $false
}

# Filter candidates by exclusions and Website/bin protection
$targets = @()
foreach ($dir in $candidates) {
    $p = $dir.FullName
    if (Test-ExcludedPath -Path $p) { continue }
    if (-not $IncludeWebsiteBin -and ($p -match $websiteBinRegex)) { continue }
    $targets += $dir
}

if (-not $targets -or $targets.Count -eq 0) {
    Write-Host "No bin/obj folders found to clean (after exclusions)." -ForegroundColor Yellow
    exit 0
}

# Build preview with size and item counts
$preview = foreach ($t in $targets) {
    $size = Get-FolderSizeBytes -Path $t.FullName
    $itemCount = (Get-ChildItem -LiteralPath $t.FullName -Recurse -Force -ErrorAction SilentlyContinue | Measure-Object).Count
    [pscustomobject]@{
        Path      = $t.FullName
        Items     = $itemCount
        SizeBytes = $size
        Size      = (Format-Bytes $size)
    }
}

$totBytes = ($preview | Measure-Object -Property SizeBytes -Sum).Sum
Write-Host "\nThe following bin/obj folders would be deleted:" -ForegroundColor Green
$preview | Sort-Object SizeBytes -Descending | Select-Object Path, Items, Size | Format-Table -AutoSize | Out-Host
Write-Host ("Total folders: {0}" -f $preview.Count)
Write-Host ("Total size:   {0}" -f (Format-Bytes $totBytes))
if (-not $IncludeWebsiteBin) {
    Write-Host "Note: Website/bin is protected by default. Use -IncludeWebsiteBin to include it." -ForegroundColor DarkYellow
}

# Confirm
$shouldDelete = $false
if ($Confirm) {
    $shouldDelete = $true
} else {
    $resp = Read-Host "\nProceed to delete these folders? (Y/N)"
    if ($resp -match '^(?i:Y)$') { $shouldDelete = $true }
}

if (-not $shouldDelete) {
    Write-Host "Aborted. No changes were made." -ForegroundColor Yellow
    exit 0
}

# Delete
$errors = @()
foreach ($row in $preview) {
    try {
        Remove-Item -LiteralPath $row.Path -Recurse -Force -ErrorAction Stop
        Write-Host "Deleted: " -NoNewline; Write-Host $row.Path -ForegroundColor Cyan
    } catch {
        $errors += $_
        Write-Warning ("Failed: {0} -> {1}" -f $row.Path, $_.Exception.Message)
    }
}

if ($errors.Count -gt 0) {
    Write-Host ("Completed with {0} error(s)." -f $errors.Count) -ForegroundColor Yellow
    exit 1
} else {
    Write-Host "Cleanup completed successfully." -ForegroundColor Green
}

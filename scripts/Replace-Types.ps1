param(
    [string]$Root = (Resolve-Path -Path (Join-Path $PSScriptRoot '..')).Path,
    [switch]$Apply,
    [switch]$Backup,
    [string[]]$IncludeExtensions = @('cs'),
    [string[]]$ExcludeDirs = @('.git','.vs','bin','obj','packages','extracted_packages'),
    [hashtable]$Map = $null,
    [string]$MapJson = $null
)

# Default mappings. Keys are regex patterns; values are replacement strings.
# Use \b for word boundaries and escape dots.
$defaultMap = [ordered]@{
    '\bRoblox\.TextFilter\b' = 'Roblox.Platform.TextFilter';
    '\bRoblox\.TextFilter\.Client\b' = 'Roblox.Platform.TextFilter.Client'
}

if ($MapJson) {
    if (-not (Test-Path $MapJson)) { throw "MapJson file not found: $MapJson" }
    $json = Get-Content $MapJson -Raw | ConvertFrom-Json
    $Map = @{}
    foreach ($k in $json.PSObject.Properties.Name) { $Map[$k] = $json.$k }
}

if (-not $Map) { $Map = $defaultMap }

Write-Host "Root: $Root" -ForegroundColor Cyan
Write-Host "Apply: $($Apply.IsPresent)  Backup: $($Backup.IsPresent)" -ForegroundColor Cyan

# Build include glob
$includeFilter = $IncludeExtensions | ForEach-Object { "*.${_}" }

# Gather files
$files = Get-ChildItem -Path $Root -Recurse -File -Include $includeFilter -ErrorAction SilentlyContinue |
    Where-Object { $ExcludeDirs -notcontains $_.Directory.Name }

if (-not $files) { Write-Host 'No files found.'; exit 0 }

$totalFiles = 0
$totalChanges = 0

foreach ($file in $files) {
    # Skip if any excluded directory exists in full path segments
    $segments = $file.FullName -split "[\\/]"
    if ($segments | Where-Object { $ExcludeDirs -contains $_ }) { continue }

    $content = $null
    try {
        $content = Get-Content -Path $file.FullName -Raw -ErrorAction Stop
    }
    catch {
        Write-Host ("Skipping unreadable file: {0}  Reason: {1}" -f $file.FullName, $_.Exception.Message) -ForegroundColor DarkGray
        continue
    }
    if ($null -eq $content) { continue }

    $original = $content
    $fileChanges = 0

    foreach ($pattern in $Map.Keys) {
        $replacement = $Map[$pattern]
        $newContent = [regex]::Replace($content, $pattern, [System.Text.RegularExpressions.MatchEvaluator]{ param($m) $replacement }, 'IgnoreCase')
        if ($newContent -ne $content) {
            $diffCount = ([regex]::Matches($content, $pattern, 'IgnoreCase')).Count
            $fileChanges += $diffCount
            $content = $newContent
        }
    }

    if ($fileChanges -gt 0) {
        $totalFiles++
        $totalChanges += $fileChanges
        Write-Host ("{0} changes in {1}" -f $fileChanges, $file.FullName) -ForegroundColor Yellow
        if ($Apply) {
            if ($Backup) {
                $backupPath = "$($file.FullName).bak"
                if (-not (Test-Path $backupPath)) { Copy-Item -Path $file.FullName -Destination $backupPath }
            }
            Set-Content -Path $file.FullName -Value $content -NoNewline -Encoding UTF8
        }
    }
}

Write-Host "Total files changed: $totalFiles" -ForegroundColor Green
Write-Host "Total replacements: $totalChanges" -ForegroundColor Green

<#+
Usage examples:

1) Dry-run (list what would change):
   powershell -ExecutionPolicy Bypass -File scripts/Replace-Types.ps1 -Root .

2) Apply changes and create .bak backups:
   powershell -ExecutionPolicy Bypass -File scripts/Replace-Types.ps1 -Root . -Apply -Backup

3) Provide custom mappings via JSON (keys are regex patterns, values are replacements):
   {
     "\\bRoblox\\.TextFilter\\b": "Roblox.Platform.TextFilter",
     "\\bRoblox\\.TextFilter\\.Client\\b": "Roblox.Platform.TextFilter.Client",
     "\\bIRoleSet\\b": "IRoleset"
   }
   powershell -ExecutionPolicy Bypass -File scripts/Replace-Types.ps1 -MapJson .\scripts\type-map.json -Apply

Notes:
- Patterns are regex; dots must be escaped. Use \\b for word boundaries.
- Excludes common build folders by default; adjust -ExcludeDirs as needed.
- Set -IncludeExtensions to limit to certain file types (default: cs).
#>

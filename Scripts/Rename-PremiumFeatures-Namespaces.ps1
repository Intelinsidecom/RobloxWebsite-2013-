param()

$ErrorActionPreference = 'Stop'

$root = Split-Path -Parent $PSScriptRoot
Write-Host "Repo root: $root" -ForegroundColor Cyan

# Paths
$serverLibDir = Join-Path $root "Assemblies\Platform\Premium\Roblox.Platform.PremiumFeatures\Roblox.Platform.PremiumFeatures"

# 1) Dry-run: show matches
Write-Host "Scanning for namespace declarations to update (server library only)..." -ForegroundColor Yellow
Get-ChildItem -Path $serverLibDir -Recurse -Include *.cs |
  Select-String -Pattern "\bnamespace\s+Roblox\.PremiumFeatures\b" |
  ForEach-Object { "NS: $($_.Path):$($_.LineNumber): $($_.Line.Trim())" }

Write-Host "Scanning for using directives to update (solution-wide)..." -ForegroundColor Yellow
Get-ChildItem -Path $root -Recurse -Include *.cs |
  Select-String -Pattern "\busing\s+Roblox\.PremiumFeatures(\.|;)" |
  ForEach-Object { "USING: $($_.Path):$($_.LineNumber): $($_.Line.Trim())" }

# 2) Backup the PremiumFeatures assembly folder being modified
$timestamp = Get-Date -Format yyyyMMddHHmmss
$backup = Join-Path $root "backup-premiumfeatures-namespace-$timestamp.zip"
Write-Host "Creating backup: $backup" -ForegroundColor Green
Compress-Archive -Path $serverLibDir -DestinationPath $backup -Force

# 3) Update namespace declarations inside server library files
Write-Host "Updating namespace declarations under server library..." -ForegroundColor Cyan
Get-ChildItem -Path $serverLibDir -Recurse -Include *.cs | ForEach-Object {
  $p = $_.FullName
  $content = Get-Content -Raw -LiteralPath $p
  $updated = [regex]::Replace($content, '\bnamespace\s+Roblox\.PremiumFeatures\b', 'namespace Roblox.Platform.PremiumFeatures')
  if ($updated -ne $content) {
    Set-Content -LiteralPath $p -Value $updated -NoNewline
    Write-Host "Updated namespace: $p" -ForegroundColor Green
  }
}

# 4) Update using directives across the solution
Write-Host "Updating using directives solution-wide..." -ForegroundColor Cyan
$replacements = @(
  @{ from = '\busing\s+Roblox\.PremiumFeatures\.Interfaces\b'; to = 'using Roblox.Platform.PremiumFeatures.Interfaces' },
  @{ from = '\busing\s+Roblox\.PremiumFeatures\.Enums\b';      to = 'using Roblox.Platform.PremiumFeatures.Models.Enums' },
  @{ from = '\busing\s+Roblox\.PremiumFeatures\b';             to = 'using Roblox.Platform.PremiumFeatures' }
)

Get-ChildItem -Path $root -Recurse -Include *.cs | ForEach-Object {
  $p = $_.FullName
  $text = Get-Content -Raw -LiteralPath $p
  $orig = $text
  foreach ($rep in $replacements) {
    $text = [regex]::Replace($text, $rep.from, $rep.to)
  }
  if ($text -ne $orig) {
    Set-Content -LiteralPath $p -Value $text
    Write-Host "Updated usings: $p" -ForegroundColor Green
  }
}

Write-Host "Rename completed. You can now build the solution." -ForegroundColor Green

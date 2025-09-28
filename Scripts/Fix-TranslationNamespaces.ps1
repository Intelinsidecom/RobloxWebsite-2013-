param(
    [string]$TranslationsPath = "Assemblies/Platform/Translations/Roblox.Platform.TranslationResources",
    [switch]$DryRun
)

$ErrorActionPreference = 'Stop'

# Resolve repo root so script works from any folder
$repoRoot = Split-Path -Path $PSScriptRoot -Parent
if (-not [System.IO.Path]::IsPathRooted($TranslationsPath)) {
    $TranslationsPath = Join-Path -Path $repoRoot -ChildPath $TranslationsPath
}

if (-not (Test-Path -LiteralPath $TranslationsPath)) {
    Write-Error "Translations path not found: $TranslationsPath"
    exit 1
}

# Collect all C# files under the target folder
$files = Get-ChildItem -Path $TranslationsPath -Filter *.cs -Recurse -File
if (-not $files) {
    Write-Host "No .cs files found under: $TranslationsPath"
    exit 0
}

# Patterns to fix
$badPatternFeature = 'namespace\s+Roblox\.Platform\.TranslationResources\.Feature(?:internal|public)\b'
$badPatternRoot   = 'namespace\s+Roblox\.Platform\.TranslationResources(?:internal|public)\b'

# Count bad namespaces before
$patterns = @($badPatternFeature,$badPatternRoot)
$beforeMatches = $files | Select-String -Pattern $patterns -AllMatches
$beforeCount = ($beforeMatches | Measure-Object).Count
Write-Host ("Before: found {0} malformed namespace declarations" -f $beforeCount)

$modified = @()

foreach ($f in $files) {
    $content = Get-Content -LiteralPath $f.FullName -Raw
    $newContent = $content

    # Fix malformed namespace patterns (public)
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Commonpublic\s*{', 'namespace Roblox.Platform.TranslationResources.Common {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Authenticationpublic\s*{', 'namespace Roblox.Platform.TranslationResources.Authentication {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Featurepublic\s*{', 'namespace Roblox.Platform.TranslationResources.Feature {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Communicationpublic\s*{', 'namespace Roblox.Platform.TranslationResources.Communication {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.CommonUIpublic\s*{', 'namespace Roblox.Platform.TranslationResources.CommonUI {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Moderationpublic\s*{', 'namespace Roblox.Platform.TranslationResources.Moderation {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Notificationspublic\s*{', 'namespace Roblox.Platform.TranslationResources.Notifications {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Purchasingpublic\s*{', 'namespace Roblox.Platform.TranslationResources.Purchasing {'

    # Fix malformed namespace patterns (internal)
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Commoninternal\s*{', 'namespace Roblox.Platform.TranslationResources.Common {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Authenticationinternal\s*{', 'namespace Roblox.Platform.TranslationResources.Authentication {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Featureinternal\s*{', 'namespace Roblox.Platform.TranslationResources.Feature {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Communicationinternal\s*{', 'namespace Roblox.Platform.TranslationResources.Communication {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.CommonUIinternal\s*{', 'namespace Roblox.Platform.TranslationResources.CommonUI {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Moderationinternal\s*{', 'namespace Roblox.Platform.TranslationResources.Moderation {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Notificationsinternal\s*{', 'namespace Roblox.Platform.TranslationResources.Notifications {'
    $newContent = $newContent -replace 'namespace Roblox\.Platform\.TranslationResources\.Purchasinginternal\s*{', 'namespace Roblox.Platform.TranslationResources.Purchasing {'

    # Generic fallbacks for trailing 'public' or 'internal' after any namespace
    $newContent = $newContent -replace 'namespace ([A-Za-z0-9\.]+)public\s*{', 'namespace $1 {'
    $newContent = $newContent -replace 'namespace ([A-Za-z0-9\.]+)internal\s*{', 'namespace $1 {'
    
    # Fix using statements that reference the wrong namespace
    $newContent = $newContent -replace 'using Roblox\.TranslationResources\.Common;', 'using Roblox.Platform.TranslationResources.Common;'
    $newContent = $newContent -replace 'using Roblox\.TranslationResources\.Authentication;', 'using Roblox.Platform.TranslationResources.Authentication;'
    $newContent = $newContent -replace 'using Roblox\.TranslationResources\.Feature;', 'using Roblox.Platform.TranslationResources.Feature;'
    $newContent = $newContent -replace 'using Roblox\.TranslationResources\.Communication;', 'using Roblox.Platform.TranslationResources.Communication;'
    $newContent = $newContent -replace 'using Roblox\.TranslationResources\.CommonUI;', 'using Roblox.Platform.TranslationResources.CommonUI;'
    $newContent = $newContent -replace 'using Roblox\.TranslationResources\.Moderation;', 'using Roblox.Platform.TranslationResources.Moderation;'
    $newContent = $newContent -replace 'using Roblox\.TranslationResources\.Notifications;', 'using Roblox.Platform.TranslationResources.Notifications;'
    $newContent = $newContent -replace 'using Roblox\.TranslationResources\.Purchasing;', 'using Roblox.Platform.TranslationResources.Purchasing;'

    $newContent = [regex]::Replace($newContent, $badPatternFeature, 'namespace Roblox.Platform.TranslationResources.Feature')
    $newContent = [regex]::Replace($newContent, $badPatternRoot  , 'namespace Roblox.Platform.TranslationResources')

    if ($newContent -ne $content) {
        if ($DryRun) {
            $modified += $f.FullName
        } else {
            # Preserve UTF8 encoding
            Set-Content -LiteralPath $f.FullName -Value $newContent -Encoding UTF8
            $modified += $f.FullName
        }
    }
}

# Count after
$afterMatches = $files | Select-String -Pattern $patterns -AllMatches
$afterCount = ($afterMatches | Measure-Object).Count

Write-Host ("After: found {0} malformed namespace declarations" -f $afterCount)
Write-Host ("Files changed: {0}" -f $modified.Count)

if ($modified.Count -gt 0) {
    Write-Host "Modified files:" -ForegroundColor Cyan
    $modified | ForEach-Object { Write-Host " - $_" }
}

if ($DryRun) {
    Write-Host "Dry run mode: no files were written. Re-run without -DryRun to apply changes." -ForegroundColor Yellow
}

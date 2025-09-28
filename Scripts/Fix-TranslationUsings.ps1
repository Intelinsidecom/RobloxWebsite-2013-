param(
    [string]$TranslationsPath = "Assemblies/Platform/Translations/Roblox.Platform.TranslationResources",
    [switch]$DryRun
)

$ErrorActionPreference = 'Stop'

# Resolve repo root (one level up from scripts folder)
$repoRoot = Split-Path -Path $PSScriptRoot -Parent

# If FeaturePath is not rooted, make it relative to repo root
if (-not [System.IO.Path]::IsPathRooted($TranslationsPath)) {
    $TranslationsPath = Join-Path -Path $repoRoot -ChildPath $TranslationsPath
}

if (-not (Test-Path -LiteralPath $TranslationsPath)) {
    Write-Error "Translations path not found: $TranslationsPath"
    exit 1
}

$files = Get-ChildItem -Path $TranslationsPath -Filter *.cs -Recurse -File
if (-not $files) {
    Write-Host "No .cs files found under: $TranslationsPath"
    exit 0
}

$neededUsings = @(
    'using Roblox.Platform.TranslationResources;',
    'using System.Collections.Generic;'
)

$modified = @()

foreach ($f in $files) {
    $content = Get-Content -LiteralPath $f.FullName -Raw

    # detect files within the Feature namespace (multiline aware)
    $hasNamespace = $content -match "(?m)^\s*namespace\s+Roblox\\.Platform\\.TranslationResources(\\.Feature)?\b"
    if (-not $hasNamespace) { continue }

    $changed = $false
    foreach ($u in $neededUsings) {
        if ($content -notmatch [regex]::Escape($u)) {
            # Prepend the missing using at the very start of the file
            $content = $u + "`r`n" + $content
            $changed = $true
        }
    }

    if ($changed) {
        if ($DryRun) {
            $modified += $f.FullName
        } else {
            Set-Content -LiteralPath $f.FullName -Value $content -Encoding UTF8
            $modified += $f.FullName
        }
    }
}

# Fix missing base interfaces and using statements in Roblox.Platform.TranslationResources
$projectPath = "C:\Users\Intel\Documents\GitHub\RobloxWebsite-2013-\Assemblies\Platform\Translations\Roblox.Platform.TranslationResources"

Write-Host "Ensuring base enums exist and fixing using statements + accessibility..." -ForegroundColor Green

# Ensure TranslationResourceLocale enum exists as its own file
$baseEnumsPath = Join-Path $projectPath "Roblox.Platform.TranslationResources"
if (-not (Test-Path -LiteralPath $baseEnumsPath)) { New-Item -ItemType Directory -Path $baseEnumsPath | Out-Null }
$localeEnumFile = Join-Path $baseEnumsPath "TranslationResourceLocale.cs"
if (-not (Test-Path -LiteralPath $localeEnumFile)) {
    $localeEnumContent = @"
using System;
namespace Roblox.Platform.TranslationResources
{
    public enum TranslationResourceLocale
    {
        en_us,
        de_de,
        es_es,
        fr_fr,
        ja_jp,
        ko_kr,
        pt_br,
        ru_ru,
        th_th,
        tr_tr,
        vi_vn,
        zh_cjv,
        zh_cn,
        zh_tw,
        id_id,
        it_it
    }
}
"@
    Set-Content -LiteralPath $localeEnumFile -Value $localeEnumContent -Encoding UTF8
    Write-Host "Created: $localeEnumFile" -ForegroundColor Green
}

# Fix using statements and ensure public interfaces in all files
$csFiles = Get-ChildItem -Path $projectPath -Filter "*.cs" -Recurse
$fixedFiles = 0

foreach ($file in $csFiles) {
    $content = Get-Content -LiteralPath $file.FullName -Raw
    $originalContent = $content

    # Add missing using statements at the top if not present
    if ($content -notmatch "(?m)^using System;\s*$") {
        $content = "using System;`r`n" + $content
    }
    if ($content -notmatch "(?m)^using System\.Collections\.Generic;\s*$") {
        # place it after using System;
        $content = $content -replace "(?m)^(using System;\s*)", "`$1`r`nusing System.Collections.Generic;`r`n"
    }

    # Fix wrong namespace usings
    $content = $content -replace 'using Roblox\.TranslationResources\.Common;', 'using Roblox.Platform.TranslationResources.Common;'
    $content = $content -replace 'using Roblox\.TranslationResources\.Authentication;', 'using Roblox.Platform.TranslationResources.Authentication;'
    $content = $content -replace 'using Roblox\.TranslationResources\.Feature;', 'using Roblox.Platform.TranslationResources.Feature;'
    $content = $content -replace 'using Roblox\.TranslationResources\.Communication;', 'using Roblox.Platform.TranslationResources.Communication;'
    $content = $content -replace 'using Roblox\.TranslationResources\.CommonUI;', 'using Roblox.Platform.TranslationResources.CommonUI;'
    $content = $content -replace 'using Roblox\.TranslationResources\.Moderation;', 'using Roblox.Platform.TranslationResources.Moderation;'
    $content = $content -replace 'using Roblox\.TranslationResources\.Notifications;', 'using Roblox.Platform.TranslationResources.Notifications;'
    $content = $content -replace 'using Roblox\.TranslationResources\.Purchasing;', 'using Roblox.Platform.TranslationResources.Purchasing;'

    # Ensure interfaces are public when referenced by public containers
    # Replace lines that declare interfaces with no 'public' with 'public interface'
    $content = [regex]::Replace($content, '(?m)^(\s*)(?:internal\s+)?interface\s+(I\w+Resources\b)', '$1public interface $2')

    if ($content -ne $originalContent) {
        Set-Content -LiteralPath $file.FullName -Value $content -Encoding UTF8
        $fixedFiles++
        Write-Host "Fixed: $($file.FullName)" -ForegroundColor Yellow
    }
}

Write-Host "Using/accessibility fix complete. Fixed $fixedFiles files." -ForegroundColor Green

Write-Host ("Files changed: {0}" -f $modified.Count)
if ($modified.Count -gt 0) {
    Write-Host "Modified files:" -ForegroundColor Cyan
    $modified | ForEach-Object { Write-Host " - $_" }
}

if ($DryRun) { Write-Host "Dry run: no files written." -ForegroundColor Yellow }

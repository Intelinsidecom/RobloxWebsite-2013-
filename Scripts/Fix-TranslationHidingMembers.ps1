param(
    [string]$ProjectRoot = "$(Split-Path -Parent $PSScriptRoot)\Assemblies\Platform\Translations\Roblox.Platform.TranslationResources"
)

$ErrorActionPreference = 'Stop'
$featureDir = Join-Path $ProjectRoot "Roblox.Platform.TranslationResources.Feature"
if (!(Test-Path $featureDir)) {
    Write-Error "Feature directory not found: $featureDir"
}

# Files to process: all feature files except *_en_us.cs
$files = Get-ChildItem -Path $featureDir -Recurse -Include *.cs | Where-Object { $_.Name -notmatch "_en_us\.cs$" }

# Regex patterns to remove hiding members (be generous on method bodies)
$patterns = @(
    # Remove auto or simple property State declarations (with optional access modifier and 'new' keyword)
    '(?ms)^[ \t]*public[ \t]+(?:new[ \t]+)?TranslationResourceState[ \t]+State[ \t]*\{[^}]*\}[ \t]*\r?\n',
    # Remove any localized GetAllKeys() implementation
    '(?ms)^[ \t]*public[ \t]+(?:new[ \t]+)?IReadOnlyDictionary<\s*string\s*,\s*string\s*>[ \t]+GetAllKeys\(\)[ \t]*\{[\s\S]*?\}[ \t]*\r?\n',
    # Remove any localized GetFullContentNamespaceName() implementation
    '(?ms)^[ \t]*public[ \t]+(?:new[ \t]+)?string[ \t]+GetFullContentNamespaceName\(\)[ \t]*\{[\s\S]*?\}[ \t]*\r?\n'
)

$changed = 0
foreach ($file in $files) {
    $text = Get-Content -LiteralPath $file.FullName -Raw
    $orig = $text
    foreach ($pat in $patterns) {
        $text = [System.Text.RegularExpressions.Regex]::Replace($text, $pat, '', 'Multiline')
    }
    if ($text -ne $orig) {
        Set-Content -LiteralPath $file.FullName -Value $text -Encoding UTF8
        Write-Host "Fixed hiding members in: $($file.FullName)"
        $changed++
    }
}

Write-Host "Completed. Files changed: $changed"

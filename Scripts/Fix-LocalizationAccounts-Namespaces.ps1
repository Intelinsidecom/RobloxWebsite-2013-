Param(
    [string]$Root = "${PSScriptRoot}\..\Assemblies\Localization"
)

Write-Host "Fixing malformed namespaces in: $Root"

$files = Get-ChildItem -Path $Root -Recurse -Include *.cs -File
Write-Host ("Discovered {0} .cs files under {1}" -f $files.Count, $Root)
$pattern1 = 'namespace\s+Roblox\.Localization\.Accountsinternal\b'
$replacement1 = 'namespace Roblox.Localization.Accounts'

$pattern2 = 'namespace\s+Roblox\.Localization\.Accountspublic\b'
$replacement2 = 'namespace Roblox.Localization.Accounts'

# Audit subnamespace fixes
$pattern3 = 'namespace\s+Roblox\.Localization\.Auditinternal\b'
$replacement3 = 'namespace Roblox.Localization.Audit'

$pattern4 = 'namespace\s+Roblox\.Localization\.Auditpublic\b'
$replacement4 = 'namespace Roblox.Localization.Audit'

# Properties subnamespace fixes
$pattern5 = 'namespace\s+Roblox\.Localization\.Accounts\.Propertiesinternal\b'
$replacement5 = 'namespace Roblox.Localization.Accounts.Properties'

$pattern6 = 'namespace\s+Roblox\.Localization\.Accounts\.Propertiespublic\b'
$replacement6 = 'namespace Roblox.Localization.Accounts.Properties'

# Implementations subnamespace fixes
$pattern7 = 'namespace\s+Roblox\.Localization\.Accounts\.Implementationsinternal\b'
$replacement7 = 'namespace Roblox.Localization.Accounts.Implementations'

$pattern8 = 'namespace\s+Roblox\.Localization\.Accounts\.Implementationspublic\b'
$replacement8 = 'namespace Roblox.Localization.Accounts.Implementations'

# Fix incorrect using directives (Platform -> non-Platform)
# Preserve any subnamespaces by capturing them
$usingPattern = 'using\s+Roblox\.Platform\.Localization(\..*)?'
$usingReplacement = 'using Roblox.Localization$1'

# Fix incorrect using for TranslationResources (non-Platform -> Platform)
$usingTrPattern = 'using\s+Roblox\.TranslationResources(\..*)?'
$usingTrReplacement = 'using Roblox.Platform.TranslationResources$1'

$changed = 0
foreach ($f in $files) {
    $content = Get-Content -Raw -LiteralPath $f.FullName
    $new = $content `
        -replace $pattern1, $replacement1 `
        -replace $pattern2, $replacement2 `
        -replace $pattern3, $replacement3 `
        -replace $pattern4, $replacement4 `
        -replace $pattern5, $replacement5 `
        -replace $pattern6, $replacement6 `
        -replace $pattern7, $replacement7 `
        -replace $pattern8, $replacement8 `
        -replace $usingPattern, $usingReplacement `
        -replace $usingTrPattern, $usingTrReplacement `
        -replace 'Roblox\.Platform\.Localization\.Accounts\.Implementations', 'Roblox.Localization.Accounts.Implementations' `
        -replace 'Roblox\.Platform\.Localization\.Accounts\.', 'Roblox.Localization.Accounts.'
    if ($new -ne $content) {
        Set-Content -LiteralPath $f.FullName -Value $new -NoNewline -Encoding UTF8
        Write-Host "Fixed: $($f.FullName)"
        $changed++
    }
}

if ($changed -eq 0) {
    Write-Host "No files required changes."
} else {
    Write-Host "Done. Files changed: $changed"
}

# Second pass: fix accessibility for specific interfaces/enums that cause CS0050/CS0051/CS0053
$publicFixTargets = @(
    'IAccountLocaleAccessor',
    'IAccountLocaleBuilder',
    'ILocalizationResourceProvider',
    'IAccountCountriesAuditCompositeEntry',
    'AccountCountriesAuditEntryMetadataType',
    'AccountCountriesChangeAgentType'
)

foreach ($f in $files) {
    $content = Get-Content -Raw -LiteralPath $f.FullName
    $new = $content
    foreach ($name in $publicFixTargets) {
        $patternInterface = "(?m)^(\s*)interface\s+$([regex]::Escape($name))\b"
        $patternEnum = "(?m)^(\s*)enum\s+$([regex]::Escape($name))\b"
        $patternClass = "(?m)^(\s*)class\s+$([regex]::Escape($name))\b"

        # interface -> public interface
        $new = [regex]::Replace($new, $patternInterface, { param($m) $m.Groups[1].Value + 'public interface ' + $name })
        # enum -> public enum
        $new = [regex]::Replace($new, $patternEnum, { param($m) $m.Groups[1].Value + 'public enum ' + $name })
        # class -> public class
        $new = [regex]::Replace($new, $patternClass, { param($m) $m.Groups[1].Value + 'public class ' + $name })
    }
    if ($new -ne $content) {
        Set-Content -LiteralPath $f.FullName -Value $new -NoNewline -Encoding UTF8
        Write-Host "Accessibility fixed: $($f.FullName)"
    }
}

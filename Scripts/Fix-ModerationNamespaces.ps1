param(
    [string]$Root = "${PSScriptRoot}\..\Assemblies\Moderation\Roblox.Moderation"
)

Write-Host "Fixing namespaces and usings under: $Root"

$files = Get-ChildItem -Path $Root -Include *.cs -Recurse -ErrorAction SilentlyContinue

$replacements = @(
    # Malformed namespace declarations
    @{ Pattern = 'namespace\s+Roblox\.Moderationpublic'; Replacement = 'namespace Roblox.Moderation' },
    @{ Pattern = 'namespace\s+Roblox\.Moderation\.Factoriesinternal'; Replacement = 'namespace Roblox.Moderation.Factories' },
    @{ Pattern = 'namespace\s+Roblox\.Moderation\.Entitiesinternal'; Replacement = 'namespace Roblox.Moderation.Entities' },
    @{ Pattern = 'namespace\s+Roblox\.Moderation\.Interfacesinternal'; Replacement = 'namespace Roblox.Moderation.Interfaces' },
    @{ Pattern = 'namespace\s+Roblox\.Moderation\.Implementationinternal'; Replacement = 'namespace Roblox.Moderation.Implementation' },

    # Incorrect usings pointing to Platform.Moderation
    @{ Pattern = 'using\s+Roblox\.Platform\.Moderation\.Entities;'; Replacement = 'using Roblox.Moderation.Entities;' },
    @{ Pattern = 'using\s+Roblox\.Platform\.Moderation\.Interfaces;'; Replacement = 'using Roblox.Moderation.Interfaces;' },
    @{ Pattern = 'using\s+Roblox\.Platform\.Moderation\.Implementation;'; Replacement = 'using Roblox.Moderation.Implementation;' },
    @{ Pattern = 'using\s+Roblox\.Platform\.Moderation\.Factories;'; Replacement = 'using Roblox.Moderation.Factories;' },
    @{ Pattern = 'using\s+Roblox\.Platform\.Moderation;'; Replacement = 'using Roblox.Moderation;' }
)

$changed = 0
foreach ($file in $files) {
    $content = Get-Content -Path $file.FullName -Raw
    $original = $content

    foreach ($rep in $replacements) {
        $content = [regex]::Replace($content, $rep.Pattern, $rep.Replacement)
    }

    if ($content -ne $original) {
        Set-Content -Path $file.FullName -Value $content -NoNewline
        Write-Host "Updated: $($file.FullName)"
        $changed++
    }
}

Write-Host "Done. Files updated: $changed"

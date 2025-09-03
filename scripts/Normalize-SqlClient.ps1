Param(
    [string]$Root = (Resolve-Path "$PSScriptRoot\..\").Path
)

Write-Host "Normalizing Microsoft.Data.SqlClient references under: $Root" -ForegroundColor Cyan

$csprojFiles = Get-ChildItem -Path $Root -Filter *.csproj -Recurse -ErrorAction SilentlyContinue | Select-Object -ExpandProperty FullName
$changedFiles = @()
$errors = 0

foreach ($file in $csprojFiles) {
    try {
        [xml]$xml = Get-Content -LiteralPath $file -ErrorAction Stop
    } catch {
        Write-Warning "Failed to read XML: $file - $_"
        $errors++
        continue
    }

    # Determine if the project file uses the MSBuild default namespace
    $nsUri = $xml.DocumentElement.NamespaceURI
    $nsMgr = New-Object System.Xml.XmlNamespaceManager($xml.NameTable)
    if ([string]::IsNullOrEmpty($nsUri)) {
        # SDK-style commonly has no default namespace; we'll query without ns
        $useNs = $false
    } else {
        $useNs = $true
        $nsMgr.AddNamespace('msb', $nsUri)
    }

    # Build queries for both namespaced and non-namespaced
    $queryNs = "//msb:PackageReference[@Include='Microsoft.Data.SqlClient']"
    $queryNoNs = "//PackageReference[@Include='Microsoft.Data.SqlClient']"

    $nodes = @()
    if ($useNs) {
        $nodes = @($xml.SelectNodes($queryNs, $nsMgr))
    }
    if (-not $nodes -or $nodes.Count -eq 0) {
        $nodes = @($xml.SelectNodes($queryNoNs))
    }

    if (-not $nodes -or $nodes.Count -eq 0) { continue }

    $didChange = $false

    # Ensure Version attribute is set to 5.2.2 (inclusive lower bound)
    foreach ($n in @($nodes)) {
        if (-not $n.Attributes["Version"] -or $n.Attributes["Version"].Value -ne "5.2.2") {
            if ($n.Attributes["Version"]) { $null = $n.Attributes.RemoveNamedItem("Version") }
            $attr = $xml.CreateAttribute("Version")
            $attr.Value = "5.2.2"
            $null = $n.Attributes.Append($attr)
            $didChange = $true
        }
    }

    # Deduplicate down to a single node
    if ($nodes.Count -gt 1) {
        for ($i = 1; $i -lt $nodes.Count; $i++) {
            [void]$nodes[$i].ParentNode.RemoveChild($nodes[$i])
            $didChange = $true
        }
    }

    if ($didChange) {
        try {
            $xml.Save($file)
            $changedFiles += $file
            Write-Host "Normalized: $file" -ForegroundColor Green
        } catch {
            Write-Warning "Failed to save: $file - $_"
            $errors++
        }
    }
}

Write-Host "--- Summary ---" -ForegroundColor Yellow
Write-Host ("Changed files: {0}" -f $changedFiles.Count)
if ($changedFiles.Count -gt 0) {
    $changedFiles | ForEach-Object { Write-Host " - $_" }
}
Write-Host ("Errors: {0}" -f $errors)

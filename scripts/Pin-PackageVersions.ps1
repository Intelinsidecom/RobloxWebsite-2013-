param(
    [string]$Root = (Resolve-Path ".."),
    [switch]$WhatIf,
    [switch]$NoBackup
)

# Target package pins
$Pins = @{
    'System.Configuration.ConfigurationManager' = '7.0.0'
    'System.Data.SqlClient' = '4.9.0'
    'AWSSDK.Core' = '3.7.500.11'
    'System.Security.Permissions' = '7.0.0'
}

Write-Host "Root: $Root" -ForegroundColor Cyan

$files = Get-ChildItem -Path $Root -Recurse -Include *.csproj,Directory.Build.props -File | Sort-Object FullName

if (-not $files) {
    Write-Host "No project files found under $Root" -ForegroundColor Yellow
    exit 0
}

# Utilities
function Update-PackageReferenceVersion {
    param(
        [xml]$Xml,
        [string]$PackageId,
        [string]$TargetVersion
    )

    $nsMgr = New-Object System.Xml.XmlNamespaceManager($Xml.NameTable)
    $nsMgr.AddNamespace('msb', 'http://schemas.microsoft.com/developer/msbuild/2003')

    # Try both namespaced and non-namespaced forms
    $xpathCandidates = @(
        "//PackageReference[@Include='$PackageId']",
        "//msb:PackageReference[@Include='$PackageId']"
    )

    $changed = $false
    foreach ($xp in $xpathCandidates) {
        $nodes = $Xml.SelectNodes($xp, $nsMgr)
        foreach ($n in $nodes) {
            $current = $n.GetAttribute('Version')
            if ([string]::IsNullOrEmpty($current)) {
                # Some projects use `<Version>...</Version>` child element
                $verElem = $n.SelectSingleNode('Version')
                if ($verElem -and $verElem.InnerText -ne $TargetVersion) {
                    Write-Verbose "Setting child Version element for $PackageId to $TargetVersion"
                    $verElem.InnerText = $TargetVersion
                    $changed = $true
                } elseif (-not $verElem) {
                    # Add Version attribute if none exists
                    if ($n.OwnerDocument -and $n.Attributes) {
                        $null = $n.Attributes.Append($Xml.CreateAttribute('Version'))
                        $n.SetAttribute('Version', $TargetVersion)
                        $changed = $true
                    }
                }
            } elseif ($current -ne $TargetVersion) {
                $n.SetAttribute('Version', $TargetVersion)
                $changed = $true
            }
        }
    }
    return $changed
}

$summary = @()

foreach ($f in $files) {
    $text = Get-Content -Raw -LiteralPath $f.FullName

    # Parse as XML; skip files that are not valid XML
    try {
        [xml]$xml = $text
    } catch {
        Write-Host "Skipping invalid XML: $($f.FullName)" -ForegroundColor DarkYellow
        continue
    }

    $fileChanged = $false

    foreach ($kvp in $Pins.GetEnumerator()) {
        $pkg = $kvp.Key
        $ver = $kvp.Value
        $didChange = Update-PackageReferenceVersion -Xml $xml -PackageId $pkg -TargetVersion $ver
        if ($didChange) { $fileChanged = $true }
    }

    if ($fileChanged) {
        if ($WhatIf) {
            Write-Host "[DRY-RUN] Would update: $($f.FullName)" -ForegroundColor Yellow
            continue
        }
        if (-not $NoBackup) {
            Copy-Item -LiteralPath $f.FullName -Destination ($f.FullName + '.bak') -Force
        }
        $xml.Save($f.FullName)
        $summary += $f.FullName
        Write-Host "Updated: $($f.FullName)" -ForegroundColor Green
    }
}

if ($summary.Count -eq 0) {
    Write-Host "No changes were necessary (already pinned)." -ForegroundColor Cyan
} else {
    Write-Host "`nPinned versions in $($summary.Count) file(s)." -ForegroundColor Cyan
}

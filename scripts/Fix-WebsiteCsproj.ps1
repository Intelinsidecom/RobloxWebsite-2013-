param(
    [string]$RepoRoot = (Get-Location).Path,
    [string]$CsprojPath = (Join-Path (Get-Location).Path 'Website\Roblox.Website.csproj'),
    [switch]$Force
)

Write-Host "RepoRoot: $RepoRoot"
Write-Host "CsprojPath: $CsprojPath"

if (-not (Test-Path $CsprojPath)) {
    Write-Error "Website csproj not found at $CsprojPath"
    exit 1
}

# Cache DLL files for quick lookup when repairing HintPath-only entries
Write-Host "Caching DLL files (bin directories preferred)..."
$dllCache = @{}
Get-ChildItem -Path $RepoRoot -Recurse -Filter *.dll -ErrorAction SilentlyContinue |
    Where-Object { $_.Directory.Name -eq 'bin' -or $_.FullName -like "*Website*bin*" } |
    ForEach-Object { $dllCache[$_.Name] = $_.FullName }
Write-Host "Cached $($dllCache.Count) DLLs"

# Build a cache of assembly name -> csproj path for project reference conversion
Write-Host "Caching csproj assembly names..."
$csprojCache = @{}
$csprojFiles = Get-ChildItem -Path $RepoRoot -Recurse -Filter *.csproj -ErrorAction SilentlyContinue
foreach ($f in $csprojFiles) {
    $path = $f.FullName
    $key = [IO.Path]::GetFileNameWithoutExtension($f.Name)
    if (-not $csprojCache.ContainsKey($key)) { $csprojCache[$key] = $path }
    try {
        [xml]$tmp = Get-Content $path
        $asmNode = $tmp.Project.PropertyGroup.AssemblyName
        if ($asmNode) {
            $asm = $asmNode.'#text'
            if ($asm -and -not $csprojCache.ContainsKey($asm)) { $csprojCache[$asm] = $path }
        }
    } catch {}
}
Write-Host "Discovered $($csprojCache.Count) assemblies"

function Find-Csproj([string]$asmName) {
    $originalName = $asmName
    if ($assemblyAliasMap.ContainsKey($asmName)) { $asmName = $assemblyAliasMap[$asmName] }
    if ($csprojCache.ContainsKey($asmName)) { return $csprojCache[$asmName] }
    if ($csprojCache.ContainsKey($originalName)) { return $csprojCache[$originalName] }

    $variants = @()
    if ($asmName -match '^Roblox\.Platform\.') {
        $variants += ($asmName -replace '^Roblox\.Platform\.', 'Roblox.')
    } elseif ($asmName -match '^Roblox\.') {
        $variants += ($asmName -replace '^Roblox\.', 'Roblox.Platform.')
        $variants += 'Roblox.' + ($asmName -replace '^Roblox\.Platform\.')
    }
    foreach ($v in $variants) {
        if ($csprojCache.ContainsKey($v)) { return $csprojCache[$v] }
    }
    return $null
}

# Package map and ID overrides
$nugetPackages = @{
    # Common
    "Newtonsoft.Json"      = "13.0.3";
    "StackExchange.Redis"  = "2.6.66";
    "System.Configuration.ConfigurationManager" = "4.7.0";

    # Website-specific external deps (from current csproj)
    "Antlr3.Runtime" = "3.5.0.2";                               # Antlr
    "BCrypt.Net-Next" = "4.0.3";
    "Microsoft.AspNetCore.Cryptography.Internal" = "6.0.3";
    "Microsoft.Bcl.AsyncInterfaces" = "5.0.0";
    "Microsoft.Bcl.HashCode" = "1.1.1";
    "Microsoft.CodeDom.Providers.DotNetCompilerPlatform" = "2.0.1";
    "Microsoft.Data.Sqlite" = "3.1.32";                        # Microsoft.Data.Sqlite.Core
    "Microsoft.DotNet.PlatformAbstractions" = "3.1.6";
    "Microsoft.EntityFrameworkCore" = "3.1.32";
    "Microsoft.EntityFrameworkCore.Abstractions" = "3.1.32";
    "Microsoft.EntityFrameworkCore.Relational" = "3.1.32";
    "Microsoft.EntityFrameworkCore.Sqlite" = "3.1.32";          # Microsoft.EntityFrameworkCore.Sqlite.Core
    "Microsoft.EntityFrameworkCore.SqlServer" = "3.1.32";
    "Microsoft.Extensions.Caching.Abstractions" = "3.1.32";
    "Microsoft.Extensions.Caching.Memory" = "3.1.32";
    "Microsoft.Extensions.Configuration" = "3.1.32";
    "Microsoft.Extensions.Configuration.Abstractions" = "3.1.32";
    "Microsoft.Extensions.Configuration.Binder" = "3.1.32";
    "Microsoft.Extensions.DependencyInjection" = "3.1.32";
    "Microsoft.Extensions.DependencyModel" = "3.1.25";
    "Microsoft.Extensions.Logging" = "3.1.32";
    "Microsoft.Extensions.Logging.Abstractions" = "3.1.32";
    "Microsoft.Extensions.Options" = "3.1.32";
    "Microsoft.Extensions.Primitives" = "3.1.32";
    # Frequently missing abstractions alongside DI
    "Microsoft.Extensions.DependencyInjection.Abstractions" = "3.1.32";
    "Microsoft.Identity.Client" = "3.0.8";
    "Microsoft.IdentityModel.JsonWebTokens" = "5.5.0";
    "Microsoft.IdentityModel.Logging" = "5.5.0";
    "Microsoft.IdentityModel.Protocols" = "5.5.0";
    "Microsoft.IdentityModel.Protocols.OpenIdConnect" = "5.5.0";
    "Microsoft.IdentityModel.Tokens" = "5.5.0";
    "Microsoft.Web.Infrastructure" = "1.0.0";
    "MySqlConnector" = "0.69.10";
    "Pomelo.EntityFrameworkCore.MySql" = "3.2.7";
    "Pomelo.JsonObject" = "2.2.1";

    # System.* packages that were previously pulled via ad-hoc DLLs
    "System.Buffers" = "4.5.1";
    "System.Collections.Immutable" = "1.7.1";
    "System.ComponentModel.Annotations" = "4.7.0";
    "System.Data.Common" = "4.3.0";
    "System.Diagnostics.DiagnosticSource" = "4.7.1";
    "System.Memory" = "4.5.4";
    "System.Numerics.Vectors" = "4.5.0";
    "System.Runtime.CompilerServices.Unsafe" = "5.0.0";
    "System.Runtime.InteropServices.RuntimeInformation" = "4.3.0";
    "System.Text.Encodings.Web" = "5.0.1";
    "System.Text.Json" = "5.0.2";
    "System.Threading.Tasks.Extensions" = "4.5.4";
    "System.ValueTuple" = "4.5.0";

    # ASP.NET optimization stack
    "System.Web.Optimization" = "1.1.3";
    "WebGrease" = "1.6.0";

    # JWT (to unify against stray copies from other bins)
    "System.IdentityModel.Tokens.Jwt" = "5.5.0";

    # ASP.NET MVC/WebPages stack (align to 5.2.9 to match upstream deps)
    "System.Web.Mvc" = "5.2.9";
    "System.Web.WebPages" = "3.2.9";
    "System.Web.WebPages.Razor" = "3.2.9";
    "System.Web.Razor" = "3.2.9";
}

$nugetPackageIdOverride = @{
    "Antlr3.Runtime" = "Antlr";
    "Microsoft.Data.Sqlite" = "Microsoft.Data.Sqlite.Core";
    "Microsoft.EntityFrameworkCore.Sqlite" = "Microsoft.EntityFrameworkCore.Sqlite.Core";
    # Packages where assembly name != package ID
    "System.Web.Optimization" = "Microsoft.AspNet.Web.Optimization";
    "System.Web.Mvc" = "Microsoft.AspNet.Mvc";
    "System.Web.WebPages" = "Microsoft.AspNet.WebPages";
    "System.Web.WebPages.Razor" = "Microsoft.AspNet.WebPages";
    "System.Web.Razor" = "Microsoft.AspNet.Razor";
}

# Legacy/misnamed assembly identifiers to project assembly names
$assemblyAliasMap = @{
    "Roblox.Platform.MembershipCore" = "Roblox.Platform.Membership.Core";
    "Thumbnails.RequestValidation" = "Roblox.PlatformThumbnails.RequestValidation";
}

# Helpers
function Add-PackageReference([xml]$xml,[string]$include,[string]$version){
    $pkgRef = CreateElem $xml 'PackageReference'
    $pkgRef.SetAttribute('Include',$include)
    $pkgRef.SetAttribute('Version',$version)
    return $pkgRef
}

function Add-ProjectReference([xml]$xml,[string]$fromDir,[string]$targetCsproj){
    $fromUri = New-Object System.Uri("file:///$($fromDir.Replace('\\','/'))/")
    $toUri   = New-Object System.Uri("file:///$($targetCsproj.Replace('\\','/'))")
    $relUri  = $fromUri.MakeRelativeUri($toUri)
    $relPath = [System.Uri]::UnescapeDataString($relUri.ToString()).Replace('/', '\\')
    $projRef = CreateElem $xml 'ProjectReference'
    $projRef.SetAttribute('Include',$relPath)
    try {
        [xml]$srcXml = Get-Content $targetCsproj
        $guidNode = $srcXml.Project.PropertyGroup.ProjectGuid
        if($guidNode){
            $guidElem = CreateElem $xml 'Project'
            $guidElem.InnerText = $guidNode.'#text'
            $projRef.AppendChild($guidElem) | Out-Null
        }
    } catch {}
    return $projRef
}

# Load target Website csproj
try {
    $xmlText = Get-Content $CsprojPath -Raw -ErrorAction Stop
    [xml]$xml = $xmlText
} catch {
    Write-Error "Failed to load csproj XML: $($_.Exception.Message)"; exit 1
}
$projDir = Split-Path -Path $CsprojPath -Parent
$changed = $false
Write-Host "Loaded csproj. Beginning reference normalization..."
Write-Host ("Root element: '{0}', namespace: '{1}'" -f $xml.DocumentElement.Name, $xml.DocumentElement.NamespaceURI)
Write-Host ("Child ItemGroup count: {0}" -f ($xml.DocumentElement.SelectNodes("*[local-name()='ItemGroup']").Count))
Write-Host ("Raw <Reference> tags (regex scan): {0}" -f ([regex]::Matches($xmlText, '<Reference\s').Count))

# MSBuild 2003 XML namespace support
$msbuildNs = $xml.DocumentElement.NamespaceURI
$hasNs = -not [string]::IsNullOrWhiteSpace($msbuildNs)
$nsMgr = New-Object System.Xml.XmlNamespaceManager($xml.NameTable)
if ($hasNs) { $nsMgr.AddNamespace('msb', $msbuildNs) }
function SelectNodesNs([xml]$doc,[string]$xpath){
    if ($hasNs) { return $doc.SelectNodes($xpath, $nsMgr) } else { return $doc.SelectNodes($xpath) }
}
function CreateElem([xml]$doc,[string]$name){
    if ($hasNs) { return $doc.CreateElement($name, $msbuildNs) } else { return $doc.CreateElement($name) }
}

# Process <Reference> nodes (namespace-agnostic)
$referenceNodes = $xml.DocumentElement.SelectNodes(".//*[local-name()='Reference']")
Write-Host "Found $($referenceNodes.Count) <Reference> nodes"
foreach ($refNode in $referenceNodes) {
    $includeVal = $refNode.Include
    if (-not $includeVal) { continue }
    $assemblyName = ($includeVal -split ',')[0]

    # Skip core framework unless we explicitly map to NuGet
    if ($assemblyName -match '^(System|Microsoft)\.' -and -not $nugetPackages.ContainsKey($assemblyName)) { continue }

    # Prefer ProjectReference if project exists in repo
    $projPathAbs = Find-Csproj $assemblyName
    if ($projPathAbs) {
        $parent = $refNode.ParentNode
        $projRef = Add-ProjectReference $xml $projDir $projPathAbs
        $parent.AppendChild($projRef) | Out-Null
        $parent.RemoveChild($refNode) | Out-Null
        $changed = $true
        Write-Host "Reference -> ProjectReference: $assemblyName"
        continue
    }

    # Fallback to NuGet package mapping
    if ($nugetPackages.ContainsKey($assemblyName)) {
        $pkgId = if ($nugetPackageIdOverride.ContainsKey($assemblyName)) { $nugetPackageIdOverride[$assemblyName] } else { $assemblyName }
        $pkgRef = Add-PackageReference $xml $pkgId $nugetPackages[$assemblyName]
        $parent = $refNode.ParentNode
        $parent.AppendChild($pkgRef) | Out-Null
        $parent.RemoveChild($refNode) | Out-Null
        $changed = $true
        Write-Host "Reference -> PackageReference: $assemblyName ($pkgId) v$($nugetPackages[$assemblyName])"
        continue
    }
}

# Process <HintPath> nodes that remain (e.g., for framework refs or unusual libs) (namespace-agnostic)
$hintNodes = $xml.DocumentElement.SelectNodes(".//*[local-name()='HintPath']")
Write-Host "Found $($hintNodes.Count) <HintPath> nodes"
foreach ($hint in $hintNodes) {
    $hintPath = [string]$hint.InnerText
    $parentRef = $hint.ParentNode
    $assemblyName = $parentRef.Attributes['Include'].Value

    # If we can convert to ProjectReference now, do it and drop the <Reference>
    $projPathAbs = Find-Csproj $assemblyName
    if ($projPathAbs) {
        $parentItemGroup = $parentRef.ParentNode
        $projRef = Add-ProjectReference $xml $projDir $projPathAbs
        $parentItemGroup.AppendChild($projRef) | Out-Null
        $parentItemGroup.RemoveChild($parentRef) | Out-Null
        $changed = $true
        Write-Host "HintPath -> ProjectReference: $assemblyName"
        continue
    }

    # If we can convert to PackageReference, do it
    if ($nugetPackages.ContainsKey($assemblyName)) {
        $pkgId = if ($nugetPackageIdOverride.ContainsKey($assemblyName)) { $nugetPackageIdOverride[$assemblyName] } else { $assemblyName }
        $pkgRef = Add-PackageReference $xml $pkgId $nugetPackages[$assemblyName]
        $parentItemGroup = $parentRef.ParentNode
        $parentItemGroup.AppendChild($pkgRef) | Out-Null
        $parentItemGroup.RemoveChild($parentRef) | Out-Null
        $changed = $true
        Write-Host "HintPath -> PackageReference: $assemblyName ($pkgId) v$($nugetPackages[$assemblyName])"
        continue
    }

    # Repair legacy '\full\' HintPath or missing file by searching DLL in repo bins
    if ($hintPath -match '(?i)\\full\\' -or -not (Test-Path (Join-Path $projDir $hintPath))) {
        $fileName = Split-Path $hintPath -Leaf
        if ($dllCache.ContainsKey($fileName)) {
            $to = $dllCache[$fileName]
            $fromUri = New-Object System.Uri("file:///$($projDir.Replace('\\','/'))/")
            $toUri = New-Object System.Uri("file:///$($to.Replace('\\','/'))")
            $relativeUri = $fromUri.MakeRelativeUri($toUri)
            $newRelative = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\\')
            $hint.InnerText = $newRelative
            $changed = $true
            Write-Host "HintPath -> Relocated: $assemblyName to $newRelative"
        }
    }
}

if ($changed) {
    Write-Host "Changes detected. Saving..."
    if (-not $Force) {
        $confirm = Read-Host "Apply changes to Website csproj? (Y/N)"
        if ($confirm -notmatch '^(?i)y(es)?$') { Write-Host 'Aborted by user.'; exit 0 }
    }
    $xml.Save($CsprojPath)
    Write-Host "Updated $CsprojPath"
} else {
    Write-Host "No changes needed for $CsprojPath"
}

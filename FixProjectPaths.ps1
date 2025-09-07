param(
    [string]$RootPath = (Get-Location).Path,
    [string]$ReportPath = "$(Get-Location)/missing.txt",
    [switch]$Force
)

Write-Host "Root path: $RootPath"

# Cache all DLL files in the repository for faster lookup
Write-Host "Caching DLL files for faster lookup..."
$dllCache = @{}
Get-ChildItem -Path (Split-Path -Path $RootPath -Parent) -Recurse -Filter *.dll -ErrorAction SilentlyContinue | ForEach-Object {
    $dllCache[$_.Name] = $_.FullName
}
Write-Host "Cached $($dllCache.Count) DLL files."

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
        if ($csprojCache.ContainsKey($v)) { $csprojCache[$asmName] = $csprojCache[$v]; $csprojCache[$originalName] = $csprojCache[$v]; return $csprojCache[$v] }
    }
    $searchNames = @($asmName) + $variants
    foreach ($n in $searchNames) {
        $match = Get-ChildItem -Path $RootPath -Recurse -Filter "$n.csproj" -ErrorAction SilentlyContinue | Select-Object -First 1
        if ($match) { $csprojCache[$asmName] = $match.FullName; $csprojCache[$originalName] = $match.FullName; return $match.FullName }
    }
    return $null
}

# NuGet package map (assembly -> version)
$nugetPackages = @{
    # Common
    "Newtonsoft.Json"      = "13.0.3";
    "StackExchange.Redis"  = "2.6.66";
    "AWSSDK.Core"          = "3.7.102";
    "AWSSDK.DynamoDBv2"    = "3.7.102";
    "DnsClient"            = "1.7.0";
    "System.Configuration.ConfigurationManager" = "4.7.0";
    "Microsoft.Extensions.DependencyInjection.Abstractions" = "2.1.1";
    "System.Data.SqlClient" = "4.8.5";
    "System.Net.Http" = "4.3.4";
    # Assembly name Prometheus.NetStandard comes from package prometheus-net
    "Prometheus.NetStandard" = "4.2.0";

    # Website-specific external deps to convert to PackageReference
    "Antlr3.Runtime" = "3.5.0.2";                               # Antlr
    "BCrypt.Net-Next" = "4.0.3";                               # BCrypt.Net-Next
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
}

# Map assembly name -> NuGet package ID when it differs
$nugetPackageIdOverride = @{
    "Prometheus.NetStandard" = "prometheus-net";
    "Antlr3.Runtime" = "Antlr";
    "Microsoft.Data.Sqlite" = "Microsoft.Data.Sqlite.Core";
    "Microsoft.EntityFrameworkCore.Sqlite" = "Microsoft.EntityFrameworkCore.Sqlite.Core";
}

# Map legacy/misnamed assembly identifiers to the actual project assembly names
$assemblyAliasMap = @{
    # Convert old binary name to the SDK-style project
    "Roblox.Platform.MembershipCore" = "Roblox.Platform.Membership.Core"
    # Known DLL name used historically that maps to this project
    "Thumbnails.RequestValidation" = "Roblox.PlatformThumbnails.RequestValidation"
}

function Add-PackageReference([xml]$xml,[string]$include,[string]$version){
    $pkgRef = $xml.CreateElement('PackageReference')
    $pkgRef.SetAttribute('Include',$include)
    $pkgRef.SetAttribute('Version',$version)
    return $pkgRef
}

function Add-ProjectReference([xml]$xml,[string]$fromDir,[string]$targetCsproj,[string]$assemblyName){
    $fromUri = New-Object System.Uri("file:///$($fromDir.Replace('\','/'))/")
    $toUri   = New-Object System.Uri("file:///$($targetCsproj.Replace('\\','/'))")
    $relUri  = $fromUri.MakeRelativeUri($toUri)
    $relPath = [System.Uri]::UnescapeDataString($relUri.ToString()).Replace('/', '\\')
    $projRef = $xml.CreateElement('ProjectReference')
    $projRef.SetAttribute('Include',$relPath)
    try {
        [xml]$srcXml = Get-Content $targetCsproj
        $guidNode = $srcXml.Project.PropertyGroup.ProjectGuid
        if($guidNode){
            $guidElem = $xml.CreateElement('Project');
            $guidElem.InnerText = $guidNode.'#text'
            $projRef.AppendChild($guidElem) | Out-Null
        }
    } catch {}
    return ,@($projRef,$relPath)
}


# Cache all csproj files by their assembly name for quick lookup
Write-Host "Caching csproj assembly names..."
$csprojCache = @{}
# Build a concrete list first so we can compare counts later
$csprojFilesForCache = Get-ChildItem -Path $RootPath -Recurse -Filter *.csproj -ErrorAction SilentlyContinue
Write-Host "Discovered $($csprojFilesForCache.Count) .csproj files for caching."
$csprojFilesForCache | ForEach-Object {
    $path = $_.FullName
    $fileKey = [IO.Path]::GetFileNameWithoutExtension($_.Name)
    if (-not $csprojCache.ContainsKey($fileKey)) { $csprojCache[$fileKey] = $path }
    try {
        [xml]$tmpXml = Get-Content $path
        $asmNode = $tmpXml.Project.PropertyGroup.AssemblyName
        if ($asmNode) {
            $asm = $asmNode.'#text'
            if ($asm -and -not $csprojCache.ContainsKey($asm)) { $csprojCache[$asm] = $path }
        }
    } catch {
        # ignore parse issues; filename key already cached
    }
}
Write-Host "Cached $($csprojCache.Count) assemblies from csproj."

Write-Host "Searching for .csproj files..."
$csprojFiles = Get-ChildItem -Path $RootPath -Recurse -Filter *.csproj -ErrorAction SilentlyContinue
if ($csprojCache.Count -lt 10 -and $csprojFiles.Count -ge 10) {
    Write-Warning "csproj cache unexpectedly low ($($csprojCache.Count)). Falling back to recaching from discovered list..."
    $csprojCache = @{}
    foreach ($f in $csprojFiles) {
        $path = $f.FullName
        $fileKey = [IO.Path]::GetFileNameWithoutExtension($f.Name)
        if (-not $csprojCache.ContainsKey($fileKey)) { $csprojCache[$fileKey] = $path }
        try {
            [xml]$tmpXml2 = Get-Content $path
            $asmNode2 = $tmpXml2.Project.PropertyGroup.AssemblyName
            if ($asmNode2) {
                $asm2 = $asmNode2.'#text'
                if ($asm2 -and -not $csprojCache.ContainsKey($asm2)) { $csprojCache[$asm2] = $path }
            }
        } catch {}
    }
    Write-Host "Rebuilt csproj cache: $($csprojCache.Count) entries."
}
Write-Host "Found $($csprojFiles.Count) .csproj files."
$unresolved = @()
$changes = @()
$planByProject = @{}

$projectCount = 0
foreach ($proj in $csprojFiles) {
    $projectCount++
    Write-Host "Processing $($projectCount)/$($csprojFiles.Count): $($proj.Name)..."
    [xml]$xml = Get-Content $proj.FullName
    $changed = $false

    # Fix <ProjectReference>
    $projRefs = $xml.Project.ItemGroup.ProjectReference
    if (-not $planByProject.ContainsKey($proj.FullName)) { $planByProject[$proj.FullName] = @() }
    foreach ($ref in $projRefs) {
        # Guard against malformed ProjectReference nodes (missing Include attr or non-element nodes)
        if (-not $ref -or -not $ref.Include -or [string]::IsNullOrWhiteSpace([string]$ref.Include)) { continue }
        $include = [string]$ref.Include
        $fileName = Split-Path $include -Leaf
        $absPath = Join-Path -Path $proj.DirectoryName -ChildPath $include

        if (Test-Path $absPath) {
            # Normalize slashes and recompute canonical relative path to the actual file location
            $from = $proj.DirectoryName
            $to = (Resolve-Path $absPath).Path
            $fromUri = New-Object System.Uri("file:///$($from.Replace('\\','/'))/")
            $toUri = New-Object System.Uri("file:///$($to.Replace('\\','/'))")
            $relativeUri = $fromUri.MakeRelativeUri($toUri)
            $normalized = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\\')
            if ($ref.Include -ne $normalized) {
                $ref.Include = $normalized
                $changed = $true
                $planByProject[$proj.FullName] += "ProjectReference: normalize Include for $fileName -> $normalized"
            }
            continue
        }

        # Target not found: try to resolve by assembly/project name using cache/aliases
        $targetName = [IO.Path]::GetFileNameWithoutExtension($include)
        $resolvedProjPath = Find-Csproj $targetName
        if ($resolvedProjPath) {
            $from = $proj.DirectoryName
            $to = $resolvedProjPath
            $fromUri = New-Object System.Uri("file:///$($from.Replace('\\','/'))/")
            $toUri = New-Object System.Uri("file:///$($to.Replace('\\','/'))")
            $relativeUri = $fromUri.MakeRelativeUri($toUri)
            $newRelative = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\\')
            $ref.Include = $newRelative
            $changed = $true
            $planByProject[$proj.FullName] += "ProjectReference: remap $targetName via cache -> $newRelative"
            continue
        }

        # Fallback: search for the same file name within repo and fix
        $matches = Get-ChildItem -Path $RootPath -Recurse -Filter $fileName -ErrorAction SilentlyContinue | Where-Object { $_.Name -eq $fileName }
        if ($matches.Count -eq 1) {
            $from = $proj.DirectoryName
            $to = $matches[0].FullName
            $fromUri = New-Object System.Uri("file:///$($from.Replace('\\','/'))/")
            $toUri = New-Object System.Uri("file:///$($to.Replace('\\','/'))")
            $relativeUri = $fromUri.MakeRelativeUri($toUri)
            $newRelative = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\\')
            $ref.Include = $newRelative
            $changed = $true
            $planByProject[$proj.FullName] += "ProjectReference: update Include for $fileName -> $newRelative"
        }
        elseif ($matches.Count -gt 1) {
            # Prefer a match under Assemblies directory
            $preferred = $matches | Where-Object { $_.FullName -like "*$($RootPath)\*" } | Select-Object -First 1
            if ($preferred) {
                $from = $proj.DirectoryName
                $to = $preferred.FullName
                $fromUri = New-Object System.Uri("file:///$($from.Replace('\\','/'))/")
                $toUri = New-Object System.Uri("file:///$($to.Replace('\\','/'))")
                $relativeUri = $fromUri.MakeRelativeUri($toUri)
                $newRelative = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\\')
                $ref.Include = $newRelative
                $changed = $true
                $planByProject[$proj.FullName] += "ProjectReference: disambiguated and updated Include for $fileName -> $newRelative"
            } else {
                $unresolved += "ProjectReference in $($proj.FullName): $include"
            }
        }
        else {
            $unresolved += "ProjectReference in $($proj.FullName): $include"
        }
    }

    # Convert DLL <Reference> elements
    # 1) to ProjectReference if source exists
    # 2) to PackageReference if NuGet package known
    # otherwise keep previous behaviour
    $referenceNodes = $xml.SelectNodes("//Reference")
    foreach ($refNode in $referenceNodes) {
        $includeVal = $refNode.Include
        if (-not $includeVal) { continue }
        $assemblyName = ($includeVal -split ',')[0]
        # skip standard framework references
        if ($assemblyName -match '^(System|Microsoft)') { continue }
        # Try existing csproj cache; if not present attempt to find in Assemblies folder
        if (-not $csprojCache.ContainsKey($assemblyName)) {
            $assemblyProj = Get-ChildItem -Path (Join-Path $RootPath 'Assemblies') -Recurse -Filter "$assemblyName.csproj" -ErrorAction SilentlyContinue | Select-Object -First 1
            if ($assemblyProj) { $csprojCache[$assemblyName] = $assemblyProj.FullName }
        }

        if ($nugetPackages.ContainsKey($assemblyName)) {
            $pkgId = if ($nugetPackageIdOverride.ContainsKey($assemblyName)) { $nugetPackageIdOverride[$assemblyName] } else { $assemblyName }
            $pkgRef = Add-PackageReference $xml $pkgId $nugetPackages[$assemblyName]
            $parent = $refNode.ParentNode
            $parent.AppendChild($pkgRef) | Out-Null
            $parent.RemoveChild($refNode) | Out-Null
            $changed = $true
            $planByProject[$proj.FullName] += "Reference: convert $assemblyName to PackageReference v$($nugetPackages[$assemblyName])"
            continue
        }
        elseif ($csprojCache.ContainsKey($assemblyName)) {
            $projPathAbs = $csprojCache[$assemblyName]
            # compute relative path
            $from = $proj.DirectoryName
            $to = $projPathAbs
            $fromUri = New-Object System.Uri("file:///$($from.Replace('\','/'))/")
            $toUri = New-Object System.Uri("file:///$($to.Replace('\\','/'))")
            $relativeUri = $fromUri.MakeRelativeUri($toUri)
            $relativePath = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\\')

            # create new ProjectReference
            $projRef = $xml.CreateElement("ProjectReference")
            $projRef.SetAttribute("Include", $relativePath)
            # copy ProjectGuid if exists
            try {
                [xml]$srcXml = Get-Content $projPathAbs
                $guidNode = $srcXml.Project.PropertyGroup.ProjectGuid
                if ($guidNode) {
                    $guidElem = $xml.CreateElement("Project")
                    $guidElem.InnerText = $guidNode.'#text'
                    $projRef.AppendChild($guidElem) | Out-Null
                }
            } catch {}

            $parent = $refNode.ParentNode
            $parent.AppendChild($projRef) | Out-Null
            $parent.RemoveChild($refNode) | Out-Null
            $changed = $true
            $planByProject[$proj.FullName] += "Reference: convert $assemblyName to ProjectReference ($relativePath)"
        } else {
            $unresolved += "Reference unresolved in $($proj.FullName): $assemblyName"
        }
    }

    # Fix <HintPath>
    $refs = $xml.SelectNodes("//HintPath")
    foreach ($hint in $refs) {
        $hintPath = $hint.InnerText
        # Prefer csproj for any HintPath resolution
        $assemblyName = $hint.ParentNode.Attributes["Include"].Value
        # If this is a framework assembly and not in our NuGet map, drop the stale HintPath
        if ($assemblyName -match '^(System|Microsoft)\.' -and -not $nugetPackages.ContainsKey($assemblyName)) {
            $parentRef = $hint.ParentNode
            $parentRef.RemoveChild($hint) | Out-Null
            $changed = $true
            $planByProject[$proj.FullName] += "HintPath: remove stale HintPath for framework $assemblyName"
            continue
        }
        $projPathAbs = Find-Csproj $assemblyName
        if ($projPathAbs) {
            # convert the parent <Reference> to <ProjectReference>
            $parentRef = $hint.ParentNode
            $parentItemGroup = $parentRef.ParentNode
            $prs = Add-ProjectReference $xml $proj.DirectoryName $projPathAbs $assemblyName $planByProject[$proj.FullName]
            $parentItemGroup.AppendChild($prs[0]) | Out-Null
            $planByProject[$proj.FullName] += "HintPath: convert $assemblyName to ProjectReference ($($prs[1]))"
            $parentItemGroup.RemoveChild($parentRef) | Out-Null
            $changed = $true
            continue
        }
        # If no csproj found, attempt NuGet package conversion
        if ($nugetPackages.ContainsKey($assemblyName)) {
            $parentRef = $hint.ParentNode
            $parentItemGroup = $parentRef.ParentNode
            $pkgId = if ($nugetPackageIdOverride.ContainsKey($assemblyName)) { $nugetPackageIdOverride[$assemblyName] } else { $assemblyName }
            $pkgRef = Add-PackageReference $xml $pkgId $nugetPackages[$assemblyName]
            $parentItemGroup.AppendChild($pkgRef) | Out-Null
            $parentItemGroup.RemoveChild($parentRef) | Out-Null
            $changed = $true
            $planByProject[$proj.FullName] += "HintPath: convert $assemblyName to PackageReference v$($nugetPackages[$assemblyName])"
            continue
        }
        # If no csproj found, fallback to DLL search
        # Handle empty HintPath by searching for the DLL
        if ($hintPath -eq $null -or $hintPath.Trim() -eq "") {
            $assemblyName = $hint.ParentNode.Attributes["Include"].Value
            # Search for the project file first
            $projectMatches = Get-ChildItem -Path $RootPath -Recurse -Filter "$assemblyName.csproj" -ErrorAction SilentlyContinue
            if ($projectMatches.Count -eq 1) {
                # Try to find the DLL in the project's bin directory
                $projectDir = $projectMatches[0].DirectoryName
                $dllPath = Join-Path -Path $projectDir -ChildPath "bin\Debug\netstandard2.0\$assemblyName.dll"
                if (-not (Test-Path $dllPath)) {
                    $dllPath = Join-Path -Path $projectDir -ChildPath "bin\Release\netstandard2.0\$assemblyName.dll"
                }
                if (-not (Test-Path $dllPath)) {
                    $dllPath = Join-Path -Path $projectDir -ChildPath "bin\Debug\$assemblyName.dll"
                }
                if (-not (Test-Path $dllPath)) {
                    $dllPath = Join-Path -Path $projectDir -ChildPath "bin\Release\$assemblyName.dll"
                }
                if (Test-Path $dllPath) {
                    # Compute relative path manually
                    $from = $proj.DirectoryName
                    $to = $dllPath
                    $fromUri = New-Object System.Uri("file:///$($from.Replace('\','/'))/")
                    $toUri = New-Object System.Uri("file:///$($to.Replace('\','/'))")
                    $relativeUri = $fromUri.MakeRelativeUri($toUri)
                    $newRelative = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\')
                    $hint.InnerText = $newRelative
                    $changed = $true
                    $planByProject[$proj.FullName] += "HintPath: set for $assemblyName.dll -> $newRelative"
                } else {
                    $unresolved += "Empty HintPath for $assemblyName in $($proj.FullName) - Project found but DLL not built"
                }
            } else {
                $unresolved += "Empty HintPath for $assemblyName in $($proj.FullName) - Project not found"
            }
            continue
        }
        
        # Replace legacy 'full' paths with correct relative paths (match any path containing '\full\')
        if ($hintPath -match "(?i)\\full\\") {
            # Extract filename, handling both ..\..\full\ and D:\full\ patterns
            $fileName = Split-Path $hintPath -Leaf
            # Search specifically for this DLL in Website\bin and other bin directories
            # First, try to find it in Website\bin directly
            # Get the repository root path (parent of Assemblies and Website directories)
            $repoRootPath = Split-Path -Path $RootPath -Parent
            if ((Split-Path -Path $repoRootPath -Leaf) -eq "Assemblies") {
                $repoRootPath = Split-Path -Path $repoRootPath -Parent
            }
            $websiteBinPath = Join-Path -Path $repoRootPath -ChildPath "Website\bin\$fileName"
            if (Test-Path $websiteBinPath) {
                $dllMatches = @([PSCustomObject]@{FullName = $websiteBinPath})
            } else {
                # Use the DLL cache for faster lookup
                if ($dllCache.ContainsKey($fileName)) {
                    $dllMatches = @([PSCustomObject]@{FullName = $dllCache[$fileName]})
                } else {
                    # Fallback to recursive search if not in cache
                    $dllMatches = Get-ChildItem -Path $RootPath -Recurse -Filter $fileName -ErrorAction SilentlyContinue | 
                        Where-Object { 
                            $_.Name -eq $fileName -and 
                            ($_.Extension -eq ".dll" -and ($_.Directory.Name -eq "bin" -or $_.FullName -like "*Website*bin*"))
                        }
                }
            }
            
            if ($dllMatches.Count -eq 1) {
                # Compute relative path manually
                $from = $proj.DirectoryName
                $to = $dllMatches[0].FullName
                $fromUri = New-Object System.Uri("file:///$($from.Replace('\','/'))/")
                $toUri = New-Object System.Uri("file:///$($to.Replace('\','/'))")
                $relativeUri = $fromUri.MakeRelativeUri($toUri)
                $newRelative = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\')
                $hint.InnerText = $newRelative
                $changed = $true
                $planByProject[$proj.FullName] += "HintPath: replace 'full' for $fileName -> $newRelative"
            }
            elseif ($dllMatches.Count -eq 0) {
                $unresolved += "'full' HintPath in $($proj.FullName): $hintPath - DLL not found"
            }
            else {
                # Multiple matches found, try to find the most appropriate one
                $websiteBinMatches = $dllMatches | Where-Object { $_.FullName -like "*Website*bin*" }
                if ($websiteBinMatches.Count -gt 0) {
                    # Use the one in Website\bin
                    $from = $proj.DirectoryName
                    $to = $websiteBinMatches[0].FullName
                    $fromUri = New-Object System.Uri("file:///$($from.Replace('\','/'))/")
                    $toUri = New-Object System.Uri("file:///$($to.Replace('\','/'))")
                    $relativeUri = $fromUri.MakeRelativeUri($toUri)
                    $newRelative = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\')
                    $hint.InnerText = $newRelative
                    $changed = $true
                    $planByProject[$proj.FullName] += "HintPath: replace 'full' for $fileName -> $newRelative"
                } else {
                    $unresolved += "'full' HintPath in $($proj.FullName): $hintPath - Multiple DLL matches found"
                }
            }
            continue
        }
        
        # Handle other missing paths
        $absPath = Join-Path -Path $proj.DirectoryName -ChildPath $hintPath
        if (-not (Test-Path $absPath)) {
            $fileName = Split-Path $hintPath -Leaf
            # Be more specific in our search - look for DLL files in bin directories
            $matches = Get-ChildItem -Path $RootPath -Recurse -Filter $fileName -ErrorAction SilentlyContinue | 
                Where-Object { 
                    $_.Name -eq $fileName -and 
                    ($_.Extension -eq ".dll" -and ($_.Directory.Name -eq "bin" -or $_.FullName -like "*Website*bin*"))
                }
            
            if ($matches.Count -eq 1) {
                # Compute relative path manually
                $from = $proj.DirectoryName
                $to = $matches[0].FullName
                $fromUri = New-Object System.Uri("file:///$($from.Replace('\','/'))/")
                $toUri = New-Object System.Uri("file:///$($to.Replace('\','/'))")
                $relativeUri = $fromUri.MakeRelativeUri($toUri)
                $newRelative = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\')
                $hint.InnerText = $newRelative
                $changed = $true
                $planByProject[$proj.FullName] += "HintPath: update for $fileName -> $newRelative"
            }
            elseif ($matches.Count -eq 0) {
                $unresolved += "HintPath in $($proj.FullName): $hintPath - File not found"
            }
            else {
                # Multiple matches found
                $unresolved += "HintPath in $($proj.FullName): $hintPath - Multiple matches found"
            }
        }
    }

    if ($changed) {
        # store for later save after confirmation
        $changes += [PSCustomObject]@{Path=$proj.FullName; Xml=$xml}
    }
}

# Summary and confirmation
Write-Host "Planned updates: $($changes.Count) project(s) will be modified."
foreach($c in $changes){
    $p = $c.Path
    Write-Host "  - $([IO.Path]::GetFileName($p))"
    if ($planByProject.ContainsKey($p)) {
        foreach($line in $planByProject[$p]){ Write-Host "      * $line" }
    }
}

if (-not $Force) {
    $confirmation = Read-Host "FixProjectPaths will apply these changes. Continue? (Y/N)"
    if ($confirmation -notmatch '^(?i)y(yes)?$') {
        Write-Host "Aborted by user."
        exit 0
    }
}

# save changes
foreach($c in $changes){ $c.Xml.Save($c.Path) }

if ($unresolved.Count -gt 0) {
    if (-not (Test-Path $ReportPath)) {
        New-Item -Path $ReportPath -ItemType File -Force | Out-Null
    }
    $unresolved | Sort-Object | Add-Content -Path $ReportPath -Encoding UTF8
    Write-Host "Missing references appended to $ReportPath"
} else {
    Write-Host "No missing references detected."
}

param(
    [string]$RootPath = (Get-Location).Path,
    [string]$ReportPath = "$(Get-Location)/missing.txt"
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
    if ($csprojCache.ContainsKey($asmName)) { return $csprojCache[$asmName] }
    $variants = @()
    if ($asmName -match '^Roblox\.Platform\.') {
        $variants += ($asmName -replace '^Roblox\.Platform\.', 'Roblox.')
    } elseif ($asmName -match '^Roblox\.') {
        $variants += ($asmName -replace '^Roblox\.', 'Roblox.Platform.')
        $variants += 'Roblox.' + ($asmName -replace '^Roblox\.Platform\.')
    }
    foreach ($v in $variants) {
        if ($csprojCache.ContainsKey($v)) { $csprojCache[$asmName] = $csprojCache[$v]; return $csprojCache[$v] }
    }
    $searchNames = @($asmName) + $variants
    foreach ($n in $searchNames) {
        $match = Get-ChildItem -Path $RootPath -Recurse -Filter "$n.csproj" -ErrorAction SilentlyContinue | Select-Object -First 1
        if ($match) { $csprojCache[$asmName] = $match.FullName; return $match.FullName }
    }
    return $null
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
Get-ChildItem -Path $RootPath -Recurse -Filter *.csproj -ErrorAction SilentlyContinue | ForEach-Object {
    try {
        [xml]$tmpXml = Get-Content $_.FullName
        $asmNode = $tmpXml.Project.PropertyGroup.AssemblyName
        if ($asmNode) {
            $asm = $asmNode.'#text'
        } else {
            $asm = [IO.Path]::GetFileNameWithoutExtension($_.Name)
        }
        if (-not $csprojCache.ContainsKey($asm)) {
            $csprojCache[$asm] = $_.FullName
        }
    } catch {}
}
Write-Host "Cached $($csprojCache.Count) assemblies from csproj."

Write-Host "Searching for .csproj files..."
$csprojFiles = Get-ChildItem -Path $RootPath -Recurse -Filter *.csproj
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
        $include = $ref.Include
        $absPath = Join-Path -Path $proj.DirectoryName -ChildPath $include
        if (-not (Test-Path $absPath)) {
            # search for same file name within repo
            $fileName = Split-Path $include -Leaf
            $matches = Get-ChildItem -Path $RootPath -Recurse -Filter $fileName -ErrorAction SilentlyContinue
            if ($matches.Count -eq 1) {
                # Compute the relative path from the project file to the found DLL
                $from = $proj.DirectoryName
                $to = $matches[0].FullName
                $fromUri = New-Object System.Uri("file:///$($from.Replace('\','/'))/")
                $toUri = New-Object System.Uri("file:///$($to.Replace('\','/'))")
                $relativeUri = $fromUri.MakeRelativeUri($toUri)
                $newRelative = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\')
                
                # Update the ProjectReference in the XML
                $ref.Include = $newRelative
                $changed = $true
                $planByProject[$proj.FullName] += "ProjectReference: update Include for $fileName -> $newRelative"
            }
            else {
                $unresolved += "ProjectReference in $($proj.FullName): $include"
            }
        }
    }

    # Convert DLL <Reference> elements to <ProjectReference> when source project exists
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

        if ($csprojCache.ContainsKey($assemblyName)) {
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
        
        # Replace 'full' paths with correct relative paths
        $patternMatch = $hintPath -like "*..\..\full\*"
        
        # Also check for other 'full' path patterns
        if (-not $patternMatch) {
            $patternMatch = $hintPath -like "*D:\full\*"
        }
        
        if ($patternMatch) {
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

$confirmation = Read-Host "FixProjectPaths will apply these changes. Continue? (Y/N)"
if ($confirmation -notmatch '^(?i)y(yes)?$') {
    Write-Host "Aborted by user."
    exit 0
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

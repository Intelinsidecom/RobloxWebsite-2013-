param(
    [string]$RootPath = (Get-Location).Path,
    [string]$ReportPath = "$(Get-Location)/UnresolvedReferences.txt"
)

Write-Host "Root path: $RootPath"

# Cache all DLL files in the repository for faster lookup
Write-Host "Caching DLL files for faster lookup..."
$dllCache = @{}
Get-ChildItem -Path (Split-Path -Path $RootPath -Parent) -Recurse -Filter *.dll -ErrorAction SilentlyContinue | ForEach-Object {
    $dllCache[$_.Name] = $_.FullName
}
Write-Host "Cached $($dllCache.Count) DLL files."

Write-Host "Searching for .csproj files..."
$csprojFiles = Get-ChildItem -Path $RootPath -Recurse -Filter *.csproj
Write-Host "Found $($csprojFiles.Count) .csproj files."
$unresolved = @()

$projectCount = 0
foreach ($proj in $csprojFiles) {
    $projectCount++
    Write-Host "Processing $($projectCount)/$($csprojFiles.Count): $($proj.Name)..."
    [xml]$xml = Get-Content $proj.FullName
    $changed = $false

    # Fix <ProjectReference>
    $projRefs = $xml.Project.ItemGroup.ProjectReference
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
                Write-Host "Fixed ProjectReference in $($proj.Name): $fileName"
            }
            else {
                $unresolved += "ProjectReference in $($proj.FullName): $include"
            }
        }
    }

    # Fix <HintPath>
    $refs = $xml.SelectNodes("//HintPath")
    foreach ($hint in $refs) {
        $hintPath = $hint.InnerText
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
                    Write-Host "Fixed empty HintPath in $($proj.Name): $assemblyName.dll"
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
            
            Write-Host "DEBUG: Processing matches for $fileName, count: $($dllMatches.Count)"
            if ($dllMatches.Count -eq 1) {
                # Compute relative path manually
                $from = $proj.DirectoryName
                $to = $dllMatches[0].FullName
                Write-Host "DEBUG: Using match: $($dllMatches[0].FullName)"
                $fromUri = New-Object System.Uri("file:///$($from.Replace('\','/'))/")
                $toUri = New-Object System.Uri("file:///$($to.Replace('\','/'))")
                $relativeUri = $fromUri.MakeRelativeUri($toUri)
                $newRelative = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\')
                $hint.InnerText = $newRelative
                $changed = $true
                Write-Host "Fixed 'full' HintPath in $($proj.Name): $fileName"
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
                    Write-Host "Fixed 'full' HintPath in $($proj.Name): $fileName"
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
                Write-Host "Fixed HintPath in $($proj.Name): $fileName"
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
        $xml.Save($proj.FullName)
    }
}

if ($unresolved.Count -gt 0) {
    $unresolved | Sort-Object | Set-Content -Path $ReportPath -Encoding UTF8
    Write-Host "Unresolved references written to $ReportPath"
} else {
    # Clear the report file if there are no unresolved references
    Set-Content -Path $ReportPath -Value @() -Encoding UTF8
    Write-Host "All references resolved. Report file cleared."
}

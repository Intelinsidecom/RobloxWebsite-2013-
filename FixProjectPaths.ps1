param(
    [string]$RootPath = (Get-Location).Path,
    [string]$ReportPath = "$(Get-Location)/UnresolvedReferences.txt"
)

Write-Host "Root path: $RootPath"

Write-Host "Searching for .csproj files..."
$csprojFiles = Get-ChildItem -Path $RootPath -Recurse -Filter *.csproj
Write-Host "Found $($csprojFiles.Count) .csproj files."
$unresolved = @()

foreach ($proj in $csprojFiles) {
    Write-Host "Processing $($proj.FullName)..."
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
        if ($hintPath -like "*..\\..\\full\\*") {
            $fileName = Split-Path $hintPath -Leaf
            # Search for the project file first
            $projectMatches = Get-ChildItem -Path $RootPath -Recurse -Filter "$fileName" -ErrorAction SilentlyContinue | Where-Object { $_.Name -eq "$fileName" }
            if ($projectMatches.Count -eq 0) {
                # If no project file, search for DLL in bin directories
                $dllMatches = Get-ChildItem -Path $RootPath -Recurse -Filter $fileName -ErrorAction SilentlyContinue | Where-Object { $_.Directory.Name -eq "bin" }
                $projectMatches = $dllMatches
            }
            if ($projectMatches.Count -eq 1) {
                # Compute relative path manually
                $from = $proj.DirectoryName
                $to = $projectMatches[0].FullName
                $fromUri = New-Object System.Uri("file:///$($from.Replace('\','/'))/")
                $toUri = New-Object System.Uri("file:///$($to.Replace('\','/'))")
                $relativeUri = $fromUri.MakeRelativeUri($toUri)
                $newRelative = [System.Uri]::UnescapeDataString($relativeUri.ToString()).Replace('/', '\')
                $hint.InnerText = $newRelative
                $changed = $true
                Write-Host "Fixed 'full' HintPath in $($proj.Name): $fileName"
            }
            else {
                $unresolved += "'full' HintPath in $($proj.FullName): $hintPath"
            }
            continue
        }
        
        # Handle other missing paths
        $absPath = Join-Path -Path $proj.DirectoryName -ChildPath $hintPath
        if (-not (Test-Path $absPath)) {
            $fileName = Split-Path $hintPath -Leaf
            $matches = Get-ChildItem -Path $RootPath -Recurse -Filter $fileName -ErrorAction SilentlyContinue
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
            else {
                $unresolved += "HintPath in $($proj.FullName): $hintPath"
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
    Write-Host "All references resolved."
}

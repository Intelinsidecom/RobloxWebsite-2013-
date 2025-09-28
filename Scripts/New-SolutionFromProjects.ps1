param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string]$OutputDirectory,

    [Parameter(Mandatory = $false, Position = 1)]
    [string]$SolutionName = $null
)

function Test-DotNet {
    try {
        $null = & dotnet --version 2>$null
        return $true
    }
    catch { return $false }
}

function Get-ProjectFiles([string]$root) {
    $patterns = @('*.csproj','*.vbproj','*.fsproj')
    $files = Get-ChildItem -Path $root -Recurse -File -ErrorAction SilentlyContinue -Include $patterns
    return $files | Sort-Object FullName
}

function Show-Menu($items, [hashtable]$selected, [string]$filter) {
    Clear-Host
    Write-Host "Select projects to add to the solution" -ForegroundColor Cyan
    Write-Host "Search Directory: $OutputDirectory" -ForegroundColor DarkGray
    Write-Host "Output Directory: $OutputDirectory" -ForegroundColor DarkGray
    if ($filter) { Write-Host "Filter: '$filter'" -ForegroundColor Yellow }
    Write-Host "";

    $display = $items
    if ($filter) {
        $display = $display | Where-Object { $_.FullName -like "*$filter*" }
    }

    if (-not $display) {
        Write-Host "No projects found (or filter excludes all)." -ForegroundColor Yellow
    }
    else {
        $i = 1
        foreach ($f in $display) {
            $isSelected = $selected.ContainsKey($f.FullName)
            $mark = if ($isSelected) { '[X]' } else { '[ ]' }
            $rel = Resolve-Path -LiteralPath $f.FullName | ForEach-Object { $_.Path }
            Write-Host ("{0,3}. {1}  {2}" -f $i, $mark, $rel)
            $i++
        }
    }

    Write-Host "";
    Write-Host "Commands:" -ForegroundColor Cyan
    Write-Host "  Enter numbers (e.g. 1,3,5-8 or 1..8) to toggle selection"
    Write-Host "  f <text>  - set filter (wildcards not required)"
    Write-Host "  a         - toggle select all visible"
    Write-Host "  n <name>  - set solution name"
    Write-Host "  o         - confirm and create solution"
    Write-Host "  r         - refresh project scan"
    Write-Host "  q         - quit without changes"
}

function Get-RangeIndices([string]$text, [int]$max) {
    # Normalize input: convert unicode dashes to hyphen, allow spaces around separators, support .. as range
    # Unicode dash characters: figure dash \u2012, en dash \u2013, em dash \u2014, horizontal bar \u2015, minus sign \u2212
    $normalized = $text
    $normalized = $normalized -replace "[\u2012\u2013\u2014\u2015\u2212]","-"
    # Normalize double dot to hyphen range as well
    $normalized = $normalized -replace "\s*\.\.\s*","-"
    # Remove spaces around commas and dashes
    $normalized = $normalized -replace "\s*,\s*","," -replace "\s*-\s*","-"

    $indices = @()
    foreach ($part in $normalized.Split(',', [System.StringSplitOptions]::RemoveEmptyEntries)) {
        $p = $part.Trim()
        if ($p -match '^(\d+)-(\d+)$') {
            $start = [int]$matches[1]
            $end   = [int]$matches[2]
            if ($start -gt $end) { $tmp = $start; $start = $end; $end = $tmp }
            for ($i = $start; $i -le $end; $i++) { if ($i -ge 1 -and $i -le $max) { $indices += $i } }
        }
        elseif ($p -match '^(\d+)$') {
            $i = [int]$matches[1]
            if ($i -ge 1 -and $i -le $max) { $indices += $i }
        }
    }
    return ($indices | Select-Object -Unique | Sort-Object)
}

if (-not (Test-Path -LiteralPath $OutputDirectory)) {
    throw "OutputDirectory not found: $OutputDirectory"
}

$projects = Get-ProjectFiles -root $OutputDirectory
$selected = @{}
$filter = ''

if (-not $SolutionName -or [string]::IsNullOrWhiteSpace($SolutionName)) {
    $SolutionName = Split-Path -Path (Resolve-Path -LiteralPath $OutputDirectory) -Leaf
    if (-not $SolutionName) { $SolutionName = "Solution" }
}

while ($true) {
    $visible = if ($filter) { $projects | Where-Object { $_.FullName -like "*$filter*" } } else { $projects }
    Show-Menu -items $projects -selected $selected -filter $filter

    $userInput = Read-Host "Enter command"
    if (-not $userInput) { continue }

    if ($userInput -match '^q$') { Write-Host "Aborted." -ForegroundColor Yellow; exit 1 }
    elseif ($userInput -match '^o$') {
        if ($selected.Count -eq 0) { Write-Host "No projects selected." -ForegroundColor Yellow; Start-Sleep -Milliseconds 900; continue }
        break
    }
    elseif ($userInput -match '^r$') {
        $projects = Get-ProjectFiles -root $OutputDirectory
        continue
    }
    elseif ($userInput -match '^a$') {
        if ($filter) { $visible = $projects | Where-Object { $_.FullName -like "*$filter*" } } else { $visible = $projects }
        $allVisibleSelected = $true
        $i = 1
        foreach ($f in $visible) { if (-not $selected.ContainsKey($f.FullName)) { $allVisibleSelected = $false; break } }
        if ($allVisibleSelected) {
            foreach ($f in $visible) { $selected.Remove($f.FullName) | Out-Null }
        }
        else {
            foreach ($f in $visible) { $selected[$f.FullName] = $true }
        }
        continue
    }
    elseif ($userInput -match '^f\s+(.+)$') {
        $filter = $matches[1].Trim()
        continue
    }
    elseif ($userInput -match '^n\s+(.+)$') {
        $SolutionName = $matches[1].Trim()
        continue
    }
    else {
        $list = if ($filter) { $projects | Where-Object { $_.FullName -like "*$filter*" } } else { $projects }
        $max = @($list).Count
        if ($max -eq 0) { continue }
        $indices = Get-RangeIndices -text $userInput -max $max
        if ($indices.Count -eq 0) { Write-Host "No valid indices parsed from input." -ForegroundColor Yellow; Start-Sleep -Milliseconds 600; continue }
        $i = 1
        $map = @{}
        foreach ($f in $list) { $map[$i] = $f; $i++ }
        foreach ($idx in $indices) {
            $file = $map[$idx]
            if ($null -ne $file) {
                if ($selected.ContainsKey($file.FullName)) { $selected.Remove($file.FullName) | Out-Null }
                else { $selected[$file.FullName] = $true }
            }
        }
        Write-Host ("Toggled {0} item(s). Currently selected: {1}" -f $indices.Count, $selected.Count) -ForegroundColor DarkGray
        Start-Sleep -Milliseconds 400
    }
}

# Ensure dotnet exists
if (-not (Test-DotNet)) {
    throw "dotnet CLI not found. Please install .NET SDK and ensure 'dotnet' is on PATH."
}

# Prepare output folder
$resolvedOut = Resolve-Path -LiteralPath (New-Item -ItemType Directory -Force -Path $OutputDirectory) | Select-Object -ExpandProperty Path

# Decide solution name
if (-not $SolutionName -or [string]::IsNullOrWhiteSpace($SolutionName)) {
    $SolutionName = Split-Path -Path $resolvedOut -Leaf
}

$slnPath = Join-Path $resolvedOut ("{0}.sln" -f $SolutionName)

# Create or reuse solution
if (Test-Path -LiteralPath $slnPath) {
    Write-Host "Using existing solution: $slnPath" -ForegroundColor Yellow
}
else {
    Write-Host "Creating solution: $slnPath" -ForegroundColor Green
    Push-Location $resolvedOut
    try {
        & dotnet new sln -n $SolutionName | Out-Null
    }
    finally { Pop-Location }
}

# Add projects
$added = 0
foreach ($full in $selected.Keys | Sort-Object) {
    Write-Host ("Adding: {0}" -f $full)
    & dotnet sln "$slnPath" add "$full" | Out-Null
    $added++
}

Write-Host ""; Write-Host ("Done. Added {0} project(s) to {1}" -f $added, $slnPath) -ForegroundColor Cyan

# Show a quick summary
Write-Host "Solution: $slnPath"
$selected.Keys | Sort-Object | ForEach-Object { Write-Host ("  - " + $_) } 

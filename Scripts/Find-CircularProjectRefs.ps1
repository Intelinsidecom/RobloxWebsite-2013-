param(
    [string]$SearchRoot
)

# If no root provided, assume this script lives in repo/scripts/, so repo root is one level up
if (-not $SearchRoot -or [string]::IsNullOrWhiteSpace($SearchRoot)) {
    $SearchRoot = Resolve-Path -LiteralPath (Join-Path $PSScriptRoot "..")
}

Write-Host "Scanning for circular ProjectReference dependencies under: $SearchRoot" -ForegroundColor Cyan

# Find all csproj files
$csprojFiles = Get-ChildItem -LiteralPath $SearchRoot -Recurse -Filter *.csproj -File -ErrorAction SilentlyContinue
if (-not $csprojFiles) {
    Write-Warning "No .csproj files found under $SearchRoot"
    return
}

# Build adjacency list: projectPath -> list of referenced project paths
$graph = @{}
$projectNames = @{}

function Normalize-Path([string]$path) {
    if (-not $path) { return $null }
    try {
        return (Resolve-Path -LiteralPath $path -ErrorAction Stop).Path
    } catch {
        return [System.IO.Path]::GetFullPath($path)
    }
}

foreach ($file in $csprojFiles) {
    $projPath = (Resolve-Path -LiteralPath $file.FullName).Path
    $projectNames[$projPath] = [System.IO.Path]::GetFileNameWithoutExtension($projPath)
    $graph[$projPath] = New-Object System.Collections.Generic.List[string]

    try {
        [xml]$xml = Get-Content -LiteralPath $projPath -Raw -ErrorAction Stop
    } catch {
        Write-Warning "Failed to parse XML: $projPath. $_"
        continue
    }

    $projDir = Split-Path -Parent $projPath
    $refs = @()
    $xml.Project.ItemGroup | ForEach-Object {
        $_.ProjectReference | ForEach-Object {
            if ($_) {
                $inc = $_.Include
                if ($inc) {
                    $abs = Normalize-Path (Join-Path $projDir $inc)
                    $refs += $abs
                }
            }
        }
    }

    foreach ($r in $refs) {
        # Only keep references that point to real csproj files
        if (Test-Path -LiteralPath $r) {
            $graph[$projPath].Add($r)
        } else {
            # Some Include paths might be invalid in this checkout; warn but continue
            Write-Verbose "Missing ProjectReference target: $r (referenced by $projPath)"
        }
    }
}

# Detect cycles using DFS with recursion stack
$visited = New-Object System.Collections.Generic.HashSet[string]
$stack = New-Object System.Collections.Generic.HashSet[string]
$cycles = New-Object System.Collections.Generic.List[System.Collections.Generic.List[string]]

function Find-Cycles([string]$node, [System.Collections.Generic.List[string]]$path) {
    if ($stack.Contains($node)) {
        # Found a back-edge forming a cycle; extract the cycle segment
        $startIndex = $path.IndexOf($node)
        if ($startIndex -ge 0) {
            $cycle = $path.GetRange($startIndex, $path.Count - $startIndex)
            $cycles.Add($cycle)
        }
        return
    }
    if ($visited.Contains($node)) { return }

    $visited.Add($node) | Out-Null
    $stack.Add($node) | Out-Null
    $path.Add($node)

    if ($graph.ContainsKey($node)) {
        foreach ($nbr in $graph[$node]) {
            Find-Cycles -node $nbr -path $path
        }
    }

    $null = $path.Remove($node)
    $stack.Remove($node) | Out-Null
}

foreach ($proj in $graph.Keys) {
    if (-not $visited.Contains($proj)) {
        Find-Cycles -node $proj -path (New-Object System.Collections.Generic.List[string])
    }
}

# De-duplicate cycles (same set/rotation)
function Normalize-Cycle($cycle) {
    # Represent cycle as minimal rotation of names joined by ' -> '
    $names = $cycle | ForEach-Object { $projectNames[$_] }
    $n = $names.Count
    if ($n -eq 0) { return "" }
    $rotations = for ($i=0; $i -lt $n; $i++) { ($names[$i..($n-1)] + $names[0..($i-1)]) -join ' -> ' }
    return ($rotations | Sort-Object)[0]
}

$unique = New-Object System.Collections.Generic.HashSet[string]
$normalized = @()
foreach ($c in $cycles) {
    # Ensure last -> first closes the loop in display
    if ($c.Count -gt 0 -and $c[0] -ne $c[-1]) { $c.Add($c[0]) }
    $key = Normalize-Cycle $c
    if ($key -and -not $unique.Contains($key)) {
        $unique.Add($key) | Out-Null
        $normalized += ,@($c)
    }
}

if ($normalized.Count -eq 0) {
    Write-Host "No circular ProjectReference dependencies detected." -ForegroundColor Green
    exit 0
}

Write-Host "Found circular ProjectReference dependencies:" -ForegroundColor Yellow
$idx = 1
foreach ($c in $normalized) {
    $display = ($c | ForEach-Object { $projectNames[$_] }) -join " -> "
    Write-Host ("  [{0}] {1}" -f $idx, $display) -ForegroundColor Red
    # Also print full paths under the friendly line for clarity
    $full = ("      " + ($c -join " -> "))
    Write-Host $full -ForegroundColor DarkGray
    $idx++
}

# Do not close host automatically; leave to caller (e.g., cmd launcher uses 'pause')
exit 2

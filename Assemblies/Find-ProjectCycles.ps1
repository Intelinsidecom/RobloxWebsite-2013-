param(
    [string]$Root = $(Get-Location).Path,
    [switch]$Json
)
$ErrorActionPreference = 'Stop'

function Write-Info($msg){ Write-Host $msg -ForegroundColor Cyan }
function Write-Warn($msg){ Write-Host $msg -ForegroundColor Yellow }
function Write-Err($msg){ Write-Host $msg -ForegroundColor Red }

# Normalize root
try { $Root = (Resolve-Path -LiteralPath $Root).Path } catch { $Root = [System.IO.Path]::GetFullPath($Root) }
if (-not (Test-Path -LiteralPath $Root)) { Write-Err "Root path not found: $Root"; exit 2 }

Write-Info "Scanning for .csproj files under: $Root"
$csprojs = Get-ChildItem -Path $Root -Recurse -Filter *.csproj -ErrorAction Stop
if (-not $csprojs -or $csprojs.Count -eq 0) { Write-Warn "No .csproj files found."; exit 0 }

# Build adjacency list
$adj = @{}
foreach ($p in $csprojs) {
    try { [xml]$x = Get-Content -LiteralPath $p.FullName -ErrorAction Stop } catch { continue }
    $dir = Split-Path -Parent $p.FullName
    $refs = New-Object System.Collections.Generic.List[string]
    $x.Project.ItemGroup | ForEach-Object { $_.ProjectReference } | Where-Object { $_ } | ForEach-Object {
        $inc = $_.Include
        if (-not [string]::IsNullOrWhiteSpace($inc)) {
            $path = Join-Path $dir $inc
            $path = $path -replace '/', '\'
            try { $full = (Resolve-Path -LiteralPath $path -ErrorAction Stop).Path } catch { $full = [System.IO.Path]::GetFullPath($path) }
            if (Test-Path -LiteralPath $full) { $refs.Add($full) }
        }
    }
    $adj[$p.FullName] = $refs
}

# DFS for cycles
$visited = @{}
$onstack = @{}
$stack = New-Object System.Collections.Generic.List[string]
$cycles = New-Object System.Collections.Generic.List[object]

function dfs([string]$node){
    if ($onstack.ContainsKey($node) -and $onstack[$node]) {
        $idx = $stack.IndexOf($node)
        if ($idx -ge 0) {
            $cycle = @()
            for ($i = $idx; $i -lt $stack.Count; $i++) { $cycle += $stack[$i] }
            $cycle += $node
            $cycles.Add([pscustomobject]@{ Nodes = $cycle })
        }
        return
    }
    if ($visited.ContainsKey($node) -and $visited[$node]) { return }
    $visited[$node] = $true
    $onstack[$node] = $true
    [void]$stack.Add($node)
    foreach ($nbr in ($adj[$node])) { dfs $nbr }
    $onstack[$node] = $false
    [void]$stack.RemoveAt($stack.Count - 1)
}

foreach ($k in $adj.Keys) { if (-not ($visited.ContainsKey($k) -and $visited[$k])) { dfs $k } }

if ($cycles.Count -eq 0) {
    Write-Info "No cycles found."
    if ($Json) { Write-Output (@{ cycles = @() } | ConvertTo-Json -Depth 5) }
    exit 0
}

Write-Err ("Found {0} cycle(s):" -f $cycles.Count)
$idx = 1
foreach ($c in $cycles) {
    Write-Err ("Cycle {0}:" -f $idx)
    foreach ($n in $c.Nodes) {
        # Pretty print relative to root
        $rel = $n
        if ($n.StartsWith($Root, [System.StringComparison]::OrdinalIgnoreCase)) {
            $rel = $n.Substring($Root.Length).TrimStart('\\')
        }
        Write-Host ("  " + $rel)
    }
    $idx++
}
if ($Json) { Write-Output (@{ cycles = $cycles } | ConvertTo-Json -Depth 5) }
exit 1

<#!
.SYNOPSIS
  Safely rename a type (class/interface/enum/etc.) across the repository.

.DESCRIPTION
  - Supports dry-run preview and exact identifier matching via word boundaries
  - Limits changes to desired file types; skips bin/obj/.vs by default
  - Optionally creates a git commit and triggers a build validation

.EXAMPLES
  # Preview only
  ./scripts/Rename-Type.ps1 -FromType OldName -ToType NewName -DryRun -WordBoundary

  # Apply, commit, and build
  ./scripts/Rename-Type.ps1 -FromType OldName -ToType NewName -Commit -Build -WordBoundary
#>

[CmdletBinding(PositionalBinding = $false)]
param(
  [Parameter(Mandatory = $true)]
  [string] $FromType,

  [Parameter(Mandatory = $true)]
  [string] $ToType,

  [Parameter(Mandatory = $false)]
  [string[]] $Includes = @('**/*.cs','**/*.csproj','**/*.cshtml','**/*.config','**/*.xml','**/*.json','**/*.sln'),

  [Parameter(Mandatory = $false)]
  [string[]] $Excludes = @('**/bin/**','**/obj/**','**/.vs/**','**/packages/**','**/node_modules/**'),

  [switch] $DryRun,
  [switch] $WordBoundary,
  [switch] $Commit,
  [switch] $Build,

  [Parameter(Mandatory = $false)]
  [ValidateSet('Debug','Release')]
  [string] $Configuration = 'Debug'
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot

function Write-Info($msg)  { Write-Host "[INFO ] $msg" -ForegroundColor Cyan }
function Write-Okay($msg)  { Write-Host "[ OK  ] $msg" -ForegroundColor Green }
function Write-Warn($msg)  { Write-Host "[WARN ] $msg" -ForegroundColor Yellow }
function Write-Err ($msg)  { Write-Host "[FAIL ] $msg" -ForegroundColor Red }

function Test-GitRepo {
  try {
    git -C $repoRoot rev-parse --is-inside-work-tree *> $null
    return $LASTEXITCODE -eq 0
  } catch { return $false }
}

function Get-MatchesInFile([string]$filePath, [System.Text.RegularExpressions.Regex]$regex) {
  try {
    $content = Get-Content -LiteralPath $filePath -Raw -ErrorAction Stop
  } catch {
    Write-Warn "Skipping unreadable file: $filePath ($_ )"
    return $null
  }
  if ($null -eq $content) { $content = '' }
  $matches = $regex.Matches($content)
  if ($matches.Count -gt 0) {
    return [PSCustomObject]@{ Path = $filePath; Count = $matches.Count }
  }
  return $null
}

function Replace-InFile([string]$filePath, [System.Text.RegularExpressions.Regex]$regex, [string]$replacement) {
  try {
    $content = Get-Content -LiteralPath $filePath -Raw -ErrorAction Stop
  } catch {
    Write-Warn "Skipping unreadable file: $filePath ($_ )"
    return $false
  }
  if ($null -eq $content) { return $false }
  $new = $regex.Replace($content, $replacement)
  if ($new -ne $content) {
    Set-Content -LiteralPath $filePath -Value $new -Encoding UTF8
    return $true
  }
  return $false
}

# Build regex
$escaped = [System.Text.RegularExpressions.Regex]::Escape($FromType)
if ($WordBoundary) {
  # \b does word boundaries; overlay for dots if generic/namespace parts are included
  $pattern = "\b${escaped}\b"
} else {
  $pattern = $escaped
}
$regex = [System.Text.RegularExpressions.Regex]::new($pattern)

Write-Info "Root: $repoRoot"
Write-Info "Renaming: '$FromType' -> '$ToType'"
Write-Info "WordBoundary: $WordBoundary  DryRun: $DryRun  Commit: $Commit  Build: $Build"

# Gather all files under repo and filter with include/exclude regex (supports ** globs)
$allFiles = Get-ChildItem -Path $repoRoot -Recurse -File -ErrorAction SilentlyContinue | ForEach-Object { $_.FullName }

function Convert-GlobToRegex([string]$glob) {
  # Normalize to forward slashes, handle ** BEFORE escaping
  $g = ($glob -replace '\\','/')
  $g = $g.Replace('**','__GLOBSTAR__')
  $g = [System.Text.RegularExpressions.Regex]::Escape($g)
  # Restore tokens
  $g = $g.Replace('__GLOBSTAR__','.*')
  $g = $g.Replace('\*','[^/]*').Replace('\?','.')
  return '^' + $g + '$'
}

$includeRegexes = @()
foreach ($inc in $Includes) {
  $rx = Convert-GlobToRegex((Join-Path $repoRoot $inc))
  $includeRegexes += [System.Text.RegularExpressions.Regex]::new($rx, [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)
}

$excludeRegexes = @()
foreach ($ex in $Excludes) {
  $rx = Convert-GlobToRegex((Join-Path $repoRoot $ex))
  $excludeRegexes += [System.Text.RegularExpressions.Regex]::new($rx, [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)
}

$filesToProcess = @()
foreach ($f in $allFiles) {
  # Normalize to forward slashes for matching
  $norm = ($f -replace '\\','/')
  $in = $false
  foreach ($ir in $includeRegexes) { if ($ir.IsMatch($norm)) { $in = $true; break } }
  if (-not $in) { continue }
  $excluded = $false
  foreach ($er in $excludeRegexes) { if ($er.IsMatch($norm)) { $excluded = $true; break } }
  if (-not $excluded) { $filesToProcess += $f }
}

if (-not $filesToProcess -or $filesToProcess.Count -eq 0) {
  Write-Warn "No files matched the given include/exclude filters."
  exit 0
}

# Dry run scan
$hits = @()
foreach ($f in $filesToProcess) {
  $m = Get-MatchesInFile -filePath $f -regex $regex
  if ($m) { $hits += $m }
}

if ($hits.Count -eq 0) {
  Write-Warn "No occurrences of '$FromType' found."
  exit 0
}

Write-Info "Found $($hits.Count) files containing matches:"
$hits | Sort-Object -Property Path | ForEach-Object { Write-Host "  $($_.Path) ($($_.Count))" }

if ($DryRun) {
  Write-Okay "Dry run complete. No changes made."
  exit 0
}

# Apply replacements
$changed = 0
foreach ($f in $filesToProcess) {
  if (Replace-InFile -filePath $f -regex $regex -replacement $ToType) {
    $changed++
    Write-Host "Changed: $f" -ForegroundColor Green
  }
}
Write-Info "Files changed: $changed"

# Optional commit
if ($Commit -and (Test-GitRepo)) {
  git -C $repoRoot add -A
  git -C $repoRoot commit -m "refactor: rename type $FromType -> $ToType"
  if ($LASTEXITCODE -eq 0) { Write-Okay "Git commit created." } else { Write-Warn "Git commit failed." }
} elseif ($Commit) {
  Write-Warn "Not a git repo; skipping commit."
}

# Optional build validation
if ($Build) {
  $buildScript = Join-Path $repoRoot 'scripts/Build.ps1'
  if (Test-Path $buildScript) {
    Write-Info "Running build validation..."
    & $buildScript -Configuration $Configuration -Verbosity minimal
    if ($LASTEXITCODE -ne 0) {
      Write-Err "Build failed after rename."
      exit $LASTEXITCODE
    } else {
      Write-Okay "Build succeeded after rename."
    }
  } else {
    Write-Warn "Build script not found at $buildScript. Skipping build validation."
  }
}

Write-Okay "Rename operation complete."

<#!
.SYNOPSIS
  Flexible build script for this repo.

.DESCRIPTION
  - Auto-detects MSBuild using vswhere or common paths
  - Optionally restores NuGet packages
  - Builds a solution (.sln) or a specific project (.csproj)
  - Supports Clean, Configuration, and Verbosity options

.EXAMPLES
  # Restore and build the website project in Debug
  ./scripts/Build.ps1 -ProjectPath "Website/Roblox.Website.csproj" -Restore -Configuration Debug

  # Build the whole solution in Release with clean
  ./scripts/Build.ps1 -SolutionPath "Assemblies/Roblox.sln" -Configuration Release -Clean

  # Increase msbuild verbosity
  ./scripts/Build.ps1 -ProjectPath "Website/Roblox.Website.csproj" -Verbosity minimal

.NOTES
  You can also keep using build.bat; this script provides a more flexible alternative.
#>

[CmdletBinding(PositionalBinding = $false)]
param(
  [Parameter(Mandatory = $false)]
  [string] $SolutionPath,

  [Parameter(Mandatory = $false)]
  [string] $ProjectPath = "Website/Roblox.Website.csproj",

  [Parameter(Mandatory = $false)]
  [ValidateSet('Debug','Release')]
  [string] $Configuration = 'Debug',

  [Parameter(Mandatory = $false)]
  [ValidateSet('quiet','minimal','normal','detailed','diagnostic')]
  [string] $Verbosity = 'minimal',

  [switch] $Restore,
  [switch] $Clean,

  [Parameter(Mandatory = $false)]
  [string] $MsBuildPath
)

$ErrorActionPreference = 'Stop'

function Write-Info($msg)  { Write-Host "[INFO ] $msg" -ForegroundColor Cyan }
function Write-Okay($msg)  { Write-Host "[ OK  ] $msg" -ForegroundColor Green }
function Write-Warn($msg)  { Write-Host "[WARN ] $msg" -ForegroundColor Yellow }
function Write-Err ($msg)  { Write-Host "[FAIL ] $msg" -ForegroundColor Red }

function Resolve-PathSafe([string]$p) {
  if ([string]::IsNullOrWhiteSpace($p)) { return $null }
  if (Test-Path $p) { return (Resolve-Path $p).Path }
  # try relative to repo root
  $root = Split-Path -Parent $PSScriptRoot
  $candidate = Join-Path $root $p
  if (Test-Path $candidate) { return (Resolve-Path $candidate).Path }
  return $p
}

function Get-MSBuildPath() {
  if ($MsBuildPath) {
    if (Test-Path $MsBuildPath) { return (Resolve-Path $MsBuildPath).Path }
    Write-Warn "Provided MsBuildPath not found: $MsBuildPath"
  }

  # 1) Try vswhere
  $vswhere = "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe"
  if (Test-Path $vswhere) {
    try {
      $path = & $vswhere -latest -products * -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe 2>$null | Select-Object -First 1
      if ($path -and (Test-Path $path)) { return (Resolve-Path $path).Path }
    } catch { }
  }

  # 2) Common VS 2022 Community path (as used in build.bat)
  $common2022 = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\MSBuild\\Current\\Bin\\MSBuild.exe"
  if (Test-Path $common2022) { return $common2022 }

  # 3) Other plausible MSBuild locations
  $candidates = @(
    "C:\\Program Files\\Microsoft Visual Studio\\2022\\Professional\\MSBuild\\Current\\Bin\\MSBuild.exe",
    "C:\\Program Files\\Microsoft Visual Studio\\2022\\Enterprise\\MSBuild\\Current\\Bin\\MSBuild.exe",
    "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\MSBuild\\Current\\Bin\\MSBuild.exe",
    "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\BuildTools\\MSBuild\\Current\\Bin\\MSBuild.exe"
  )
  foreach ($c in $candidates) { if (Test-Path $c) { return $c } }

  throw "MSBuild.exe not found. Install Visual Studio Build Tools or provide -MsBuildPath."
}

function Invoke-NuGetRestore([string]$target) {
  $nugetExe = Join-Path (Split-Path -Parent $PSScriptRoot) 'nuget.exe'
  if (-not (Test-Path $nugetExe)) {
    Write-Warn "nuget.exe not found at repo root. Skipping restore."
    return
  }
  if (-not (Test-Path $target)) {
    Write-Warn "Restore target does not exist: $target"
    return
  }
  Write-Info "Restoring packages for: $target"
  & $nugetExe restore $target | Write-Host
  Write-Okay "NuGet restore completed"
}

# Resolve inputs to absolute paths where possible
$resolvedSolution = Resolve-PathSafe $SolutionPath
$resolvedProject  = Resolve-PathSafe $ProjectPath

if (-not $resolvedSolution -and -not $resolvedProject) {
  throw "Provide -SolutionPath or -ProjectPath."
}

$msbuild = Get-MSBuildPath
Write-Info "MSBuild: $msbuild"

# Optional restore
if ($Restore) {
  if ($resolvedSolution) { Invoke-NuGetRestore -target $resolvedSolution }
  elseif ($resolvedProject) { Invoke-NuGetRestore -target $resolvedProject }
}

# Build arguments
$targets = @()
if ($Clean) { $targets += 'Clean' }
$targets += 'Build'

$commonArgs = @(
  "/m",
  "/p:Configuration=$Configuration",
  "/v:$Verbosity"
)

if ($resolvedSolution) {
  Write-Info "Building solution: $resolvedSolution"
  & $msbuild $resolvedSolution $commonArgs "/t:$($targets -join ';')"
} else {
  Write-Info "Building project: $resolvedProject"
  & $msbuild $resolvedProject $commonArgs "/t:$($targets -join ';')"
}

if ($LASTEXITCODE -ne 0) {
  Write-Err "Build failed with exit code $LASTEXITCODE"
  exit $LASTEXITCODE
}

Write-Okay "Build succeeded"

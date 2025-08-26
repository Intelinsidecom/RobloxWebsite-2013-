param(
    [switch]$NoBackup,
    [switch]$VerboseLog
)

$ErrorActionPreference = 'Stop'

function Write-Info($msg) { if ($VerboseLog) { Write-Host "[INFO] $msg" -ForegroundColor Cyan } }
function Write-Change($msg) { Write-Host "[CHANGE] $msg" -ForegroundColor Green }
function Write-Warn($msg) { Write-Host "[WARN] $msg" -ForegroundColor Yellow }

# Base folder
$base = Join-Path $PSScriptRoot '..\Assemblies\Events\Roblox.EventStream.WebEvents'
$base = [System.IO.Path]::GetFullPath($base)

# Target folders
$targets = @()
$targets += (Join-Path $base 'Roblox.EventStream.WebEvents')
$targets += (Join-Path $base 'Roblox.EventStream.WebEvents.Events')
$targets = $targets | Where-Object { Test-Path $_ }

if ($targets.Count -eq 0) {
    Write-Warn "No target folders found under: $base"
    exit 0
}

# Backup (store under scripts/_backups to avoid project auto-includes)
if (-not $NoBackup) {
    $ts = Get-Date -Format 'yyyyMMdd_HHmmss'
    $backupRoot = Join-Path $PSScriptRoot (Join-Path '_backups' (Join-Path 'WebEvents' $ts))
    New-Item -ItemType Directory -Path $backupRoot -Force | Out-Null
    foreach ($dir in $targets) {
        $name = Split-Path $dir -Leaf
        $backup = Join-Path $backupRoot $name
        Write-Info "Backing up '$dir' -> '$backup'"
        Copy-Item -Path $dir -Destination $backup -Recurse -Force
    }
}

$files = @()
foreach ($dir in $targets) {
    $files += Get-ChildItem -Path $dir -Recurse -Filter *.cs
}

[int]$changed = 0
[int]$skipped = 0

foreach ($file in $files) {
    $lines = Get-Content -LiteralPath $file.FullName -Encoding UTF8

    $out = New-Object System.Collections.Generic.List[string]
    $foundNamespace = $false
    $modified = $false

    foreach ($line in $lines) {
        if (-not $foundNamespace) {
            if ($line -match '^\s*namespace\s') {
                $foundNamespace = $true
                $out.Add($line)
                continue
            }
            # Keep only valid pre-namespace lines
            if ($line -match '^\s*(using|global using)\s') { $out.Add($line); continue }
            if ($line -match '^\s*//') { $out.Add($line); continue }
            if ($line -match '^\s*/\*') { $out.Add($line); continue }
            if ($line -match '^\s*\*') { $out.Add($line); continue }
            if ($line -match '^\s*\*/') { $out.Add($line); continue }
            if ($line -match '^\s*$') { $out.Add($line); continue }
            # Drop malformed token line
            $modified = $true
            continue
        }
        else {
            $out.Add($line)
        }
    }

    # If file had no namespace at all, skip (do not risk damaging e.g. AssemblyInfo.cs)
    if (-not $foundNamespace) {
        $skipped++
        Write-Info "Skipped (no namespace): $($file.FullName)"
        continue
    }

    # Detect real change
    if (-not $modified) {
        # Also check if content differs (rare)
        if ($out.Count -ne $lines.Count) { $modified = $true }
        else {
            for ($i=0; $i -lt $out.Count; $i++) { if ($out[$i] -ne $lines[$i]) { $modified = $true; break } }
        }
    }

    if ($modified) {
        Set-Content -LiteralPath $file.FullName -Value $out -Encoding UTF8
        $changed++
        Write-Change "Normalized: $($file.FullName)"
    }
}

Write-Host "--- Summary ---" -ForegroundColor Magenta
Write-Host "Files scanned: $($files.Count)"
Write-Host "Files changed: $changed" -ForegroundColor Green
Write-Host "Files skipped (no namespace): $skipped"

Write-Host "Done. You can now run: dotnet build" -ForegroundColor Cyan

param(
    [int]$Port = 80
)

# Launch IIS Express for the Website folder on a specified port (default 80)
# Shows errors and waits for input before exiting so you can read messages.

$ErrorActionPreference = 'Stop'

# Ensure we have a script path on all PS versions
if (-not $PSCommandPath) { $PSCommandPath = $MyInvocation.MyCommand.Path }

# Elevate if not running as Administrator (will trigger Windows UAC dialog)
$identity = [Security.Principal.WindowsIdentity]::GetCurrent()
$principal = New-Object Security.Principal.WindowsPrincipal($identity)
if (-not $principal.IsInRole([Security.Principal.WindowsBuiltinRole]::Administrator)) {
    Write-Host "[INFO] Requesting Administrator privileges..." -ForegroundColor Yellow
    Start-Process -FilePath 'powershell' -ArgumentList @(
        '-NoProfile','-ExecutionPolicy','Bypass','-File',"`"$PSCommandPath`"",'-Port',"$Port"
    ) -Verb RunAs
    exit
}

try {
    # Resolve repository root as the parent of this script directory (scripts/..)
    $scriptRoot = Split-Path -Parent $PSCommandPath
    $repoRoot = (Resolve-Path (Join-Path $scriptRoot '..')).Path
    $webroot = Join-Path $repoRoot 'Website'

    if (-not (Test-Path (Join-Path $webroot 'web.config'))) {
        Write-Host "[ERROR] Web root not found or missing web.config at: '$webroot'" -ForegroundColor Red
        Write-Host "This script is expected to live under the 'scripts' folder, with 'Website' at the repo root (one level up)."
        Read-Host "Press Enter to exit"
        exit 1
    }

    $pf86 = $env:ProgramFilesx86
    if (-not $pf86) { $pf86 = $env:ProgramFiles } # Fallback on non-64bit systems
    $pf64 = $env:ProgramFiles

    $candidates = @(
        (Join-Path $pf86 'IIS Express\iisexpress.exe')
        (Join-Path $pf64 'IIS Express\iisexpress.exe')
    )

    $iisexpress = $candidates | Where-Object { Test-Path $_ } | Select-Object -First 1
    if (-not $iisexpress) {
        Write-Host "[ERROR] IIS Express not found. Please install IIS Express 10 (or later)." -ForegroundColor Red
        Write-Host "Download: https://www.microsoft.com/en-us/download/details.aspx?id=48264"
        Read-Host "Press Enter to exit"
        exit 1
    }

    Write-Host "[INFO] Starting IIS Express on http://localhost:$Port" -ForegroundColor Cyan
    Write-Host "       Repo root: '$repoRoot'" -ForegroundColor DarkCyan
    Write-Host "       Web root:  '$webroot'" -ForegroundColor DarkCyan

    $iisArgs = @(
        "/path:`"$webroot`"",
        "/port:$Port",
        "/systray:true"
    )

    # Run IIS Express and wait for it to exit so we can capture its exit code
    $process = Start-Process -FilePath $iisexpress -ArgumentList $iisArgs -NoNewWindow -PassThru
    $process.WaitForExit()
    $code = $process.ExitCode

    Write-Host "[INFO] IIS Express exited with code $code"
    Read-Host "Press Enter to exit"
    exit $code
}
catch {
    Write-Host "[ERROR] $($_.Exception.Message)" -ForegroundColor Red
    if ($_.ScriptStackTrace) { Write-Host $_.ScriptStackTrace }
    Read-Host "Press Enter to exit"
    exit 1
}

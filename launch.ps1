param(
    [int]$Port = 80
)

# Launch IIS Express for the Website folder on a specified port (default 80)
# Shows errors and waits for input before exiting so you can read messages.

$ErrorActionPreference = 'Stop'

try {
    $repoRoot = Split-Path -Parent $MyInvocation.MyCommand.Path
    $webroot = Join-Path $repoRoot 'Website'

    if (-not (Test-Path (Join-Path $webroot 'web.config'))) {
        Write-Host "[ERROR] Web root not found or missing web.config at: '$webroot'" -ForegroundColor Red
        Write-Host "Ensure this script is in the repo root next to the 'Website' directory."
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

    Write-Host "[INFO] Starting IIS Express on http://localhost:$Port with web root: '$webroot'" -ForegroundColor Cyan

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

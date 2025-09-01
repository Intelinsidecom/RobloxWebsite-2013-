@echo off
setlocal

REM Launcher for Find-CircularProjectRefs.ps1
REM Optional arg1: search root. If omitted, script uses repo root (one level above scripts/)

set "SCRIPT_DIR=%~dp0"
set "PS1=%SCRIPT_DIR%Find-CircularProjectRefs.ps1"

if not exist "%PS1%" (
  echo PowerShell script not found: %PS1%
  goto :pause_and_exit
)

REM Pass through first argument as the search root if provided
powershell -NoProfile -ExecutionPolicy Bypass -File "%PS1%" %*

:pause_and_exit
echo.
echo Press any key to close this window...
pause >nul
endlocal

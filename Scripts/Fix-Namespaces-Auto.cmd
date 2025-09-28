@echo off
setlocal

REM Simple launcher for Fix-Namespaces-Auto.ps1
REM Usage: double-click or run with optional args that are passed through.

set SCRIPT_DIR=%~dp0
set PS1="%SCRIPT_DIR%Fix-Namespaces-Auto.ps1"

powershell -NoProfile -ExecutionPolicy Bypass -File %PS1% %*

endlocal

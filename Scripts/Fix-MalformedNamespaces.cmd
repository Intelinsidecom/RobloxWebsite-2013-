@echo off
setlocal ENABLEDELAYEDEXPANSION

REM Launch the PowerShell fixer from repo root
set SCRIPT_DIR=%~dp0
REM Determine repository root as the parent of the scripts directory
for %%I in ("%SCRIPT_DIR%..") do set REPO_ROOT=%%~fI

powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -File "%SCRIPT_DIR%Fix-MalformedNamespaces.ps1" -Root "%REPO_ROOT%" %*

if %ERRORLEVEL% NEQ 0 (
  echo Fix-MalformedNamespaces.ps1 failed with exit code %ERRORLEVEL%
  exit /b %ERRORLEVEL%
)

endlocal

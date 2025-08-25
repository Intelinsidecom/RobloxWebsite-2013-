@echo off
setlocal enableextensions

REM Determine script directory
set SCRIPT_DIR=%~dp0
pushd "%SCRIPT_DIR%"

REM Launch PowerShell script in preview (dry-run) mode by default
if "%*"=="" (
  powershell -NoLogo -ExecutionPolicy Bypass -File "%SCRIPT_DIR%FixProjectPaths.ps1"
) else (
  powershell -NoLogo -ExecutionPolicy Bypass -File "%SCRIPT_DIR%FixProjectPaths.ps1" %*
)

popd
endlocal

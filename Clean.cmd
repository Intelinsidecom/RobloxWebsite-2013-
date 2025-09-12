@echo off
setlocal enableextensions
rem Ensure we run from the repo root (the folder containing this script)
pushd "%~dp0"

REM Launch PowerShell script in preview (dry-run) mode by default
if "%*"=="" (
  powershell -NoLogo -ExecutionPolicy Bypass -File "scripts/Clean-BuildArtifacts.ps1"
) else (
  powershell -NoLogo -ExecutionPolicy Bypass -File "scripts/Clean-BuildArtifacts.ps1" %*
)

popd
endlocal

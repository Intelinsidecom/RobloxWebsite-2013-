@echo off
setlocal enableextensions
pushd "%~dp0"

if "%*"=="" (
  powershell -NoLogo -ExecutionPolicy Bypass -File "scripts/Clean-BuildArtifacts.ps1"
) else (
  powershell -NoLogo -ExecutionPolicy Bypass -File "scripts/Clean-BuildArtifacts.ps1" %*
)

popd
endlocal

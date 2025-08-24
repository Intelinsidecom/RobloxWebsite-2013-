@echo off
setlocal enableextensions

set SCRIPT_DIR=%~dp0
pushd "%SCRIPT_DIR%"

REM Generates PlatformMoveImpactReport.txt in the same folder as this CMD
powershell -NoLogo -ExecutionPolicy Bypass -File "%SCRIPT_DIR%Analyze-PlatformMove.ps1" -Root "%SCRIPT_DIR%" -ReportPath "%SCRIPT_DIR%PlatformMoveImpactReport.txt" %*

set EXITCODE=%ERRORLEVEL%
if %EXITCODE% EQU 0 (
  echo.
  echo Report written to: "%SCRIPT_DIR%PlatformMoveImpactReport.txt"
) else (
  echo.
  echo Analysis finished with errors. See console output above.
)

popd
endlocal
exit /b %EXITCODE%

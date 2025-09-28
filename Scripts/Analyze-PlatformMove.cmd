@echo off
setlocal enableextensions

set SCRIPT_DIR=%~dp0
pushd "%SCRIPT_DIR%"

REM Normalize variables to avoid trailing-backslash quoting issues when calling PowerShell
set "ROOT_NO_TRAIL=%SCRIPT_DIR%"
if "%ROOT_NO_TRAIL:~-1%"=="\" set "ROOT_NO_TRAIL=%ROOT_NO_TRAIL:~0,-1%"
set "REPORT_FILE=%SCRIPT_DIR%PlatformMoveImpactReport.txt"

REM Generates PlatformMoveImpactReport.txt in the same folder as this CMD
powershell -NoLogo -ExecutionPolicy Bypass -File "%SCRIPT_DIR%Analyze-PlatformMove.ps1" -Root "%ROOT_NO_TRAIL%" -ReportPath "%REPORT_FILE%" %*

set EXITCODE=%ERRORLEVEL%
if %EXITCODE% EQU 0 (
  echo.
  echo Report written to: "%REPORT_FILE%"
) else (
  echo.
  echo Analysis finished with errors. See console output above.
)

popd
endlocal
exit /b %EXITCODE%

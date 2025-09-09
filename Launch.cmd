@echo off
setlocal

rem Wrapper to run PowerShell launcher and pause to display any errors
set "SCRIPT=%~dp0launch.ps1"
if not exist "%SCRIPT%" (
  echo [ERROR] Missing PowerShell script: "%SCRIPT%"
  echo Ensure launch.ps1 exists in the same folder.
  pause
  exit /b 1
)

set "PORT=%~1"
if "%PORT%"=="" set "PORT=80"

echo [INFO] Invoking PowerShell launcher on port %PORT% ...
powershell -NoProfile -ExecutionPolicy Bypass -File "%SCRIPT%" -Port %PORT%
set "EC=%ERRORLEVEL%"

echo.
echo [INFO] PowerShell script exited with code %EC%
pause

endlocal & exit /b %EC%

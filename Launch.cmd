@echo off
setlocal

rem Wrapper to run PowerShell launcher and pause to display any errors
rem Check for Administrator privileges; if missing, relaunch elevated (UAC)
net session >nul 2>&1
if not %errorlevel%==0 (
  echo [INFO] Requesting Administrator privileges...
  if "%~1"=="" (
    powershell -NoProfile -ExecutionPolicy Bypass -Command "Start-Process -FilePath '%~f0' -Verb RunAs"
  ) else (
    powershell -NoProfile -ExecutionPolicy Bypass -Command "Start-Process -FilePath '%~f0' -ArgumentList @('%*') -Verb RunAs"
  )
  exit /b
)

set "SCRIPT=%~dp0scripts\launch.ps1"
if not exist "%SCRIPT%" (
  echo [ERROR] Missing PowerShell script: "%SCRIPT%"
  echo Ensure launch.ps1 exists under the 'scripts' folder next to this file.
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

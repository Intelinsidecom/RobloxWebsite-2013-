@echo off
setlocal

rem Launch IIS Express for the Website folder on port 80
rem Note: Port 80 typically requires Administrator privileges.

set "WEBROOT=%~dp0Website"
if not exist "%WEBROOT%\web.config" (
  echo [ERROR] Web root not found or missing web.config at: "%WEBROOT%"
  echo Ensure this script is in the repo root next to the "Website" directory.
  exit /b 1
)

set "IISEXPR=%ProgramFiles%\IIS Express\iisexpress.exe"
if exist "%ProgramFiles(x86)%\IIS Express\iisexpress.exe" set "IISEXPR=%ProgramFiles(x86)%\IIS Express\iisexpress.exe"
if not exist "%IISEXPR%" (
  echo [ERROR] IIS Express not found. Please install IIS Express 10 (or later).
  echo Download: https://www.microsoft.com/en-us/download/details.aspx?id=48264
  exit /b 1
)

echo [INFO] Starting IIS Express on http://localhost:80 with web root: "%WEBROOT%"
"%IISEXPR%" /path:"%WEBROOT%" /port:80 /systray:true

endlocal
exit /b %errorlevel%

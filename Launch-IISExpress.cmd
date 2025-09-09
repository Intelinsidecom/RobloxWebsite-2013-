@echo off
setlocal

rem Generic IIS Express launcher for the Website folder
rem Usage: Launch-IISExpress.cmd [port]
rem If no port is provided, defaults to 8080 (no admin needed)

set "PORT=%~1"
if "%PORT%"=="" set "PORT=8080"

set "WEBROOT=%~dp0Website"
if not exist "%WEBROOT%\web.config" (
  echo [ERROR] Web root not found or missing web.config at: "%WEBROOT%"
  exit /b 1
)

set "IISEXPR=%ProgramFiles%\IIS Express\iisexpress.exe"
if exist "%ProgramFiles(x86)%\IIS Express\iisexpress.exe" set "IISEXPR=%ProgramFiles(x86)%\IIS Express\iisexpress.exe"
if not exist "%IISEXPR%" (
  echo [ERROR] IIS Express not found. Please install IIS Express 10 (or later).
  echo Download: https://www.microsoft.com/en-us/download/details.aspx?id=48264
  exit /b 1
)

echo [INFO] Starting IIS Express on http://localhost:%PORT% with web root: "%WEBROOT%"
"%IISEXPR%" /path:"%WEBROOT%" /port:%PORT% /systray:true

endlocal
exit /b %errorlevel%

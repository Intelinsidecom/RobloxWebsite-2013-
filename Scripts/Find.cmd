@echo off
setlocal
set SCRIPT_DIR=%~dp0
set ROOT=%CD%
if not "%~1"=="" set ROOT=%~1

REM Launch PowerShell script to detect project reference cycles
powershell -NoProfile -ExecutionPolicy Bypass -File "%SCRIPT_DIR%Find-ProjectCycles.ps1" -Root "%ROOT%" %*
set EXITCODE=%ERRORLEVEL%
endlocal & exit /b %EXITCODE%

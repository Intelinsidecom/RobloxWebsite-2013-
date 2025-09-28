@echo off
setlocal enableextensions

REM Launcher for New-SolutionFromProjects.ps1
REM Usage examples:
REM   New-SolutionFromProjects.cmd "./MySolution" "./Assemblies" MySolutionName
REM   New-SolutionFromProjects.cmd -OutputDirectory ./MySolution -SearchDirectory ./ -SolutionName MySolutionName

set SCRIPT_DIR=%~dp0
set PS1=%SCRIPT_DIR%New-SolutionFromProjects.ps1

if not exist "%PS1%" (
  echo PowerShell script not found: %PS1%
  echo Ensure New-SolutionFromProjects.ps1 exists in the scripts directory.
  pause
  exit /b 1
)

REM Invoke PowerShell script; forward all arguments
powershell -NoProfile -ExecutionPolicy Bypass -File "%PS1%" %*
set EXITCODE=%ERRORLEVEL%

if not %EXITCODE%==0 (
  echo.
  echo New-SolutionFromProjects.ps1 failed with exit code %EXITCODE%.
) else (
  echo.
  echo New-SolutionFromProjects.ps1 completed successfully.
)

pause
exit /b %EXITCODE%

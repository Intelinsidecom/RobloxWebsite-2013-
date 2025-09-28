@echo off
setlocal

REM Launch the Website csproj fixer PowerShell script from this directory
set SCRIPT_DIR=%~dp0
set REPO_ROOT=%SCRIPT_DIR%..
set WEBSITE_CSPROJ=%REPO_ROOT%\Website\Roblox.Website.csproj

powershell -NoProfile -ExecutionPolicy Bypass -File "%SCRIPT_DIR%Fix-WebsiteCsproj.ps1" -RepoRoot "%REPO_ROOT%" -CsprojPath "%WEBSITE_CSPROJ%" -Force

echo.
echo Done. Review any messages above.
pause

endlocal

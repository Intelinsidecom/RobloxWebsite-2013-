@echo off

REM Navigate to the website directory
cd /d "Website"

REM Build the project using MSBuild
REM Note: You may need to adjust the path to MSBuild based on your Visual Studio installation
dotnet build

REM Check the exit code
if %errorlevel% equ 0 (
  echo Build succeeded!
) else (
  echo Build failed with error level %errorlevel%
  pause
  exit /b %errorlevel%
)


echo If someone went wrong, issue an issue on github repo or dm my discord for help "intelinside.", yes with the dot
pause

@echo off

cd /d "Website"

dotnet build

if %errorlevel% equ 0 (
  echo Build succeeded!
) else (
  echo Build failed with error level %errorlevel%
  pause
  exit /b %errorlevel%
)

cd /d "../"
echo If someone went wrong, issue an issue on github repo or dm my discord for help "intelinside.", yes with the dot
pause
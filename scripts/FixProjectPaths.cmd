@echo off
REM Wrapper script to execute FixProjectPaths.ps1
REM Usage: FixProjectPaths.cmd [RootPath]

setlocal
set "ROOT=%~1"
if "%ROOT%"=="" set "ROOT=%CD%"

powershell -NoProfile -ExecutionPolicy Bypass -Command "& '%~dp0FixProjectPaths.ps1' -RootPath '%ROOT%'"

endlocal

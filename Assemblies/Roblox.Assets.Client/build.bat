@echo off
mkdir bin 2>nul
"C:\Program Files\dotnet\dotnet.exe" build Roblox.Assets.Client.csproj -o bin
if %errorlevel% == 0 (
  echo Build successful!
  copy bin\Roblox.Assets.Client.dll ..\..\Website\bin\
) else (
  echo Build failed.
)

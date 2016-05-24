@echo off

echo.
echo Shim NuGet package publisher
echo ============================
echo. 
echo This Windows batch file uses NuGet to automatically
echo push the Shim package to the gallery.
echo. 

timeout /T 5

:: Directory settings
set output=.\bin\nupkg
set current=..\..

echo.
echo Current directory: %current%
echo Output  directory: %output%
echo.

forfiles /p %output% /m *.nupkg /c "cmd /c %current%\NuGet.exe push @file"

pause
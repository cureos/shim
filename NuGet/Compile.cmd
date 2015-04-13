@echo off

echo.
echo Shim builder
echo ============
echo. 
echo This Windows batch file will use Visual Studio 2013 to
echo compile the Release versions of Shim.
echo. 

timeout /T 5

@if "%VS120COMNTOOLS%"=="" goto error_no_VS120COMNTOOLSDIR
@call "%VS120COMNTOOLS%VsDevCmd.bat"

@cd "..\Sources"
@call "Fetch XML Docs.bat"
@msbuild "Shim.sln" /t:Rebuild /p:Configuration=Release;Platform="Any CPU"

@goto end

@REM -----------------------------------------------------------------------
:error_no_VS120COMNTOOLSDIR
@echo ERROR: Cannot determine the location of the VS Common Tools folder.
@goto end

:end
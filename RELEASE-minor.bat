:Required Software
	:: Microsoft.NET v2.0						http://www.filehippo.com/download_dotnet_framework_2/
	:: Microsoft.NET v3.5						http://www.filehippo.com/download_dotnet_framework_3/
	:: TortoiseSVN (+command line tools)		http://www.filehippo.com/download_tortoisesvn/
	:: 7zip 32bit								http://www.filehippo.com/download_7zip_32/
	:: 7zip 64bit								http://www.filehippo.com/download_7-zip_64/
	:: SharpDevelop v4x							http://www.icsharpcode.net/OpenSource/SD/Download/#SharpDevelop4x

:Optional Software
	:: php										http://windows.php.net/download/

:DownloadLink
	:: GoogleCode: https://code.google.com/p/sar-tool/downloads/list
	:: SourceForge: http://sourceforge.net/projects/sartool/files/
	:: GitHub: https://github.com/kboronka/sar-tool/trunk

:BuildEnvironment
	@echo off
	pushd "%~dp0"
	set SOLUTION=sar-controls.sln
	set REPO=https://github.com/kboronka/sar-controls
	set CONFIG=Release
	set BASEPATH=%~dp0

:Paths
	set SAR="libs\sar-tool\release\sar.exe"
	set ZIP="%PROGRAMFILES%\7-Zip\7zG.exe" a -tzip

	
:Build
	echo "VERSION.MAJOR.MINOR.BUILD".
	set /p VERSION="> "

	call UpdateExternals.bat
	
	svn cleanup
	svn update
	svn revert -R .

	%SAR% -assy.ver \sarControls\AssemblyInfo.* %VERSION%
	%SAR% -f.del sarControls\bin\%CONFIG%\*.* /q /svn
	
	echo building binaries
	%SAR% -b.net 4.0 %SOLUTION% /p:Configuration=%CONFIG% /p:Platform=\"x86\"
	if errorlevel 1 goto BuildFailed
		
	svn cleanup
	svn revert -R .
	
:BuildComplete
	svn revert
	copy sarControls\bin\%CONFIG%\*.exe release\*.exe
	copy sarControls\bin\%CONFIG%\*.dll release\*.dll
	copy sarControls\bin\%CONFIG%\*.pdb release\*.pdb
	copy LICENSE release\LICENSE

	svn commit -m "new binaries v%VERSION%"
	%ZIP% "sar-controls %VERSION%.zip" .\release\*.*
	svn update

	%SAR% -f.bsd \sar-controls\*.cs "Kevin Boronka"
	
	echo build completed
	popd
	exit /b 0

:BuildFailed
	echo build failed
	pause
	popd
	exit /b 1	

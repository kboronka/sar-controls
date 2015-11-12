:BuildEnvironment
	@echo off
	pushd "%~dp0"

:Paths
	set uSAR="release\sar.exe"
	set ZIP="%PROGRAMFILES%\7-Zip\7zG.exe" a -tzip

	%uSAR% -bower
	%uSAR% file.removedirectory ".\libs\sar-controls" /q
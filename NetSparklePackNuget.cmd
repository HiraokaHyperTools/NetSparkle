@echo off

if "%~1"=="" (
	echo Error: A version number is required
	echo Usage: "NetSparklePackNuget.cmd [VersionNumber]"
	exit /b
)

echo Build
msbuild NetSparkle.sln ^
 "/v:minimal" ^
 /p:Configuration="Release" ^
 /p:Platform="Any CPU" ^
 || exit /b 1

echo Cleanup NuGet environment
rmdir /S /Q Nuget\core\lib
rmdir /S /Q Nuget\core\content
rmdir /S /Q Nuget\core\tools
del /q Nuget\core\*.nupkg
rmdir /S /Q Nuget\NetSparkle.UI.NetFramework.WinForms\lib
rmdir /S /Q Nuget\NetSparkle.UI.NetFramework.WinForms\content
rmdir /S /Q Nuget\NetSparkle.UI.NetFramework.WinForms\tools
del /q Nuget\NetSparkle.UI.NetFramework.WinForms\*.nupkg
rmdir /S /Q Nuget\tools\lib
rmdir /S /Q Nuget\tools\content
rmdir /S /Q Nuget\tools\tools
del /q Nuget\tools\*.nupkg

echo Create NuGet tree for core
mkdir Nuget\core\lib
mkdir Nuget\core\content
mkdir Nuget\core\tools

echo Create NuGet tree for: NetSparkle.UI.NetFramework.WinForms
mkdir Nuget\NetSparkle.UI.NetFramework.WinForms\lib
mkdir Nuget\NetSparkle.UI.NetFramework.WinForms\content
mkdir Nuget\NetSparkle.UI.NetFramework.WinForms\tools

echo Create NuGet tree for tools
mkdir Nuget\tools\lib
mkdir Nuget\tools\content
mkdir Nuget\tools\content\Extras
mkdir Nuget\tools\tools

echo Copy Core Buildoutput to Nuget dir
xcopy /s /q bin\Release\NetSparkle\* Nuget\core\lib\net45\
del /q Nuget\core\lib\net45\*.pdb

xcopy /s /q bin\Release\NetSparkle.UI.NetFramework.WinForms\* Nuget\NetSparkle.UI.NetFramework.WinForms\lib\net45\
del /q Nuget\NetSparkle.UI.NetFramework.WinForms\lib\net45\NetSparkle.dll
del /q Nuget\NetSparkle.UI.NetFramework.WinForms\lib\net45\*.pdb

echo Copy Tools Buildoutput to Nuget dir
rem xcopy /s /q /y bin\Release\NetSparkleChecker\* Nuget\tools\tools\
rem xcopy /s /q /y bin\Release\DSAHelper\* Nuget\tools\tools\
rem xcopy /s /q /y bin\Release\NetSparkleGenerator\* Nuget\tools\tools\
rem xcopy /s /q /y Extras\* Nuget\tools\content\Extras\
rem del /q Nuget\tools\tools\*.config
rem del /q Nuget\tools\tools\*.pdb
rem del /q Nuget\tools\tools\*.xml
rem del /q Nuget\tools\tools\*.manifest
rem del /q Nuget\tools\tools\*.vshost.*

echo Moving to release directory
cd Nuget

echo Packing core nuget package
cd core
..\nuget pack NetSparkle.nuspec -Version %1
cd ..

echo Packing core nuget package
cd NetSparkle.UI.NetFramework.WinForms
..\nuget pack NetSparkle.UI.NetFramework.WinForms.nuspec -Version %1
cd ..

echo Packing tools nuget package
cd tools
rem ..\nuget pack NetSparkle.Tools.nuspec -Version %1
cd ..

echo Pushing nuget package 
rem nuget Push core\HiraokaHyperTools.NetSparkle.N.%1.nupkg -Source https://www.nuget.org/api/v2/package
rem nuget Push tools\NetSparkle.New.Tools.%1.nupkg -Source https://www.nuget.org/api/v2/package

echo Leaving directories
cd ..

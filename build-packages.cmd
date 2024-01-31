@echo off
@setlocal

dotnet restore src\Veldrid.sln

set UseStableVersions=true
set ExcludeD3D11=true
set ExcludeOpenGL=true
set ExcludeMetal=true

dotnet pack -c Release src\Veldrid\Veldrid.csproj
dotnet pack -c Release src\Veldrid.Utilities\Veldrid.Utilities.csproj
dotnet pack -c Release src\Veldrid.RenderDoc\Veldrid.RenderDoc.csproj

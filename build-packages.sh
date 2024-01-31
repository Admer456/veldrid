dotnet restore src/Veldrid.sln
dotnet restore src/Veldrid.sln

export UseStableVersions=true
export ExcludeD3D11=true
export ExcludeOpenGL=true
export ExcludeMetal=true

dotnet pack -c Release src/Veldrid/Veldrid.csproj
dotnet pack -c Release src/Veldrid.Utilities/Veldrid.Utilities.csproj
dotnet pack -c Release src/Veldrid.RenderDoc/Veldrid.RenderDoc.csproj

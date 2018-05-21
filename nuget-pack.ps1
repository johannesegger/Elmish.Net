Param(
  [Parameter(Mandatory=$True)][string]$version
)

Push-Location $PSScriptRoot
$outputPath = "$pwd\dist"
dotnet pack Elmish.Net /p:Version=$version /p:PackageOutputPath=$outputPath
dotnet pack Wpf.Elmish.Net /p:Version=$version /p:PackageOutputPath=$outputPath
Pop-Location
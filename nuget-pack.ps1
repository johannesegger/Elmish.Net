Param(
  [Parameter(Mandatory=$True)][string]$version
)

Push-Location $PSScriptRoot
dotnet pack Wpf.Elmish /p:Version=$version /p:PackageOutputPath=$pwd
Pop-Location
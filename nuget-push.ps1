Param(
  [Parameter(Mandatory=$True)][string]$packagePath,
  [Parameter(Mandatory=$True)][string]$apiKey
)

dotnet nuget push $packagePath -s https://api.nuget.org/v3/index.json -k $apiKey
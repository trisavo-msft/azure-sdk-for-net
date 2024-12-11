param (
    [string] $ProjectNames,
    [string] $OutputPath,
    [string] $PackageInfoFolder
)

. $PSScriptRoot/generate-dependency-functions.ps1

# set changed services given the set of changed packages, this will mean that
# ChangedServices will be appropriate for the batched set of packages if that is indeed how
# we set the targeted artifacts
$packageProperties = Get-ChildItem -Recurse "$PackageInfoFolder" *.json `
| Foreach-Object { Get-Content -Raw -Path $_.FullName | ConvertFrom-Json }

$packageSet = "$ProjectNames" -split ","

$changedServicesArray = $packageProperties | Where-Object { $packageSet -contains $_.ArtifactName }
| ForEach-Object { $_.ServiceDirectory } | Get-Unique
$changedServices = $changedServicesArray -join ","

$changedProjects = $packageProperties | Where-Object { $packageSet -contains $_.ArtifactName }
| ForEach-Object { "$($_.DirectoryPath)/src/$($_.ArtifactName).csproj" }

$projectsForGeneration = ($changedProjects | ForEach-Object { "`$(RepoRoot)$_" } | Sort-Object)
$projectGroups = @()
$projectGroups += ,$projectsForGeneration
$outputFiles = Write-Test-Dependency-Group-To-Files -ProjectFileConfigName "packages" -ProjectGroups $projectGroups -MatrixOutputFolder $OutputPath

# debug, will remove
Get-ChildItem -Recurse $OutputPath | ForEach-Object { Write-Host "Dumping $($_.FullName)"; Get-Content -Raw -Path $_.FullName | Write-Host }

Write-Host "##vso[task.setvariable variable=ProjectListOverrideFile;]$OutputPath/$($outputFiles[0])"
Write-Host "##vso[task.setvariable variable=ChangedServices;]$changedServices"
Write-Host "This run is targeting: $ProjectNames in [$changedServices]"
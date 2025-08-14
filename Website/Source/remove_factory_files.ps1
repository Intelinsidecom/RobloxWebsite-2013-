# PowerShell script to remove deleted Factory files from the project
$projectFile = "C:\Users\Intel\Documents\GitHub\RobloxWebsite-2013-\Website\Source\Roblox.Website.csproj"

# Read the content of the project file
$content = Get-Content $projectFile

# List of files to remove
$filesToRemove = @(
    "Factories\\Credentials.cs",
    "Factories\\IAccount.cs",
    "Factories\\IAsset.cs",
    "Factories\\IRole.cs",
    "Factories\\IRoleSet.cs",
    "Factories\\IRoleSetReader.cs",
    "Factories\\IRoleSetValidator.cs",
    "Factories\\IUser.cs",
    "Factories\\IUserEmail.cs",
    "Factories\\IUserFactory.cs",
    "Factories\\Role.cs",
    "Factories\\RoleSet.cs",
    "Factories\\RoleSetReader.cs",
    "Factories\\RoleSetValidator.cs",
    "Factories\\UserEmail.cs",
    "Factories\\UserEmailFactory.cs",
    "Factories\\UserFactory.cs"
)

# Remove the lines that include these files
$newContent = $content | Where-Object { 
    $line = $_
    $removeLine = $false
    foreach ($file in $filesToRemove) {
        if ($line -match $file) {
            $removeLine = $true
            break
        }
    }
    !$removeLine
}

# Write the new content back to the file
$newContent | Set-Content $projectFile

Write-Host "Deleted Factory files removed from the project file."

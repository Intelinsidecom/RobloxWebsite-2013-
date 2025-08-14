# PowerShell script to add missing Factory files to the project
$projectFile = "C:\Users\Intel\Documents\GitHub\RobloxWebsite-2013-\Website\Source\Roblox.Website.csproj"

# Read the content of the project file
$content = Get-Content $projectFile

# Find the line where we want to insert the new files
$index = 0
for ($i = 0; $i -lt $content.Length; $i++) {
    if ($content[$i] -match "Factories\\SecurityDomainFactories.cs") {
        $index = $i + 1
        break
    }
}

# Create the new lines to insert
$newLines = @(
    "    <Compile Include=`"Factories\Credentials.cs`" />",
    "    <Compile Include=`"Factories\IAccount.cs`" />",
    "    <Compile Include=`"Factories\IAsset.cs`" />",
    "    <Compile Include=`"Factories\IRoleSetValidator.cs`" />",
    "    <Compile Include=`"Factories\IUser.cs`" />",
    "    <Compile Include=`"Factories\Role.cs`" />",
    "    <Compile Include=`"Factories\RoleSet.cs`" />",
    "    <Compile Include=`"Factories\RoleSetValidator.cs`" />",
    "    <Compile Include=`"Factories\UserEmail.cs`" />",
    "    <Compile Include=`"Factories\UserEmailFactory.cs`" />",
    "    <Compile Include=`"Factories\UserFactory.cs`" />"
)

# Insert the new lines
$newContent = @()
for ($i = 0; $i -lt $content.Length; $i++) {
    $newContent += $content[$i]
    if ($i -eq $index - 1) {
        $newContent += $newLines
    }
}

# Write the new content back to the file
$newContent | Set-Content $projectFile

Write-Host "Missing Factory files added to the project file."

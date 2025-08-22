# Roblox.Amazon.Sns Project Exclusion

## Reason for Exclusion
The Roblox.Amazon.Sns project has been excluded from the solution build due to missing AWS SDK dependencies:

1. Missing AWSSDK.SimpleNotificationService package (version 3.7.0)
2. Incomplete AWS SDK Core package integration
3. Protected member access issues in the code that would require significant refactoring

## Errors Encountered
When attempting to build the project, the following errors were observed:

1. `CS1540: Cannot access protected member 'ApplicationSettingsBase.OnSettingsLoaded'`
2. `CS1540: Cannot access protected member 'AmazonServiceClient.CustomizeRuntimePipeline'`

## How to Restore the Project
If you need to restore and build this project in the future, follow these steps:

1. Obtain the AWSSDK.SimpleNotificationService package (version 3.7.0) from the AWS SDK for .NET
2. Ensure the AWSSDK.Core package (version 3.7.0) is properly installed
3. Update the project references in `Roblox.Amazon.Sns.csproj` to use NuGet package references instead of direct DLL references
4. Fix the protected member access issues in:
   - `Roblox.Amazon.Sns.Properties\Settings.cs` (line 102)
   - `Roblox.Amazon.Sns\RobloxSnsClient.cs` (line 37)
5. Re-add the project to the solution file `RobloxWebsite.sln`

## Alternative Approach
If AWS SNS functionality is not critical, consider removing this project entirely and refactoring any code that depends on it.

## Current Status
The project is currently excluded from the solution build to allow other projects to build successfully.

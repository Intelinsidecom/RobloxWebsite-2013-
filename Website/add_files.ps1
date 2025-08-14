$content = Get-Content 'c:\Users\Intel\Documents\GitHub\RobloxWebsite-2013-\Website\Source\Roblox.Website.csproj'
$content = $content -replace '<Compile Include="Showcases\\Entities\\Showcase.cs" />', "<Compile Include=`"Showcases\Entities\Showcase.cs`" />
    <Compile Include=`"Showcases\Entities\ShowcaseItem.cs`" />
    <Compile Include=`"Showcases\Entities\ShowcaseType.cs`" />"
$content | Set-Content 'c:\Users\Intel\Documents\GitHub\RobloxWebsite-2013-\Website\Source\Roblox.Website.csproj'

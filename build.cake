var npi = EnvironmentVariable("npi");
var project = "src/RotateEncryption/RotateEncryption.csproj";

Task("Pack").Does(() => {
    DotNetCorePack(project, new DotNetCorePackSettings
     {
         Configuration = "Release",
         OutputDirectory = "./artifacts"
     });
});

Task("Publish-Nuget")
    .IsDependentOn("Pack")
    .Does(() => {
        var nupkg = new DirectoryInfo("artifacts").GetFiles("*.nupkg").LastOrDefault();
        var package = nupkg.FullName;
        NuGetPush(package, new NuGetPushSettings {
            Source = "https://www.nuget.org/api/v2/package",
            ApiKey = npi
        });
});

var target = Argument("target", "default");
RunTarget(target);
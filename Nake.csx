public const string RootPath = "$NakeScriptDirectory$";
public const string OutputPath = RootPath + @"\Output";

[Task] public static void Default()
{
	Greeting();
}

/// <summary> 
/// Restores NuGet packages. Intended for first project run.
/// </summary>
[Task] public static void RestorePackages()
{
	Cmd.Exec(@"src\.nuget\Nuget.exe restore");
}

[Task] public static void SetupDatabase()
{
	Cmd.Exec(@"src\Mojito.Console\bin\Debug\Mojito.Console.exe -s");
}

/// <summary> 
/// Very simple demo task. See other demo tasks for more useful stuff ;)
/// </summary>
[Task] public static void Greeting()
{
	Log.Info("Hello from Nake!");
}

/// <summary> 
/// Wipeout all build output and temporary build files
/// </summary>
[Task] public static void Clean(string path = OutputPath)
{
	FS.RemoveDir(@"**\bin|**\obj");

	FS.Delete(@"{path}\*.*|-:*.vshost.exe");
	FS.RemoveDir(@"{path}\*");
}

/// <summary>
/// Builds you solution's sources  
/// </summary>
[Task] public static void Build(string configuration = "Debug", string platform = "Any CPU", string outputPath = OutputPath)
{
	Clean(outputPath);

	MSBuild
		
		.Projects("Mojito.sln")
			.Property("Configuration", configuration) 
			.Property("Platform", platform)
			.Property("OutDir", outputPath)
			.Property("ReferencePath", outputPath)

	.Build();
}
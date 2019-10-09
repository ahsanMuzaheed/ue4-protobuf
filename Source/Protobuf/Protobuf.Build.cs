// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;
public class Protobuf : ModuleRules
{
    private string ModulePath
    {
        get { return ModuleDirectory; }
    }

    private string ThridPartyPath
    {
        get { return Path.Combine(ModulePath, "ThirdParty/"); }
    }

    public Protobuf(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);

        PublicSystemIncludePaths.AddRange(
            new string[]
            {
                Path.Combine(ThridPartyPath,"protobuf/Include")
            }
            );

        PublicAdditionalLibraries.AddRange(
            new string[]
            {
                Path.Combine(ThridPartyPath,"protobuf/lib/Win64/MD/Release","libprotobuf.lib"),
                Path.Combine(ThridPartyPath,"protobuf/lib/Win64/MD/Release","libprotobuf-lite.lib"),
                Path.Combine(ThridPartyPath,"protobuf/lib/Win64/MD/Release","libprotoc.lib"),
            }
            );
        bEnableUndefinedIdentifierWarnings = false;
        bUseRTTI = true;
        bEnableExceptions = true;
    }
}

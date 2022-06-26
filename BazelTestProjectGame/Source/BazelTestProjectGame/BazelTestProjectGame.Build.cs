// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BazelTestProjectGame : ModuleRules
{
	public BazelTestProjectGame(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

	}
}

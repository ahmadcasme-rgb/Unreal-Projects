// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DungeonQuest : ModuleRules
{
	public DungeonQuest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"DungeonQuest",
			"DungeonQuest/Variant_Horror",
			"DungeonQuest/Variant_Horror/UI",
			"DungeonQuest/Variant_Shooter",
			"DungeonQuest/Variant_Shooter/AI",
			"DungeonQuest/Variant_Shooter/UI",
			"DungeonQuest/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

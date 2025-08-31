// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LongSword : ModuleRules
{
	public LongSword(ReadOnlyTargetRules Target) : base(Target)
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
			"LongSword",
			"LongSword/Variant_Platforming",
			"LongSword/Variant_Platforming/Animation",
			"LongSword/Variant_Combat",
			"LongSword/Variant_Combat/AI",
			"LongSword/Variant_Combat/Animation",
			"LongSword/Variant_Combat/Gameplay",
			"LongSword/Variant_Combat/Interfaces",
			"LongSword/Variant_Combat/UI",
			"LongSword/Variant_SideScrolling",
			"LongSword/Variant_SideScrolling/AI",
			"LongSword/Variant_SideScrolling/Gameplay",
			"LongSword/Variant_SideScrolling/Interfaces",
			"LongSword/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

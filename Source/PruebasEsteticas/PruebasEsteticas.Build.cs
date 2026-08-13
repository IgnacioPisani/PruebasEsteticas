// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PruebasEsteticas : ModuleRules
{
	public PruebasEsteticas(ReadOnlyTargetRules Target) : base(Target)
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
			"PruebasEsteticas",
			"PruebasEsteticas/Variant_Platforming",
			"PruebasEsteticas/Variant_Platforming/Animation",
			"PruebasEsteticas/Variant_Combat",
			"PruebasEsteticas/Variant_Combat/AI",
			"PruebasEsteticas/Variant_Combat/Animation",
			"PruebasEsteticas/Variant_Combat/Gameplay",
			"PruebasEsteticas/Variant_Combat/Interfaces",
			"PruebasEsteticas/Variant_Combat/UI",
			"PruebasEsteticas/Variant_SideScrolling",
			"PruebasEsteticas/Variant_SideScrolling/AI",
			"PruebasEsteticas/Variant_SideScrolling/Gameplay",
			"PruebasEsteticas/Variant_SideScrolling/Interfaces",
			"PruebasEsteticas/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

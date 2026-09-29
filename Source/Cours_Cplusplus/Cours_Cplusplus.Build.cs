// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Cours_Cplusplus : ModuleRules
{
	public Cours_Cplusplus(ReadOnlyTargetRules Target) : base(Target)
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
			"Cours_Cplusplus",
			"Cours_Cplusplus/Variant_Platforming",
			"Cours_Cplusplus/Variant_Platforming/Animation",
			"Cours_Cplusplus/Variant_Combat",
			"Cours_Cplusplus/Variant_Combat/AI",
			"Cours_Cplusplus/Variant_Combat/Animation",
			"Cours_Cplusplus/Variant_Combat/Gameplay",
			"Cours_Cplusplus/Variant_Combat/Interfaces",
			"Cours_Cplusplus/Variant_Combat/UI",
			"Cours_Cplusplus/Variant_SideScrolling",
			"Cours_Cplusplus/Variant_SideScrolling/AI",
			"Cours_Cplusplus/Variant_SideScrolling/Gameplay",
			"Cours_Cplusplus/Variant_SideScrolling/Interfaces",
			"Cours_Cplusplus/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

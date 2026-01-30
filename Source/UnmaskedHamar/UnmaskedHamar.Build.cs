// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnmaskedHamar : ModuleRules
{
	public UnmaskedHamar(ReadOnlyTargetRules Target) : base(Target)
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
			"UnmaskedHamar",
			"UnmaskedHamar/Variant_Platforming",
			"UnmaskedHamar/Variant_Platforming/Animation",
			"UnmaskedHamar/Variant_Combat",
			"UnmaskedHamar/Variant_Combat/AI",
			"UnmaskedHamar/Variant_Combat/Animation",
			"UnmaskedHamar/Variant_Combat/Gameplay",
			"UnmaskedHamar/Variant_Combat/Interfaces",
			"UnmaskedHamar/Variant_Combat/UI",
			"UnmaskedHamar/Variant_SideScrolling",
			"UnmaskedHamar/Variant_SideScrolling/AI",
			"UnmaskedHamar/Variant_SideScrolling/Gameplay",
			"UnmaskedHamar/Variant_SideScrolling/Interfaces",
			"UnmaskedHamar/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

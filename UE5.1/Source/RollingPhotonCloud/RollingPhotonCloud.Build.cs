// Copyright 1998-2020 jbelon - juaxix - xixgames, Inc. All Rights Reserved.

using System;
using UnrealBuildTool;

public class RollingPhotonCloud : ModuleRules
{
	public RollingPhotonCloud(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
			{"Core", "CoreUObject", "Engine", "InputCore", "PhotonCloudAPI"});

		PrivateDependencyModuleNames.AddRange(new string[] {"PhotonCloudAPI"});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true

		PrivateIncludePathModuleNames.AddRange(new string[] {"PhotonCloudAPI"});
		//PublicIncludePaths.AddRange(new string[] {"../Plugins/PhotonCloudAPI/Source/PhotonCloudAPI/Public"});
	}
}
// Copyright 1998-2020 jbelon - juaxix - xixgames, Inc. All Rights Reserved.

using System;
using UnrealBuildTool;

public class RollingPhotonCloud : ModuleRules
{
	public RollingPhotonCloud(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"PhotonCloudAPI"
		});

		PrivateDependencyModuleNames.AddRange(new string[] {"PhotonCloudAPI"});
		PrivateIncludePathModuleNames.AddRange(new string[] {"PhotonCloudAPI"});
	}
}
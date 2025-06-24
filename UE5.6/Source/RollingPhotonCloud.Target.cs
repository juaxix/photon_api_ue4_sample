// Copyright 1998-2024 jbelon - juaxix - xixgames, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RollingPhotonCloudTarget : TargetRules
{
	public RollingPhotonCloudTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		/*if (Target.Platform == UnrealTargetPlatform.PS5)
		{
			AdditionalLinkerArguments += " -lSceCes -lSceCesCs_stub_weak ";
		}*/
		if (Target.Platform.IsInGroup(UnrealPlatformGroup.Linux))
		{
			AdditionalLinkerArguments += "  -Wl,--as-needed,-lstdc++";
		}
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		bLegacyPublicIncludePaths = false;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.AddRange(new string[] {"RollingPhotonCloud"});
	}
}
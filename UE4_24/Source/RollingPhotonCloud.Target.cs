// Copyright 1998-2020 jbelon - juaxix - xixgames, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RollingPhotonCloudTarget : TargetRules
{
	public RollingPhotonCloudTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		if (Target.Platform == UnrealTargetPlatform.PS4)
		{
			AdditionalLinkerArguments += " -lSceCes -lSceCesCs_stub_weak ";
		}
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "RollingPhotonCloud" } );
	}
}

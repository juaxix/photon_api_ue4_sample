// Copyright 1998-2020 jbelon - juaxix - xixgames, Inc. All Rights Reserved.

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
		DefaultBuildSettings = BuildSettingsVersion.V2;
		bLegacyPublicIncludePaths = false;
		//ShadowVariableWarningLevel = WarningLevel.Error;

		ExtraModuleNames.AddRange(new string[] {"RollingPhotonCloud"});
	}
}
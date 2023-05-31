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
		else if (Target.Platform == UnrealTargetPlatform.Linux)
		{
			// TODO: add these flags
			AdditionalCompilerArguments += " -Wl --copy-dt-needed-entries ";
		}
		DefaultBuildSettings = BuildSettingsVersion.V2;
		bLegacyPublicIncludePaths = false;
		ShadowVariableWarningLevel = WarningLevel.Error;

		ExtraModuleNames.AddRange(new string[] {"RollingPhotonCloud"});
	}
}
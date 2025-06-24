// Copyright 1998-2024 jbelon - juaxix - xixgames, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RollingPhotonCloudEditorTarget : TargetRules
{
	public RollingPhotonCloudEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		bLegacyPublicIncludePaths = false;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.AddRange(new string[] {"RollingPhotonCloud"});
	}
}
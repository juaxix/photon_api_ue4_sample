// Copyright 1998-2020 jbelon - juaxix - xixgames, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RollingPhotonCloudEditorTarget : TargetRules
{
	public RollingPhotonCloudEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		bLegacyPublicIncludePaths = false;
		ShadowVariableWarningLevel = WarningLevel.Error;
		ExtraModuleNames.AddRange( new string[] { "RollingPhotonCloud" } );
	}
}

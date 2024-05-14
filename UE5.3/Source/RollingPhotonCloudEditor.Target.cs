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
		// In case you want to debug photon ,you need an engine that's capable of set to be unique
		// BuildEnvironment = TargetBuildEnvironment.Unique;
		// bDebugBuildsActuallyUseDebugCRT = true;
	}
}
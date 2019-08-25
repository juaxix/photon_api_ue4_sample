// Copyright 1998-2019 jbelon - juaxix - xixgames, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RollingPhotonCloudTarget : TargetRules
{
	public RollingPhotonCloudTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "RollingPhotonCloud" } );
	}
}

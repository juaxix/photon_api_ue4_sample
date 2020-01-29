// Copyright 1998-2019 jbelon - juaxix - xixgames, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "RollingGameModeBase.generated.h"

/**
 * Example of Game Mode with the ability of adding the current PhotonCloudAPI Actor in the seamlessTravelActor list to remain when the level changes.
 */
UCLASS()
class ROLLINGPHOTONCLOUD_API ARollingGameModeBase : public AGameModeBase
{
  GENERATED_BODY()

  ARollingGameModeBase(const FObjectInitializer & ObjectInitializer);
  
  void GetSeamlessTravelActorList(bool bToTransition, TArray<AActor*>& ActorList) override;
};

// Copyright 1998-2019 jbelon - juaxix - xixgames, Inc. All Rights Reserved.
#include "RollingGameModeBase.h"
#include "PhotonCloudAPIBPLibrary.h"
#include "PhotonCloud.h"

ARollingGameModeBase::ARollingGameModeBase(const FObjectInitializer & ObjectInitializer) : Super(ObjectInitializer)
{
  bUseSeamlessTravel = true;
}

//You need to add here the Photon Cloud Mediator Actor to avoid it to be destroyed on level change
void ARollingGameModeBase::GetSeamlessTravelActorList(bool bToTransition, TArray<AActor*>& ActorList)
{
  AActor* mediator = UPhotonCloudAPIBPLibrary::GetPhotonCloud();
  if (IsValid(mediator)) ActorList.Emplace(mediator);
}

// Copyright 1998-2020 jbelon - juaxix - xixgames, Inc. All Rights Reserved.
#include "RollingGameModeBase.h"
#include "PhotonCloudActor_deprecated.h"
#include "PhotonCloudObject.h"
#include "PhotonCloudSubsystem.h"

ARollingGameModeBase::ARollingGameModeBase(const FObjectInitializer& ObjectInitializer) : Super(ObjectInitializer)
{
	bUseSeamlessTravel = true;
}

void ARollingGameModeBase::GetSeamlessTravelActorList(bool bToTransition, TArray<AActor*>& ActorList)
{
	// add actors for seamless travel, for example from the list of observed actors
	if (UPhotonCloudObject* PhotonCloud = GetGameInstance()->GetSubsystem<UPhotonCloudSubsystem>()->GetPhotonCloudAPI())
	{
		auto ObservedMechanicsActors = PhotonCloud->GetObservedMechanicsActors();
		for (auto& ObservedMechanicsActor: ObservedMechanicsActors)
		{
			if (IsValid(ObservedMechanicsActor.Value) && ObservedMechanicsActor.Value->IsA(AActor::StaticClass()))
			{
				ActorList.Add(Cast<AActor>(ObservedMechanicsActor.Value));
			}
		}
	}
}

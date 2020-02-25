// Copyright 1998-2020 jbelon - juaxix - xixgames, Inc. All Rights Reserved.
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
  APhotonCloud* photonCloud = UPhotonCloudAPIBPLibrary::GetPhotonCloud();
  if (IsValid(photonCloud)) 
  {
    ActorList.AddUnique(photonCloud);
    for(const auto observedActor : photonCloud->GetObservedMechanicsActors())
    {
      AActor* actor = Cast<AActor>(observedActor.Value);
      if(IsValid(actor) && UKismetSystemLibrary::DoesImplementInterface(actor, UPhotonMechanics::StaticClass()))
      {
        TArray<AActor*> subActors = Cast<IPhotonMechanics>(actor)->Execute_GetActorSeamlessTravelActorList(actor);
        for (AActor* subActor : subActors)
        {
          ActorList.AddUnique(subActor);
        }
      }
    }
  }
  
}

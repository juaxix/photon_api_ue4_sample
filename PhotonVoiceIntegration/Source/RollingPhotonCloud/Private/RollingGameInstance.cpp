// Copyright 1998-2022 jbelon - juaxix - xixgames, Inc. All Rights Reserved.

#include "RollingGameInstance.h"
#include "PhotonCloudConfig.h"
#include "PhotonCloudObject.h"


#pragma optimize("", off)
void URollingGameInstance::Init()
{
#if WITH_EDITOR
	UObject* CloudBPAsset = Cast<UObject>(StaticLoadObject(UObject::StaticClass(), NULL,
			 TEXT("/Game/PhotonCloudAPI/RollingBP/Blueprints/PhotonCloudObjectAPI_BP.PhotonCloudObjectAPI_BP")));
	
#else
	UClass* CloudBP = StaticLoadClass(UObject::StaticClass(), NULL,
		TEXT("/Game/PhotonCloudAPI/RollingBP/Blueprints/PhotonCloudObjectAPI_BP.PhotonCloudObjectAPI_BP_C"));
#endif

	if (UPhotonCloudConfig* PhotonConfig = GetMutableDefault<UPhotonCloudConfig>())
	{
#if WITH_EDITOR
		if (UBlueprint* CloudBP = Cast<UBlueprint>(CloudBPAsset))
		{
			PhotonConfig->PhotonCloudAPIObjectClass = CloudBP->GeneratedClass;
		}
#else
		UPhotonCloudConfig::PhotonCloudAPIObjectClassOverride = CloudBP;
		UE_LOG(LogTemp, Log, TEXT("Class %s"), *CloudBP->GetName());
#endif
	}
	
	Super::Init();
}
#pragma optimize("", on)
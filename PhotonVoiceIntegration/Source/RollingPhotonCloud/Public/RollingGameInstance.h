// Copyright 1998-2022 jbelon - juaxix - xixgames, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Engine/GameInstance.h"
#include "RollingGameInstance.generated.h"

UCLASS()
class ROLLINGPHOTONCLOUD_API URollingGameInstance : public UGameInstance
{
	GENERATED_BODY()

public:
	virtual void Init() override;
};

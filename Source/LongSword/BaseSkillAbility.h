// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "BaseSkillAbility.generated.h"

/**
 * 
 */
UCLASS(Blueprintable)

class LONGSWORD_API UBaseSkillAbility : public UObject
{
	GENERATED_BODY()

public:
    // --- Propriedades Básicas da Habilidade ---

    UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "Skill Properties")
    FText SkillName;

    UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "Skill Properties")
    FText SkillDescription;

    UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "Skill Properties")
    TSoftObjectPtr<UTexture2D> SkillIcon;

    UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "Skill Properties")
    float ManaCost;

    UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "Skill Properties")
    float Cooldown;
};

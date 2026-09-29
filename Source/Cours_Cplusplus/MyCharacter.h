// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Cours_CplusplusCharacter.h"
#include "MyCharacter.generated.h"

class UInputAction;

UCLASS()
class COURS_CPLUSPLUS_API AMyCharacter : public ACharacter
{
	GENERATED_BODY()

public:
	// Sets default values for this character's properties
	AMyCharacter();
	void AjouerPoints(int32 Points);

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

	// Called to bind functionality to input
	virtual void SetupPlayerInputComponent(class UInputComponent* PlayerInputComponent) override;
	
	void DebutSprint();
	void FinSprint();
	
	UPROPERTY(EditAnywhere, category="Input")
	UInputAction* SprintAction;
	
	UPROPERTY(EditAnywhere, category="Cours")
	float VitesseMarche = 250.f;
	
	UPROPERTY(EditAnywhere, category="Cours")
	float VitesseSprint = 700.f;
	
	UPROPERTY(EditAnywhere, category="Cours")
	float ForceJump = 700.f;

	UPROPERTY(EditAnywhere, Category="Cours")
	int32 NombreDeSauts = 2;

private:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;



};

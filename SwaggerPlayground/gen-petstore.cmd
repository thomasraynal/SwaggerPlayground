if exist "..\PetStore\PetStore\_Generated\"  rd /s /q "../PetStore/PetStore/_Generated"
timeout /t 5
dotnet-codegen ./Specs/petstore.yaml ./Templates ../PetStore/PetStore

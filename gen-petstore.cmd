if exist ".\_PetStore\_Generated\"  rd /s /q "./_PetStore/_Generated"
timeout /t 5
dotnet-codegen ./Specs/petstore.yaml ./Templates ./_PetStore

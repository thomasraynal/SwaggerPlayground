if exist ./_PetStore rmdir ./_PetStore /q /s
dotnet-codegen ./Specs/petstore.json ./Templates ./_PetStore

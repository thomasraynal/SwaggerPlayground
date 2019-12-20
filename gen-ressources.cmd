if exist ".\_RessourceService\_Generated\" rd /s /q "./_RessourceService/_Generated"
timeout /t 5
dotnet-codegen ./Specs/ressources.json ./Templates ./_RessourceService

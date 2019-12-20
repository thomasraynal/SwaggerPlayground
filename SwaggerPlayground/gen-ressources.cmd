if exist ".\RessourceService\RessourceServiceGateway\_Generated\" rd /s /q "../RessourceService/RessourceServiceGateway/_Generated"
timeout /t 5
dotnet-codegen ./Specs/ressources.json ./Templates ../RessourceService/RessourceServiceGateway

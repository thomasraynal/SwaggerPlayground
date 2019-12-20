if exist ".\_Imperium\_Generated\"  rd /s /q "./_Imperium/_Generated"
timeout /t 5
dotnet-codegen ./Specs/imperium.yaml ./Templates ./_Imperium

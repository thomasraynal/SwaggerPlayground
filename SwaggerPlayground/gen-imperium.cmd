if exist "..\Imperium\Imperium\_Generated\"  rd /s /q "../Imperium/Imperium/_Generated"
timeout /t 3
dotnet-codegen ./Specs/imperium.yaml ./Templates ../Imperium/Imperium

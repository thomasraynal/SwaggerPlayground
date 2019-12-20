if exist "..\Fnac\Fnac\_Generated\"  rd /s /q "../Fnac/Fnac/_Generated"
timeout /t 5
dotnet-codegen ./Specs/fnac.yaml ./Templates ../Fnac/Fnac

if exist "..\Fnac\Fnac\_Generated\"  rd /s /q "../Fnac/Fnac/_Generated"
timeout /t 3
dotnet-codegen ./Specs/fnac.yaml ../Fnac/Fnac ./Templates

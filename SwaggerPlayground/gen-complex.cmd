if exist ".\Complex\Complex\_Generated\" rd /s /q "../Complex/Complex/_Generated"
timeout /t 3
dotnet-codegen ./Specs/complex.yaml ./Templates ../Complex/Complex

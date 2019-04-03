# Orleans-Farm
Microsoft Orleans example using VSCode and Docker

Based on: [Microsoft Orleans](https://github.com/dotnet/orleans) - [Docker Sample](https://github.com/dotnet/orleans/tree/master/Samples/2.0/docker-aspnet-core)

# Usage
Save value to ValueGrain: POST http://localhost:5000/api/values/1 "Vyrotek"

Get value from ValueGrain: GET http://localhost:5000/api/values/1

Calc value on CalcGrain: POST http://localhost:5000/api/calc/4fb3a54b-72e1-4828-8ccd-beea9d822d8f 500

Get count from CalcGrain: GET http://localhost:5000/api/calc/4fb3a54b-72e1-4828-8ccd-beea9d822d8f

Silo Dashboard: http://localhost:8080

# Docker
TODO

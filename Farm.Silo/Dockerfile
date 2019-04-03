FROM mcr.microsoft.com/dotnet/core/runtime:2.2-stretch-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Farm.Silo/Farm.Silo.csproj", "Farm.Silo/"]
COPY ["Farm.Core/Farm.Core.csproj", "Farm.Core/"]
RUN dotnet restore "Farm.Silo/Farm.Silo.csproj"
COPY . .
WORKDIR "/src/Farm.Silo"
RUN dotnet build "Farm.Silo.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Farm.Silo.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Farm.Silo.dll"]

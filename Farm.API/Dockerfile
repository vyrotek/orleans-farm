FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Farm.API/Farm.API.csproj", "Farm.API/"]
COPY ["Farm.Core/Farm.Core.csproj", "Farm.Core/"]
RUN dotnet restore "Farm.API/Farm.API.csproj"
COPY . .
WORKDIR "/src/Farm.API"
RUN dotnet build "Farm.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Farm.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Farm.API.dll"]

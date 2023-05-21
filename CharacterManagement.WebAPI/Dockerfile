#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CharacterManagement.WebAPI/CharacterManagement.WebAPI.csproj", "CharacterManagement.WebAPI/"]
RUN dotnet restore "CharacterManagement.WebAPI/CharacterManagement.WebAPI.csproj"
COPY . .
WORKDIR "/src/CharacterManagement.WebAPI"
RUN dotnet build "CharacterManagement.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CharacterManagement.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CharacterManagement.WebAPI.dll"]
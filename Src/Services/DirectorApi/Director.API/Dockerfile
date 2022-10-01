#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Src/Services/DirectorApi/Director.API/Director.API.csproj", "Src/Services/DirectorApi/Director.API/"]
COPY ["Src/Services/DirectorApi/Director.API.Infrastructore/Director.API.Infrastructore.csproj", "Src/Services/DirectorApi/Director.API.Infrastructore/"]
COPY ["Src/Services/DirectorApi/Director.API.Models/Director.API.Models.csproj", "Src/Services/DirectorApi/Director.API.Models/"]
COPY ["Src/Services/DirectorApi/Director.API.Services/Director.API.Services.csproj", "Src/Services/DirectorApi/Director.API.Services/"]
RUN dotnet restore "Src/Services/DirectorApi/Director.API/Director.API.csproj"
COPY . .
WORKDIR "/src/Src/Services/DirectorApi/Director.API"
RUN dotnet build "Director.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Director.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Director.API.dll"]
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["SeasonalFoods/SeasonalFoods.csproj", "SeasonalFoods/"]
RUN dotnet restore "SeasonalFoods/SeasonalFoods.csproj"
COPY . .
WORKDIR "/src/SeasonalFoods"
RUN dotnet build "SeasonalFoods.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SeasonalFoods.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SeasonalFoods.dll"]

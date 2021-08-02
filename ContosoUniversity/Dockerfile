FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ContosoUniversaty/ContosoUniversaty.csproj", "ContosoUniversaty/"]
RUN dotnet restore "ContosoUniversaty/ContosoUniversaty.csproj"
COPY . .
WORKDIR "/src/ContosoUniversaty"
RUN dotnet build "ContosoUniversaty.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContosoUniversaty.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContosoUniversaty.dll"]

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MyWebAppUsingDocker/MyWebAppUsingDocker.csproj", "MyWebAppUsingDocker/"]
RUN dotnet restore "MyWebAppUsingDocker/MyWebAppUsingDocker.csproj"
COPY . .
WORKDIR "/src/MyWebAppUsingDocker"
RUN dotnet build "MyWebAppUsingDocker.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MyWebAppUsingDocker.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyWebAppUsingDocker.dll"]
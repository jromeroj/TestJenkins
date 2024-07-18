FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app
COPY *.sln ./
COPY . ./
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime-env
WORKDIR /app
COPY --from=build-env /app/API_Demo/bin/Release/net8.0/*.* .
ENTRYPOINT ["dotnet", "API_Demo.dll"]
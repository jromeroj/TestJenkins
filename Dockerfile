FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

#COPY *.sln ./
#Copiar todo 
COPY . ./
#restaurar las capas
RUN dotnet restore
#Publica la solución
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/aspnet:8.0 
WORKDIR /app
#COPY --from=build-env /app/API_Demo/bin/Release/net8.0/*.* .
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "API_Demo.dll"]
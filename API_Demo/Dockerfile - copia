#####################################################
# Dockerizacion tradicional con build desde Jenkins #
#####################################################

#Descarga la SDK de Docker Hub
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

#Asignacion de nombre del Worker Directory
WORKDIR /app


#Copiar desde la ruta del Release estructura es /"workdir"/bin/Release/"Version_de_sdk_" 
COPY ./app/bin/Release/net8.0 ./

#Construccion de la imagen
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime-env
WORKDIR /app
COPY --from=build-env /app/bin/Release/net8.0/ .

#Asdignacion del entry point
ENTRYPOINT ["dotnet", "API_Demo.dll"]



#############################
# Dockerizacion tradicional #
#############################

#Descarga la SDK de Docker Hub
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

#Asignacion de nombre del Worker Directory
#WORKDIR /app

#Copiar el proyecto y restaurar las dependencias
#COPY *.csproj ./
#RUN dotnet restore

## Copiar los archivos y construye la aplicacio
#COPY . ./
#RUN dotnet publish -c Release -o out

#Consutruccion de una imagen
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime-env
#WORKDIR /app
#COPY --from=build-env /app/out .

#Asignacion de entry Point
#ENTRYPOINT ["dotnet", "API_Demo.dll"]

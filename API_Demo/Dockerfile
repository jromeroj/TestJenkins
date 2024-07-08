###########################################
####### Prepara la imagen de Docker #######
###########################################
FROM mcr.microsoft.com/dotnet/aspnet:8.0. AS build-env 
#Worker Directory
WORKDIR webapp
COPY ./*.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

##################################
##### Build Image for Docker #####
##################################

#FROM mcr.microsoft.com/dotnet/aspnet::8.0. AS runtime-env 
WORKDIR /webapp
COPY --from=build-env /webapp/out .
ENTRYPOINT ["dotnet", "API_Demo.dll"]




#EXPOSE 80
#EXPOSE 7019
#EXPOSE 5211



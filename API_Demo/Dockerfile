###########################################
####### Prepara la imagen de Docker #######
###########################################
FROM mcr.microsoft.com/dotnet/aspnet:lasted 
#Worker Directory
WORKDIR webapp
COPY ./*.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

##################################
##### Build Image for Docker #####
##################################

#FROM mcr.microsoft.com/dotnet/aspnet:lasted
WORKDIR /webapp
COPY --from=build /webapp/out .
ENTRYPOINT ["dotnet", "API_Demo.dll"]




#EXPOSE 80
#EXPOSE 7019
#EXPOSE 5211



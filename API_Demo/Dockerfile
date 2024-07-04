FROM mcr.microsoft.com/dotnet/sdk as build
WORKDIR webapp
EXPOSE 80
EXPOSE 7019
EXPOSE 5211
##### Copia los archivos del proyecto #####
#COPY ./*.csproj ./
#RUN dotnet restore
COPY ./bin/Release/net8.0/API_Demo.dll ./
RUN dotnet restore

#### Copia todo lo demas ####
COPY . .
#RUN dotnet publish - c Release -o out

#### Build Image ####
FROM mcr.microsoft.com/dotnet/sdk
WORKDIR /webapp
#COPY --from=build /webapp/out .
COPY --from=build /webapp/bin/Release/net8.0 .
ENTRYPOINT ["dotnet", "API_Demo.dll"]



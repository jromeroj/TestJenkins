#Start with the base .NET SDK Image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

#Set the working directory inside the container
WORKDIR /app

#Copy the project files and restore the depencies
#COPY *.csproj ./
#RUN dotnet restore

#Copy the remainign files and build the application
COPY ./app/bin/Release/net8.0 ./
#RUN dotnet publish -c Release -o out

#Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime-env
WORKDIR /app
#COPY --from=build-env /app/out .
COPY --from=build-env /app/bin/Release/net8.0/ .

#set entry point 
ENTRYPOINT ["dotnet", "API_Demo.dll"]
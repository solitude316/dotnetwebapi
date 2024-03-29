# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
RUN mkdir Source
COPY *.sln .
COPY Source/Api/*.csproj ./Source/Api/
COPY Source/Api.Test/*.csproj ./Source/Api.Test/
RUN dotnet restore

# copy everything else and build app

COPY Source/Api/. ./Source/Api/
COPY Source/Api.Test/. ./Source/Api.Test/


# Install nuget package
RUN dotnet add Source/Api/Api.csproj package Newtonsoft.Json 
RUN dotnet add Source/Api.Test/Api.Test.csproj package Newtonsoft.Json

RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "Api.dll"]

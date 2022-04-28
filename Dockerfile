#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ResourceServer.csproj", "."]
RUN dotnet restore "./ResourceServer.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ResourceServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ResourceServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ResourceServer.dll"]
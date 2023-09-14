#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Mart_V1/Mart_V1.csproj", "Mart_V1/"]
RUN dotnet restore "Mart_V1/Mart_V1.csproj"
COPY . .
WORKDIR "/src/Mart_V1"
RUN dotnet build "Mart_V1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mart_V1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mart_V1.dll"]
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ReservationAPI/ReservationAPI.csproj", "ReservationAPI/"]
RUN dotnet restore "ReservationAPI/ReservationAPI.csproj"
COPY . .
WORKDIR "/src/ReservationAPI"
RUN dotnet build "ReservationAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReservationAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReservationAPI.dll"]

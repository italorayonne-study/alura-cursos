FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["Alura.Estacionamento/Alura.Estacionamento.csproj", "Alura.Estacionamento/"]
RUN dotnet restore "Alura.Estacionamento/Alura.Estacionamento.csproj"
COPY . .
WORKDIR "/src/Alura.Estacionamento"
RUN dotnet build "Alura.Estacionamento.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Alura.Estacionamento.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Alura.Estacionamento.dll"]

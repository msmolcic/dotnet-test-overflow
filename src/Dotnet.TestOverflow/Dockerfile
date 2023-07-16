FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Dotnet.TestOverflow/Dotnet.TestOverflow.csproj", "Dotnet.TestOverflow/"]
RUN dotnet restore "Dotnet.TestOverflow/Dotnet.TestOverflow.csproj"
COPY . .
WORKDIR "/src/Dotnet.TestOverflow"
RUN dotnet build "Dotnet.TestOverflow.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dotnet.TestOverflow.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dotnet.TestOverflow.dll"]
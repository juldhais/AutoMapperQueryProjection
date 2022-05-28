FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AutoMapperQueryProjection/AutoMapperQueryProjection.csproj", "AutoMapperQueryProjection/"]
RUN dotnet restore "AutoMapperQueryProjection/AutoMapperQueryProjection.csproj"
COPY . .
WORKDIR "/src/AutoMapperQueryProjection"
RUN dotnet build "AutoMapperQueryProjection.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AutoMapperQueryProjection.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AutoMapperQueryProjection.dll"]

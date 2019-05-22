FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine3.9 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine3.9 AS build
WORKDIR /src
COPY ["AppTest/AppTest.csproj", "AppTest/"]
RUN dotnet restore "AppTest/AppTest.csproj"
COPY . .
WORKDIR "/src/AppTest"
RUN dotnet build "AppTest.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AppTest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AppTest.dll"]
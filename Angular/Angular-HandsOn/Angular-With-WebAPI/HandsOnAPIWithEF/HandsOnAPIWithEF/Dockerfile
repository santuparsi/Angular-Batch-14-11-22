#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["HandsOnAPIWithEF/HandsOnAPIWithEF.csproj", "HandsOnAPIWithEF/"]
RUN dotnet restore "HandsOnAPIWithEF/HandsOnAPIWithEF.csproj"
COPY . .
WORKDIR "/src/HandsOnAPIWithEF"
RUN dotnet build "HandsOnAPIWithEF.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HandsOnAPIWithEF.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HandsOnAPIWithEF.dll"]
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY *.sln ./
COPY AeC.Application/*.csproj ./AeC.Application/
COPY AeC.Domain/*.csproj ./AeC.Domain/
COPY AeC.Infra/*.csproj ./AeC.Infra/
COPY AeC.Tests/*.csproj ./AeC.Tests/
RUN dotnet restore

COPY . .
WORKDIR /app/AeC.Application
RUN dotnet build -c Release -o /app/build

WORKDIR /app/AeC.Domain
RUN dotnet build -c Release -o /app/build

WORKDIR /app/AeC.Infra
RUN dotnet build -c Release -o /app/build

WORKDIR /app/AeC.Tests
RUN dotnet build -c Release -o /app/build

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/build .
ENTRYPOINT ["dotnet", "AeC.Application.dll"]

#Dockerfile
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS builder
WORKDIR /src
COPY ./MyServiceDemo2.csproj .
RUN dotnet restore MyServiceDemo2.csproj
COPY . .
RUN dotnet build MyServiceDemo2.csproj -c Debug -o /src/out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim
WORKDIR /app
COPY --from=builder /src/out .
EXPOSE 80
ENTRYPOINT ["dotnet", "MyServiceDemo2.dll"]

#Dockerfile
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS builder
WORKDIR /src
COPY ./MyServiceDemo1.csproj .
RUN dotnet restore MyServiceDemo1.csproj
COPY . .
RUN dotnet build MyServiceDemo1.csproj -c Debug -o /src/out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim
WORKDIR /app
COPY --from=builder /src/out .
EXPOSE 80
ENTRYPOINT ["dotnet", "MyServiceDemo1.dll"]

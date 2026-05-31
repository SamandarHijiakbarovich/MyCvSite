# ───── Build qatlami ─────
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# csproj ni alohida nusxalab restore qilamiz (Docker cache uchun)
COPY ["MyCvSite.csproj", "./"]
RUN dotnet restore "MyCvSite.csproj"

# Qolgan kodni nusxalaymiz va publish qilamiz
COPY . .
RUN dotnet publish "MyCvSite.csproj" -c Release -o /app/publish /p:UseAppHost=false

# ───── Runtime qatlami ─────
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Render PORT environment variable beradi
ENV ASPNETCORE_URLS=http://+:${PORT:-8080}
ENV ASPNETCORE_ENVIRONMENT=Production

EXPOSE 8080
ENTRYPOINT ["dotnet", "MyCvSite.dll"]

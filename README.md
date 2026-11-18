# StorageApi

[![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-Web_API-512BD4?logo=.net&logoColor=white)](https://learn.microsoft.com/aspnet/core/)
[![Swagger](https://img.shields.io/badge/Swagger-OpenAPI-85EA2D?logo=swagger&logoColor=black)](https://swagger.io/tools/swagger-ui/)

A lightweight ASP.NET Core Web API built with .NET 9. The project exposes a weather forecast example and includes OpenAPI/Swagger support in development mode.

## ✨ Features

- 🚀 ASP.NET Core 9 Web API
- 📘 Interactive Swagger / OpenAPI documentation
- 🌦️ Weather forecast REST endpoint
- 🔧 Development and environment-specific configuration
- 🧪 Ready-to-use `.http` request file

## 🖼️ API Preview

> **Screenshot:** Swagger UI will list the available endpoints when the application runs in development mode.

![StorageApi Swagger UI screenshot](docs/screenshots/swagger-ui.png)

## 🛠️ Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- A terminal or IDE such as Visual Studio, Visual Studio Code, or JetBrains Rider

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/1x4x/StorageApi.git
cd StorageApi
```

### 2. Restore dependencies

```bash
dotnet restore
```

### 3. Run the API

```bash
dotnet run
```

When running in the Development environment, open:

- Swagger UI: <http://localhost:5035/swagger>
- API base URL: <http://localhost:5035>
- HTTPS profile: <https://localhost:7090>

## 📡 API Endpoint

### Get weather forecast

```http
GET /weatherforecast/GetWeatherForecast
Accept: application/json
```

Example request:

```bash
curl http://localhost:5035/weatherforecast/GetWeatherForecast
```

Example response:

```json
[
  {
    "date": "2026-11-19",
    "temperatureC": 21,
    "temperatureF": 70,
    "summary": "Warm"
  }
]
```

The endpoint returns five forecast entries with calculated Fahrenheit temperatures and randomly generated summaries.

## 🧪 Using the HTTP File

Open `StorageApi.http` in a compatible editor and run the configured `GET` request. The file targets `http://localhost:5035/weatherforecast/GetWeatherForecast`.

## 📂 Project Structure

```text
StorageApi/
├── Controllers/
│   └── WeatherForecastController.cs  # Weather forecast endpoint
├── Properties/
│   └── launchSettings.json           # Local HTTP and HTTPS profiles
├── Program.cs                        # Application startup and middleware
├── StorageApi.csproj                 # .NET project configuration
├── StorageApi.http                   # Example API request
└── StorageApi.sln                    # Solution file
```

## 🔧 Configuration

Application settings are available in:

- `appsettings.json`
- `appsettings.Development.json`

Environment configuration and launch profiles can be customized in `Properties/launchSettings.json`.

## 🏗️ Build

```bash
dotnet build
```

## 📜 License

No license has been specified for this repository.

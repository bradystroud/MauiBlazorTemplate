# MAUI + Blazor Solution Template

[![Build - Blazor](https://github.com/bradystroud/MauiBlazorTemplate/actions/workflows/build-blazor.yml/badge.svg)](https://github.com/bradystroud/MauiBlazorTemplate/actions/workflows/build-blazor.yml)
[![Build - WebApi](https://github.com/bradystroud/MauiBlazorTemplate/actions/workflows/build-webapi.yml/badge.svg)](https://github.com/bradystroud/MauiBlazorTemplate/actions/workflows/build-webapi.yml)
[![Build - MAUI apps](https://github.com/bradystroud/MauiBlazorTemplate/actions/workflows/build-maui.yml/badge.svg)](https://github.com/bradystroud/MauiBlazorTemplate/actions/workflows/build-maui.yml)
[![Deploy - Blazor](https://github.com/bradystroud/MauiBlazorTemplate/actions/workflows/deploy-blazor.yml/badge.svg)](https://github.com/bradystroud/MauiBlazorTemplate/actions/workflows/deploy-blazor.yml)
[![Deploy - WebApi](https://github.com/bradystroud/MauiBlazorTemplate/actions/workflows/deploy-webapi.yml/badge.svg)](https://github.com/bradystroud/MauiBlazorTemplate/actions/workflows/deploy-webapi.yml)

![.NET 10](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)
![MAUI](https://img.shields.io/badge/MAUI-Blazor%20Hybrid-512BD4?logo=dotnet&logoColor=white)
[![Gitmoji](https://img.shields.io/badge/gitmoji-%20😜%20😍-FFDD67.svg)](https://gitmoji.dev)

A pragmatic starting point for an app that runs on **web, mobile, and desktop** from a single Razor component library — backed by an ASP.NET Core Web API.

> 🏆 **A bit of history:** For years there was no official Microsoft template for sharing UI across MAUI and Blazor Web — this repo filled the gap and was the go-to starting point. Microsoft finally caught up in **.NET 9** with the first-party [`dotnet new maui-blazor-web`](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui-blazor-web-app) template, which is a great choice for greenfield projects. This template still differs in shape (separate ASP.NET Core Web API project + NSwag-generated typed client) and remains useful when you want that split out of the box.

## 🏛 Solution structure

```
📦 MauiBlazor.sln
 ┣ 📂 src
 ┃ ┣ 📂 MauiBlazor.UI
 ┃ ┃ ┣ 📂 MauiBlazor.UI.Core     # Shared Razor components (RCL)
 ┃ ┃ ┣ 📂 MauiBlazor.UI.Mobile   # MAUI Blazor Hybrid host (Android/iOS/Mac/Windows)
 ┃ ┃ ┗ 📂 MauiBlazor.UI.Web      # Blazor WebAssembly host
 ┃ ┣ 📂 MauiBlazor.Shared        # DTOs shared between API and clients
 ┃ ┗ 📂 MauiBlazor.WebApi        # ASP.NET Core Web API + NSwag client gen
```

## 🚀 Quickstart

```bash
# Prereqs: .NET 10 SDK + MAUI workload
dotnet workload install maui

git clone https://github.com/bradystroud/MauiBlazorTemplate.git
cd MauiBlazorTemplate

# Run the API
dotnet run --project src/MauiBlazor.WebApi

# Run the Blazor web app
dotnet run --project src/MauiBlazor.UI/MauiBlazor.UI.Web

# Run the MAUI app (pick a framework)
dotnet build src/MauiBlazor.UI/MauiBlazor.UI.Mobile -f net10.0-maccatalyst
```

## 🧰 Stack

- **.NET 10** — single SDK across all projects
- **MAUI Blazor Hybrid** — native shell, Razor UI
- **Blazor WebAssembly** — same UI in the browser
- **ASP.NET Core Web API** with **NSwag** for OpenAPI + typed client generation
- **GitHub Actions** for CI/CD to Azure Static Web Apps + Azure App Service

## 📖 Background

Read the original write-up: [MAUI Blazor Template on Medium](https://medium.com/@bradystroud/maui-blazor-template-84cb6b8db97).

Feedback and PRs welcome 😊

— Brady

[![Gitmoji](https://img.shields.io/badge/gitmoji-%20😜%20😍-FFDD67.svg?style=flat-square)](https://gitmoji.dev)

# Maui + Blazor Solution Template
Template for MAUI Blazor Applications.

Contains the basic solution structure needed to build an app that can run on the web, mobile and desktop.
I will continue to build and improve this template, so your feedback would be appreciated 😊

## 🏛 Solution structure
```
📦 MauiBlazor.sln
┣ 📂 src
  ┣ 📂 MauiBlazor.UI
    ┣ 📂 MauiBlazor.UI.Core
    ┣ 📂 MauiBlazor.UI.Mobile
    ┣ 📂 MauiBlazor.UI.Web
  ┣ 📂 MauiBlazor.Shared
  ┣ 📂 MauiBlazor.WebApi
```

UI code only needs to be written once - in the MauiBlazor.UI.Core project.
The Web and Mobile projects use this code.
MauiBlazor.Shared contains shared code used by the UI and WebApi projects. 
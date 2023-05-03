---
UID: TP:dynamicdependency
title: Dynamic Dependency API
description: Provides information about the header files for the Dynamic Dependency API.
ms.date: 07/15/2021
ms.keywords: 
ms.topic: conceptual
---

# Dynamic Dependency API

## -description

This API is designed to be used by unpackaged desktop apps to load [framework packages](/windows/apps/desktop/modernize/framework-packages/framework-packages-overview) other than the Windows App SDK framework package. After the specified framework package is loaded by an unpackaged desktop app, the app can call APIs provided by the framework package.

To use the Dynamic Dependency API, you need this header:

 * [msixdynamicdependency.h](../msixdynamicdependency/index.md)

For programming guidance for this technology, see [Use the dynamic dependency API to reference MSIX packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api).

## -remarks

Before you can use the Dynamic Dependency API in an unpackaged desktop app, you must first use the [Bootstrapper API](../_bootstrap/index.md) to load the Windows App SDK framework package. For more information, see [Use the Windows App SDK runtime for apps packaged with external location or unpackaged](/windows/apps/windows-app-sdk/use-windows-app-sdk-run-time).

---
UID: NF:mddbootstrap.MddBootstrapShutdown
tech.root: bootstrap
title: MddBootstrapShutdown
ms.date: 07/15/2021 
targetos: Windows
description: Removes the changes made to the current process by MddBootstrapInitialize. After this function is called, your app can no longer call Windows App SDK APIs.
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: Microsoft.WindowsAppRuntime.Bootstrap.dll
req.header: mddbootstrap.h
req.idl: 
req.include-header: 
req.irql: 
req.kmdf-ver: 
req.lib: Microsoft.WindowsAppRuntime.Bootstrap.lib
req.max-support: 
req.namespace: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.0 Preview 1 or later)
req.target-min-winversvr: 
req.target-type: 
req.type-library: 
req.umdf-ver: 
req.unicode-ansi: 
topic_type:
 - apiref
api_type:
 - HeaderDef
api_location:
 - mddbootstrap.h
api_name:
 - MddBootstrapShutdown
f1_keywords:
 - MddBootstrapShutdown
 - mddbootstrap/MddBootstrapShutdown
dev_langs:
 - c++
---

## -description

Removes the changes made to the current process by [MddBootstrapInitialize](nf-mddbootstrap-mddbootstrapinitialize.md). After this function is called, your app can no longer call Windows App SDK APIs, including the [Dynamic dependency API](../_dynamicdependency/index.md).

## -returns

This function has no return value.

## -remarks

Also see [Reference the Windows App SDK framework package at run time](/windows/apps/windows-app-sdk/reference-framework-package-run-time).

## -see-also

* [Dynamic dependency API](../_dynamicdependency/index.md)
* [Reference the Windows App SDK framework package at run time](/windows/apps/windows-app-sdk/reference-framework-package-run-time)

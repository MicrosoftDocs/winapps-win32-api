---
UID: NA:microsoft.ui.interop
tech.root: uiinterop
title: microsoft.ui.interop
ms.date: 07/28/2021 
targetos: Windows
description: Provides information about the microsoft.ui.interop.h header for the UI Interop API.
prerelease: false
req.assembly: 
req.construct-type: apiset
req.ddi-compliance: 
req.dll: 
req.header: microsoft.ui.interop.h
req.idl: 
req.include-header: 
req.irql: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.namespace: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.0 Preview 1 or later)
req.target-min-winversvr: 
req.target-type: 
req.typenames: 
req.type-library: 
req.umdf-ver: 
req.unicode-ansi: 
topic_type:
 - apiref
api_type:
 - HeaderDef
api_location:
 - microsoft.ui.interop.h
api_name:
 - microsoft.ui.interop
f1_keywords:
 - microsoft.ui.interop
 - microsoft.ui.interop/microsoft.ui.interop
dev_langs:
 - c++
---

## -description

> [!NOTE]
> The `microsoft.ui.interop.h` header has a dependency on `microsoft.ui.h`, which is not shipped as part of the [Windows App SDK](/windows/apps/windows-app-sdk/). You can run [the MIDL compiler](/windows/win32/midl/using-the-midl-compiler-2) (`midl.exe`) on `Microsoft.UI.idl` in order to generate `microsoft.ui.h`. Or just use the functions in the [winrt/Microsoft.ui.interop.h](../winrt-microsoft.ui.interop/index.md) header instead.

**C#**. For C# desktop application developers, the interop functions in this header are wrapped by the methods of the [Microsoft.UI.Win32Interop](/windows/apps/winui/winui3/cs-interop-apis/microsoft.ui/microsoft.ui.win32interop) class.

This header is used by the [UI Interop API](../_uiinterop/index.md).

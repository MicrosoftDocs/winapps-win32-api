---
UID: NF:winrt-microsoft.ui.interop.GetWindowFromWindowId
tech.root: uiinterop
title: GetWindowFromWindowId (winrt)
ms.date: 02/02/2022
targetos: Windows
description: Gets the window handle that corresponds to the specified *windowId*, if the provided *windowId* is valid and the system has an **HWND** that represents the window.
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: winrt-microsoft.ui.interop.h
req.idl: 
req.include-header: 
req.irql: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.namespace: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.0 Stable or later)
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
 - winrt-microsoft.ui.interop.h
api_name:
 - GetWindowFromWindowId
f1_keywords:
 - GetWindowFromWindowId
 - winrt-microsoft.ui.interop/GetWindowFromWindowId
dev_langs:
 - c++
helpviewer_keywords:
 - GetWindowFromWindowId
---

## -description

Gets the window handle that corresponds to the specified *windowId*, if the provided *windowId* is valid and the system has an **HWND** that represents the window.

> [!NOTE]
> This API is declare in the `Microsoft.UI.Interop.h` header file that's in the Windows App SDK's `\include\winrt` folder.

## -parameters

### -param windowId

Type: **const [WindowId](/windows/winui/api/microsoft.ui.windowid) \&**

The identifier for the window.

## -returns

Type: **[HWND](/windows/win32/winprog/windows-data-types)**

The window handle that corresponds to the specified *windowId*, if the provided *windowId* is valid and the system has an `HWND` that represents the window. Otherwise, `null`.

## -remarks

## -see-also

[Manage app windows](/windows/apps/windows-app-sdk/windowing/windowing-overview)

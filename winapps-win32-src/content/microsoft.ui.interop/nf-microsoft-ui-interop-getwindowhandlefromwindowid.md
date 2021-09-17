---
UID: NF:microsoft.ui.interop.GetWindowHandleFromWindowId
tech.root: windowing
title: GetWindowHandleFromWindowId
ms.date: 09/03/2021
targetos: Windows
description: Gets the window handle that corresponds to the specified *windowId*, if the provided *windowId* is valid and the system has an `HWND` that represents the window.
prerelease: false
req.assembly: 
req.construct-type: function
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
 - GetWindowHandleFromWindowId
f1_keywords:
 - GetWindowHandleFromWindowId
 - microsoft.ui.interop/GetWindowHandleFromWindowId
dev_langs:
 - c++
---

## -description

Gets the window handle that corresponds to the specified *windowId*, if the provided *windowId* is valid and the system has an `HWND` that represents the window.

## -parameters

### -param windowId

Type: **[WindowId](/windows/winui/api/microsoft.ui.windowid)**

The identifier for the window.

### -param result

Type: **[HWND](/windows/win32/winprog/windows-data-types)**

The window handle that corresponds to the specified *windowId*, if the provided *windowId* is valid and the system has an `HWND` that represents the window. Otherwise, `null`.

## -returns

Type: **[HRESULT](/windows/win32/winprog/windows-data-types)**

Returns **S_OK** if the function succeeds. Otherwise, returns a value that indicates the error.

## -remarks

## -see-also

[Manage app windows](/windows/apps/windows-app-sdk/windowing/windowing-overview)
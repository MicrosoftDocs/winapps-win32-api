---
UID: NF:microsoft.ui.xaml.window.IWindowNative.get_WindowHandle
title: IWindowNative::get_WindowHandle
description: Retrieves the window handle (**[HWND](/windows/win32/winprog/windows-data-types)**) of the window represented by the object that implements [IWindowNative](/windows/windows-app-sdk/api/win32/microsoft.ui.xaml.window/nn-microsoft-ui-xaml-window-iwindownative).
ms.date: 03/05/2025
tech.root: winuicominterop
targetos: Windows
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: microsoft.ui.xaml.window.h
req.idl: 
req.include-header: 
req.irql: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.namespace: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 0.5 or later)
req.target-min-winversvr: 
req.target-type: 
req.type-library: 
req.umdf-ver: 
req.unicode-ansi: 
topic_type:
 - apiref
api_type:
 - COM
api_location:
 - microsoft.ui.xaml.window.h
api_name:
 - IWindowNative::get_WindowHandle
f1_keywords:
 - IWindowNative::get_WindowHandle
 - microsoft.ui.xaml.window/IWindowNative::get_WindowHandle
dev_langs:
 - c++
---

## -description

Retrieves the window handle (**[HWND](/windows/win32/winprog/windows-data-types)**) of the window represented by the object that implements [IWindowNative](/windows/windows-app-sdk/api/win32/microsoft.ui.xaml.window/nn-microsoft-ui-xaml-window-iwindownative).

For more info, and code examples, see [Retrieve a window handle (HWND)](/windows/apps/develop/ui-input/retrieve-hwnd).

## -parameters

### -param hWnd

The window handle (**HWND**).

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

## -see-also

* [IWindowNative](/windows/windows-app-sdk/api/win32/microsoft.ui.xaml.window/nn-microsoft-ui-xaml-window-iwindownative)
* [Retrieve a window handle (HWND)](/windows/apps/develop/ui-input/retrieve-hwnd)

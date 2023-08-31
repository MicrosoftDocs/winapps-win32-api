---
UID: NF:winrt-microsoft.ui.interop.GetMonitorFromDisplayId
tech.root: uiinterop
title: GetMonitorFromDisplayId (winrt)
ms.date: 02/02/2022
targetos: Windows
description: Gets the display monitor handle that corresponds to the specified *displayId*, if the provided *displayId* is valid and the system has an **HMONITOR** that represents the display monitor.
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
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.0 or later)
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
 - GetMonitorFromDisplayId
f1_keywords:
 - GetMonitorFromDisplayId
 - winrt-microsoft.ui.interop/GetMonitorFromDisplayId
dev_langs:
 - c++
helpviewer_keywords:
 - GetMonitorFromDisplayId
---

## -description

Gets the display monitor handle that corresponds to the specified *displayId*, if the provided *displayId* is valid and the system has an **HMONITOR** that represents the display monitor.

> [!NOTE]
> This API is declare in the `Microsoft.UI.Interop.h` header file that's in the Windows App SDK's `\include\winrt` folder.

**C#**. For C# desktop application developers, the interop functions in this header are wrapped by the methods of the [Microsoft.UI.Win32Interop](/windows/apps/winui/winui3/cs-interop-apis/microsoft.ui/microsoft.ui.win32interop) class.

## -parameters

### -param displayId

Type: **const [DisplayId](/windows/windows-app-sdk/api/winrt/microsoft.ui.displayid) \&**

The identifier for the display.

## -returns

Type: **[HMONITOR](/windows/win32/winprog/windows-data-types)**

The display monitor handle that corresponds to the specified *displayId*, if the provided *displayId* is valid and the system has an `HMONITOR` that represents the display monitor. Otherwise, `null`.

## -remarks

## -see-also

[Manage app windows](/windows/apps/windows-app-sdk/windowing/windowing-overview)

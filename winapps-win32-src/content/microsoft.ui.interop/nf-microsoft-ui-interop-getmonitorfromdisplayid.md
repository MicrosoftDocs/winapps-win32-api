---
UID: NF:microsoft.ui.interop.GetMonitorFromDisplayId
tech.root: uiinterop
title: GetMonitorFromDisplayId
ms.date: 09/29/2021
targetos: Windows
description: Gets the display monitor handle that corresponds to the specified *displayId*, if the provided *displayId* is valid and the system has an `HMONITOR` that represents the display monitor.
prerelease: true
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
 - GetMonitorFromDisplayId
f1_keywords:
 - GetMonitorFromDisplayId
 - microsoft.ui.interop/GetMonitorFromDisplayId
dev_langs:
 - c++
---

## -description

Gets the display monitor handle that corresponds to the specified *displayId*, if the provided *displayId* is valid and the system has an `HMONITOR` that represents the display monitor.

## -parameters

### -param displayId

Type: **[DisplayId](/windows/winui/api/microsoft.ui.displayid)**

The identifier for the display.

### -param hmonitor

Type: **[HMONITOR](/windows/win32/winprog/windows-data-types)**

The display monitor handle that corresponds to the specified *displayId*, if the provided *displayId* is valid and the system has an `HMONITOR` that represents the display monitor. Otherwise, `null`.

## -returns

Type: **[HRESULT](/windows/win32/winprog/windows-data-types)**

Returns **S_OK** if the function succeeds. Otherwise, returns a value that indicates the error.

## -remarks

## -see-also

[Manage app windows](/windows/apps/windows-app-sdk/windowing/windowing-overview)
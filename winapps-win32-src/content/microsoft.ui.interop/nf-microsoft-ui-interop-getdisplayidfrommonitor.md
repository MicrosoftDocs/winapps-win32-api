---
UID: NF:microsoft.ui.interop.GetDisplayIdFromMonitor
tech.root: uiinterop
title: GetDisplayIdFromMonitor
ms.date: 09/29/2021
targetos: Windows
description: Gets the `DisplayId` that corresponds to the specified *hmonitor*, if the provided `hmonitor` is valid.
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
 - GetDisplayIdFromMonitor
f1_keywords:
 - GetDisplayIdFromMonitor
 - microsoft.ui.interop/GetDisplayIdFromMonitor
dev_langs:
 - c++
---

## -description

Gets the `DisplayId` that corresponds to the specified *hmonitor*, if the provided `hmonitor` is valid.

## -parameters

### -param hmonitor

Type: **[HMONITOR](/windows/win32/winprog/windows-data-types)**

The handle of the display monitor for which to get the `DisplayId`.

### -param displayId

Type: **[DisplayId](/windows/winui/api/microsoft.ui.displayid)**

The display monitor identifier that corresponds to the specified *hmonitor*, if the provided *hmonitor* is valid. Otherwise, `null`.

## -returns

Type: **[HRESULT](/windows/win32/winprog/windows-data-types)**

Returns **S_OK** if the function succeeds. Otherwise, returns a value that indicates the error.

## -remarks

## -see-also

[Manage app windows](/windows/apps/windows-app-sdk/windowing/windowing-overview)
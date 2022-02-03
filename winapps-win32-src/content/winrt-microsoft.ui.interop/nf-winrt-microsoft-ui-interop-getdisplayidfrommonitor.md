---
UID: NF:winrt-microsoft.ui.interop.GetDisplayIdFromMonitor
tech.root: uiinterop
title: GetDisplayIdFromMonitor (winrt)
ms.date: 02/02/2022
targetos: Windows
description: Gets the `DisplayId` that corresponds to the specified *hmonitor*, if the provided **HMONITOR** is valid.
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
 - GetDisplayIdFromMonitor
f1_keywords:
 - GetDisplayIdFromMonitor
 - winrt-microsoft.ui.interop/GetDisplayIdFromMonitor
dev_langs:
 - c++
helpviewer_keywords:
 - GetDisplayIdFromMonitor
---

## -description

Gets the `DisplayId` that corresponds to the specified *hmonitor*, if the provided **HMONITOR** is valid.

> [!NOTE]
> This API is declare in the `Microsoft.UI.Interop.h` header file that's in the Windows App SDK's `\include\winrt` folder.

## -parameters

### -param hmonitor

Type: **const [HMONITOR](/windows/win32/winprog/windows-data-types) \&**

The handle of the display monitor for which to get the `DisplayId`.

## -returns

Type: **[DisplayId](/windows/winui/api/microsoft.ui.displayid)**

The display monitor identifier that corresponds to the specified *hmonitor*, if the provided *hmonitor* is valid. Otherwise, `null`.

## -remarks

## -see-also

[Manage app windows](/windows/apps/windows-app-sdk/windowing/windowing-overview)

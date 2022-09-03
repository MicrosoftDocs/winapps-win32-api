---
UID: NF:microsoft.ui.interop.GetDisplayIdFromMonitor
tech.root: uiinterop
title: GetDisplayIdFromMonitor
ms.date: 09/02/2022
targetos: Windows
description: Gets the [DisplayId](/windows/windows-app-sdk/api/winrt/microsoft.ui.displayid) that corresponds to the specified [HMONITOR](/windows/win32/winprog/windows-data-types), if the *hmonitor* argument is valid.
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

Gets the [DisplayId](/windows/windows-app-sdk/api/winrt/microsoft.ui.displayid) that corresponds to the specified [HMONITOR](/windows/win32/winprog/windows-data-types), if the *hmonitor* argument is valid.

> [!NOTE]
> The `microsoft.ui.interop.h` header has a dependency on `microsoft.ui.h`, which is not shipped as part of the [Windows App SDK](/windows/apps/windows-app-sdk/). You can run [the MIDL compiler](/windows/win32/midl/using-the-midl-compiler-2) (`midl.exe`) on `Microsoft.UI.idl` in order to generate `microsoft.ui.h`. Or just use the functions in the [winrt/Microsoft.ui.interop.h](../winrt-microsoft.ui.interop/index.md) header instead.

**C#**. For C# desktop application developers, the interop functions in this header are wrapped by the methods of the [Microsoft.UI.Win32Interop](/windows/apps/winui/winui3/cs-interop-apis/microsoft.ui/microsoft.ui.win32interop) class.

## -parameters

### -param hmonitor

Type: **[HMONITOR](/windows/win32/winprog/windows-data-types)**

The handle of the display monitor for which to get the [DisplayId](/windows/windows-app-sdk/api/winrt/microsoft.ui.displayid).

### -param displayId

Type: **[DisplayId](/windows/windows-app-sdk/api/winrt/microsoft.ui.displayid)**

The display monitor identifier that corresponds to *hmonitor*, if *hmonitor* is valid. Otherwise, `null`.

## -returns

Type: **[HRESULT](/windows/win32/winprog/windows-data-types)**

Returns **S_OK** if the function succeeds. Otherwise, returns a value that indicates the error.

## -remarks

## -see-also

[Manage app windows](/windows/apps/windows-app-sdk/windowing/windowing-overview)

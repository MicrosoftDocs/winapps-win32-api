---
UID: NF:winrt-microsoft.ui.interop.GetIconFromIconId
tech.root: uiinterop
title: GetIconFromIconId (winrt)
ms.date: 02/02/2022
targetos: Windows
description: Gets the icon handle that corresponds to the specified *iconId*, if the provided *iconId* is valid and the system has an `HICON` that represents the icon.
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
 - GetIconFromIconId
f1_keywords:
 - GetIconFromIconId
 - winrt-microsoft.ui.interop/GetIconFromIconId
dev_langs:
 - c++
helpviewer_keywords:
 - GetIconFromIconId
---

## -description

Gets the icon handle that corresponds to the specified *iconId*, if the provided *iconId* is valid and the system has an `HICON` that represents the icon.

> [!NOTE]
> This API is declare in the `Microsoft.UI.Interop.h` header file that's in the Windows App SDK's `\include\winrt` folder.

**C#**. For C# desktop application developers, the interop functions in this header are wrapped by the methods of the [Microsoft.UI.Win32Interop](/windows/apps/winui/winui3/cs-interop-apis/microsoft.ui/microsoft.ui.win32interop) class.

## -parameters

### -param iconId

Type: **const [IconId](/windows/windows-app-sdk/api/winrt/microsoft.ui.iconid) \&**

The identifier for the icon.

## -returns

Type: **[HICON](/windows/win32/winprog/windows-data-types)**

The icon handle that corresponds to the specified *iconId*, if the provided *iconId* is valid and the system has an `HICON` that represents the icon. Otherwise, `null`.

## -remarks

## -see-also

[Manage app windows](/windows/apps/windows-app-sdk/windowing/windowing-overview)

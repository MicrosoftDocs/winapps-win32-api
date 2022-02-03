---
UID: NF:winrt-microsoft.ui.interop.GetIconIdFromIcon
tech.root: uiinterop
title: GetIconIdFromIcon (winrt)
ms.date: 02/02/2022
targetos: Windows
description: Gets the `IconId` that corresponds to the specified *hicon*, if the provided **HICON** is valid.
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
 - GetIconIdFromIcon
f1_keywords:
 - GetIconIdFromIcon
 - winrt-microsoft.ui.interop/GetIconIdFromIcon
dev_langs:
 - c++
helpviewer_keywords:
 - GetIconIdFromIcon
---

## -description

Gets the `IconId` that corresponds to the specified *hicon*, if the provided **HICON** is valid.

> [!NOTE]
> This API is declare in the `Microsoft.UI.Interop.h` header file that's in the Windows App SDK's `\include\winrt` folder.

## -parameters

### -param hicon

Type: **const [HICON](/windows/win32/winprog/windows-data-types) \&**

The handle of the icon for which to get the `IconId`.

## -returns

Type: **[IconId](/windows/winui/api/microsoft.ui.iconid)**

The icon identifier that corresponds to the specified *hicon*, if the provided *hicon* is valid. Otherwise, `null`.

## -remarks

## -see-also

[Manage app windows](/windows/apps/windows-app-sdk/windowing/windowing-overview)

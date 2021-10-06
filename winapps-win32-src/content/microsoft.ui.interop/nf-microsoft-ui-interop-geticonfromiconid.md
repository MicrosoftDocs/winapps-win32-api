---
UID: NF:microsoft.ui.interop.GetIconFromIconId
tech.root: uiinterop
title: GetIconFromIconId
ms.date: 09/29/2021
targetos: Windows
description: Gets the icon handle that corresponds to the specified *iconId*, if the provided *iconId* is valid and the system has an `HICON` that represents the icon.
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
 - GetIconFromIconId
f1_keywords:
 - GetIconFromIconId
 - microsoft.ui.interop/GetIconFromIconId
dev_langs:
 - c++
---

## -description

Gets the icon handle that corresponds to the specified *iconId*, if the provided *iconId* is valid and the system has an `HICON` that represents the icon.

## -parameters

### -param iconId

Type: **[IconId](/windows/winui/api/microsoft.ui.iconid)**

The identifier for the icon.

### -param hicon

Type: **[HICON](/windows/win32/winprog/windows-data-types)**

The icon handle that corresponds to the specified *iconId*, if the provided *iconId* is valid and the system has an `HICON` that represents the icon. Otherwise, `null`.

## -returns

Type: **[HRESULT](/windows/win32/winprog/windows-data-types)**

Returns **S_OK** if the function succeeds. Otherwise, returns a value that indicates the error.

## -remarks

## -see-also

[Manage app windows](/windows/apps/windows-app-sdk/windowing/windowing-overview)
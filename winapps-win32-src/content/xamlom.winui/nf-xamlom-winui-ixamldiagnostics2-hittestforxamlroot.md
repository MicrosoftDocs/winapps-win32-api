---
UID: NF:xamlom.winui.IXamlDiagnostics2.HitTestForXamlRoot
tech.root: winuicominterop
title: IXamlDiagnostics2::HitTestForXamlRoot
ms.date: 04/11/2022
targetos: Windows
description: Gets all elements in the visual tree that fall within the specified rectangle.
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: xamlom.winui.h
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
 - COM
api_location:
 - xamlom.winui.h
api_name:
 - IXamlDiagnostics2::HitTestForXamlRoot
f1_keywords:
 - IXamlDiagnostics2::HitTestForXamlRoot
 - xamlom.winui/IXamlDiagnostics2::HitTestForXamlRoot
dev_langs:
 - c++
helpviewer_keywords:
 - HitTestForXamlRoot
---

## -description

Gets all elements in the visual tree that fall within the specified rectangle.

## -parameters

### -param instanceHandle

A handle to the XamlRoot instance.

### -param rect

The area to hit test.

### -param pCount

The number of elements found.

### -param ppInstanceHandles

An array containing all found elements.

## -returns

If this method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

## -remarks

This method performs hit testing for the XamlRoot passed in as `instanceHandle`, within the bounds of `rect`.  Returns the number of elements hit in `pCount` and the elements themselves in `ppInstanceHandles`.  This method replaces [IXamlDiagnostics::HitTest](/windows/win32/api/xamlom/nf-xamlom-ixamldiagnostics-hittest), which assumes there is only one main window and only performs hit testing within it.

## -see-also


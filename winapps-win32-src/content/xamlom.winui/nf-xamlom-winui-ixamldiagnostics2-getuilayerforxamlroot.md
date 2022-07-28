---
UID: NF:xamlom.winui.IXamlDiagnostics2.GetUiLayerForXamlRoot
tech.root: winuicominterop
title: IXamlDiagnostics2::GetUiLayerForXamlRoot
ms.date: 04/11/2022
targetos: Windows
description: Gets the visual diagnostics root that can be used to draw on for highlighting elements in the tree.
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
 - IXamlDiagnostics2::GetUiLayerForXamlRoot
f1_keywords:
 - IXamlDiagnostics2::GetUiLayerForXamlRoot
 - xamlom.winui/IXamlDiagnostics2::GetUiLayerForXamlRoot
dev_langs:
 - c++
helpviewer_keywords:
 - GetUiLayerForXamlRoot
---

## -description

Gets the visual diagnostics root that can be used to draw on for highlighting elements in the tree.

## -parameters

### -param instanceHandle

A handle to the XamlRoot instance.

### -param ppLayer

The visual diagnostics root.

## -returns

If this method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

## -remarks

This method gets the UI layer associated with the XamlRoot passed in as the `instanceHandle` parameter.  This method replaces [IXamlDiagnostics::GetUiLayer](/windows/win32/api/xamlom/nf-xamlom-ixamldiagnostics-getuilayer), which assumes there is only one main window and only returns its UI layer.

## -see-also


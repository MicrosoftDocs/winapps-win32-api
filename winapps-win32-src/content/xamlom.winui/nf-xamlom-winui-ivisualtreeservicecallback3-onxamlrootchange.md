---
UID: NF:xamlom.winui.IVisualTreeServiceCallback3.OnXamlRootChange
tech.root: winuicominterop
title: IVisualTreeServiceCallback3::OnXamlRootChange
ms.date: 04/12/2022
targetos: Windows
description: Communicates when a XamlRoot root is added or removed.
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
 - IVisualTreeServiceCallback3::OnXamlRootChange
f1_keywords:
 - IVisualTreeServiceCallback3::OnXamlRootChange
 - xamlom.winui/IVisualTreeServiceCallback3::OnXamlRootChange
dev_langs:
 - c++
helpviewer_keywords:
 - OnXamlRootChange
---

## -description

Communicates when a XamlRoot root is added or removed.

## -parameters

### -param root

The XamlRoot.

### -param mutationType

Specifies whether the root is being added or removed.

## -returns

If this method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

## -remarks

This callback method is invoked when a XamlRoot root is added or removed. The `mutationType` parameter specifies whether the root is being added or removed.

## -see-also


---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IFindReferenceTargetsCallback.FoundTrackerTarget
tech.root: winuicominterop
title: IFindReferenceTargetsCallback::FoundTrackerTarget
ms.date: 09/10/2021
targetos: Windows
description: 
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: microsoft.ui.xaml.hosting.referencetracker.h
req.idl: 
req.include-header: 
req.irql: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.namespace: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 0.5 or later)
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
 - microsoft.ui.xaml.hosting.referencetracker.h
api_name:
 - IFindReferenceTargetsCallback::FoundTrackerTarget
f1_keywords:
 - IFindReferenceTargetsCallback::FoundTrackerTarget
 - microsoft.ui.xaml.hosting.referencetracker/IFindReferenceTargetsCallback::FoundTrackerTarget
dev_langs:
 - c++
---

## -description

Called whenever a XAML object reference tracker target is found.

## -parameters

### -param target [in]

A XAML object reference tracker target instance found by the XAML object reference tracker manager.

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -see-also

---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTrackerManager.ReferenceTrackingCompleted
tech.root: winuicominterop
title: IReferenceTrackerManager::ReferenceTrackingCompleted
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
 - IReferenceTrackerManager::ReferenceTrackingCompleted
f1_keywords:
 - IReferenceTrackerManager::ReferenceTrackingCompleted
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTrackerManager::ReferenceTrackingCompleted
dev_langs:
 - c++
---

## -description

Indicates that a garbage collection system has finished with its collection process (at this point, XAML unblocks threads attempting to update tracked references).

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

## -see-also

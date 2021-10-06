---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTrackerManager.ReferenceTrackingStarted
tech.root: winuicominterop
title: IReferenceTrackerManager::ReferenceTrackingStarted
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
 - IReferenceTrackerManager::ReferenceTrackingStarted
f1_keywords:
 - IReferenceTrackerManager::ReferenceTrackingStarted
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTrackerManager::ReferenceTrackingStarted
dev_langs:
 - c++
---

## -description

Indicates that a garbage collector is performing a collection; when the collection is finished, the garbage collector calls [FindTrackerTargetsCompleted](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetrackermanager-findtrackertargetscompleted.md).

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

When this method is called, XAML blocks all threads where it is attempting to update tracked references.  Between calls to **ReferenceTrackingStarted** and [ReferenceTrackingCompleted](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetrackermanager-referencetrackingcompleted.md), XAML does not make any calls to reference tracker target objects other than [Peg](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetrackertarget-peg.md) and [Unpeg](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetrackertarget-unpeg.md).

## -see-also

---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTrackerManager.FindTrackerTargetsCompleted
tech.root: winuicominterop
title: IReferenceTrackerManager::FindTrackerTargetsCompleted
ms.date: 09/10/2021
targetos: Windows
description: Indicates that a garbage collection system has finished making all the calls it needs to IReferenceTracker::FindTrackerTargets (by this time, XAML has pegged all reference tracker targets that it wants to protect).
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
 - IReferenceTrackerManager::FindTrackerTargetsCompleted
f1_keywords:
 - IReferenceTrackerManager::FindTrackerTargetsCompleted
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTrackerManager::FindTrackerTargetsCompleted
dev_langs:
 - c++
---

## -description

Indicates that a garbage collection system has finished making all the calls it needs to [IReferenceTracker::FindTrackerTargets](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetracker-findtrackertargets.md) (by this time, XAML has pegged all reference tracker targets that it wants to protect).

## -parameters

### -param findFailed [in]

True, if failed allocations are included. Otherwise, false.

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

This marks the end of the foreground garbage collection. At this point background garbage collection will run on a separate thread.

## -see-also

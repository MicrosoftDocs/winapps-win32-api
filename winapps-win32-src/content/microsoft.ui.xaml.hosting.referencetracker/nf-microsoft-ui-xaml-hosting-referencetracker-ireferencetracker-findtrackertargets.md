---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTracker.FindTrackerTargets
tech.root: winuicominterop
title: IReferenceTracker::FindTrackerTargets
ms.date: 09/10/2021
targetos: Windows
description: Finds the reference tracker targets that are reachable from a reference tracker source.
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
 - IReferenceTracker::FindTrackerTargets
f1_keywords:
 - IReferenceTracker::FindTrackerTargets
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTracker::FindTrackerTargets
dev_langs:
 - c++
---

## -description

Finds the reference tracker targets that are reachable from a reference tracker source; must be called by a garbage collector between calls to [ReferenceTrackingStarted](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetrackermanager-referencetrackingstarted.md) and [FindTrackerTargetsCompleted](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetrackermanager-findtrackertargetscompleted.md).

## -parameters

### -param callback [in]

The application-defined callback function.

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -see-also

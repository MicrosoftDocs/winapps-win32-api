---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTracker.DisconnectFromTrackerSource
tech.root: winuicominterop
title: IReferenceTracker::DisconnectFromTrackerSource
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
 - IReferenceTracker::DisconnectFromTrackerSource
f1_keywords:
 - IReferenceTracker::DisconnectFromTrackerSource
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTracker::DisconnectFromTrackerSource
dev_langs:
 - c++
---

## -description

Indicates that a reference tracker source has stopped tracking a reference tracker.

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

Calling this method does not indicate that the tracker source has released all COM references on the reference tracker.

This method is called by the CLR during garbage collection when a runtime-callable wrapper is collected, but the XAML object does not get released until it is processed by the finalizer thread.

## -see-also

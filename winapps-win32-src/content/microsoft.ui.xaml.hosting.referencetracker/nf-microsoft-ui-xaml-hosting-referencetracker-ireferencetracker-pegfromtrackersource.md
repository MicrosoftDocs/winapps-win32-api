---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTracker.PegFromTrackerSource
tech.root: winuicominterop
title: IReferenceTracker::PegFromTrackerSource
ms.date: 09/10/2021
targetos: Windows
description: Indicates that a tracker source is unable to protected a reference tracker object.
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
 - IReferenceTracker::PegFromTrackerSource
f1_keywords:
 - IReferenceTracker::PegFromTrackerSource
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTracker::PegFromTrackerSource
dev_langs:
 - c++
---

## -description

Indicates that a tracker source is unable to protected a reference tracker object.

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

This method is called by the CLR when it is returning a XAML object as an **out** parameter argument.

## -see-also

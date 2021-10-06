---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTracker.ConnectFromTrackerSource
tech.root: winuicominterop
title: IReferenceTracker::ConnectFromTrackerSource
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
 - IReferenceTracker::ConnectFromTrackerSource
f1_keywords:
 - IReferenceTracker::ConnectFromTrackerSource
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTracker::ConnectFromTrackerSource
dev_langs:
 - c++
---

## -description

Indicates that a reference tracker source has created its first COM reference on a reference tracker object.

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

An example of when this method might be called is when a runtime-callable wrapper is created to a XAML object, such as when a XAML object is returned as an **out** parameter argument.

## -see-also

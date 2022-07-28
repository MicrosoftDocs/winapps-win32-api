---
UID: NN:microsoft.ui.xaml.hosting.referencetracker.IReferenceTrackerManager
tech.root: winuicominterop
title: IReferenceTrackerManager
ms.date: 09/10/2021
targetos: Windows
description: Defines the interface for  a XAML object reference manager. Implement this interface to manage instances of IReferenceTracker on XAML objects.
prerelease: false
req.assembly: 
req.construct-type: iface
req.ddi-compliance: 
req.header: microsoft.ui.xaml.hosting.referencetracker.h
req.idl: 
req.include-header: 
req.max-support: 
req.namespace: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 0.5 or later)
req.target-min-winversvr: 
req.target-type: 
req.unicode-ansi: 
topic_type:
 - apiref
api_type:
 - COM
api_location:
 - microsoft.ui.xaml.hosting.referencetracker.h
api_name:
 - IReferenceTrackerManager
f1_keywords:
 - IReferenceTrackerManager
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTrackerManager
dev_langs:
 - c++
---

## -description

Defines the interface for  a XAML object reference manager. Implement this interface to manage instances of [IReferenceTracker](nn-microsoft-ui-xaml-hosting-referencetracker-ireferencetracker.md) on XAML objects.

## -inheritance

The **IReferenceTrackerManager** interface inherits from the [IUnknown](/windows/desktop/api/unknwn/nn-unknwn-iunknown) interface.

## -remarks

Obtain a reference to an implementation of this interface by calling [GetReferenceTrackerManager](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetracker-getreferencetrackermanager.md) on a XAML object that implements [IReferenceTracker](nn-microsoft-ui-xaml-hosting-referencetracker-ireferencetracker.md).

There is only one instance of **IReferenceTrackerManager** for a process, and it may be called from any thread.

## -see-also

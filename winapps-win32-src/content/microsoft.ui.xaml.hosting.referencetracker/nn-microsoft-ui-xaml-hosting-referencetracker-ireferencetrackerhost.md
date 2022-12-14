---
UID: NN:microsoft.ui.xaml.hosting.referencetracker.IReferenceTrackerHost
tech.root: winuicominterop
title: IReferenceTrackerHost
ms.date: 09/10/2021
targetos: Windows
description: Defines an interface that provides the global services used by the garbage collection (GC) system used by the XAML framework.
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
 - IReferenceTrackerHost
f1_keywords:
 - IReferenceTrackerHost
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTrackerHost
dev_langs:
 - c++
---

## -description

Defines an interface that provides the global services used by the garbage collection (GC) system used by the XAML framework.

## -inheritance

The **IReferenceTrackerHost** interface inherits from the [IUnknown](/windows/desktop/api/unknwn/nn-unknwn-iunknown) interface.

## -remarks

An implementation of this interface must be registered with the XAML framework by passing it to the [SetReferenceTrackerHost](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetrackermanager-setreferencetrackerhost.md) method.

## -see-also

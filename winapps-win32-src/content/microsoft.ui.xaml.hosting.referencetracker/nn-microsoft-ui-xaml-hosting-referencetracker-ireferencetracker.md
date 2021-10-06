---
UID: NN:microsoft.ui.xaml.hosting.referencetracker.IReferenceTracker
tech.root: winuicominterop
title: IReferenceTracker
ms.date: 09/10/2021
targetos: Windows
description: Defines the interface implemented by the XAML framework for managing XAML object references.
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
 - IReferenceTracker
f1_keywords:
 - IReferenceTracker
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTracker
dev_langs:
 - c++
---

## -description

Defines the interface implemented by the XAML framework for managing XAML object references.

## -inheritance

The **IReferenceTracker** interface inherits from the [IUnknown](/windows/desktop/api/unknwn/nn-unknwn-iunknown) interface. **IReferenceTracker** also has these types of members:

## -remarks

This interface is implemented by most XAML framework objects. It is not defined as **agile**, nor does it marshal across apartments. Use it only from within the apartment of the XAML object that implements it.

## -see-also

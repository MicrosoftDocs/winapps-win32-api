---
UID: NN:microsoft.ui.xaml.hosting.referencetracker.IFindReferenceTargetsCallback
tech.root: winuicominterop
title: IFindReferenceTargetsCallback
ms.date: 09/10/2021
targetos: Windows
description: 
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
 - IFindReferenceTargetsCallback
f1_keywords:
 - IFindReferenceTargetsCallback
 - microsoft.ui.xaml.hosting.referencetracker/IFindReferenceTargetsCallback
dev_langs:
 - c++
---

## -description

Defines the interface for callbacks from [FindTrackerTargets](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetracker-findtrackertargets.md). The implementation of this interface must pass any [IReferenceTrackerTarget](nn-microsoft-ui-xaml-hosting-referencetracker-ireferencetrackertarget.md) instances it finds to the [FoundTrackerTarget](nf-microsoft-ui-xaml-hosting-referencetracker-ifindreferencetargetscallback-foundtrackertarget.md) method.

## -inheritance

The **IFindReferenceTargetsCallback** interface inherits from the [IUnknown](/windows/desktop/api/unknwn/nn-unknwn-iunknown) interface. **IFindReferenceTargetsCallback** also has these types of members:

## -remarks

## -see-also

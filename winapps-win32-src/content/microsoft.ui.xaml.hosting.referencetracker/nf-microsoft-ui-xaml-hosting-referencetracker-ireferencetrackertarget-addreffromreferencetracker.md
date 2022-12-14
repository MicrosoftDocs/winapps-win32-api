---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTrackerTarget.AddRefFromReferenceTracker
tech.root: winuicominterop
title: IReferenceTrackerTarget::AddRefFromReferenceTracker
ms.date: 09/10/2021
targetos: Windows
description: Indicates that the reference tracker is returning the target XAML object(s) from previous calls to FindTrackerTargets.
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
 - IReferenceTrackerTarget::AddRefFromReferenceTracker
f1_keywords:
 - IReferenceTrackerTarget::AddRefFromReferenceTracker
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTrackerTarget::AddRefFromReferenceTracker
dev_langs:
 - c++
---

## -description

Indicates that the reference tracker is returning the target XAML object(s) from previous calls to [FindTrackerTargets](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetracker-findtrackertargets.md).

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

The reference is held by the reference tracker object in lieu of **IUnknown::AddRef**.

## -see-also

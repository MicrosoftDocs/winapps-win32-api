---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTrackerHost.GetTrackerTarget
tech.root: winuicominterop
title: IReferenceTrackerHost::GetTrackerTarget
ms.date: 09/10/2021
targetos: Windows
description: Requests the host provide a reference tracker target that references a reference tracker source. This tracker target then controls the lifetime of the tracker source.
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
 - IReferenceTrackerHost::GetTrackerTarget
f1_keywords:
 - IReferenceTrackerHost::GetTrackerTarget
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTrackerHost::GetTrackerTarget
dev_langs:
 - c++
---

## -description

Requests the host provide a reference tracker target that references a reference tracker source. This tracker target then controls the lifetime of the tracker source.

## -parameters

### -param unknown

The reference tracker source.

### -param newReference

The reference tracker target.

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

For example, after calling this method, calling [Peg](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetrackertarget-peg.md) on the tracker target will prevent the tracker source from being collected.

## -see-also

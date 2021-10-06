---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTrackerTarget.Unpeg
tech.root: winuicominterop
title: IReferenceTrackerTarget::Unpeg
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
 - IReferenceTrackerTarget::Unpeg
f1_keywords:
 - IReferenceTrackerTarget::Unpeg
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTrackerTarget::Unpeg
dev_langs:
 - c++
---

## -description

Marks that the reference tracker target is no longer in use by the XAML framework and can be collected.

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

You do not need to have parity between calls to [Peg](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetrackertarget-peg.md) and **Unpeg**. A single call to **Unpeg** will remove the marker set in all previous calls to **Peg**.

## -see-also

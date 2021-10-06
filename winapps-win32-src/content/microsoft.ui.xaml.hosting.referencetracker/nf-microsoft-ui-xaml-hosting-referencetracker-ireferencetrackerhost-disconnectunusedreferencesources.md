---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTrackerHost.DisconnectUnusedReferenceSources
tech.root: winuicominterop
title: IReferenceTrackerHost::DisconnectUnusedReferenceSources
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
 - IReferenceTrackerHost::DisconnectUnusedReferenceSources
f1_keywords:
 - IReferenceTrackerHost::DisconnectUnusedReferenceSources
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTrackerHost::DisconnectUnusedReferenceSources
dev_langs:
 - c++
---

## -description

Requests that the host perform garbage collection and remove all unnecessary reference sources.

## -parameters

### -param options [in]

0 or 1.

1 indicates that an application suspend is in progress.

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

This method is expected to potentially cause the reference source to call [DisconnectFromTrackerSource](nf-microsoft-ui-xaml-hosting-referencetracker-ireferencetracker-disconnectfromtrackersource.md), but it is not necessary to call **IUnknown::Release** immediately on the tracker source.  In the CLR, this call triggers a garbage collection, but not a **WaitForPendingFinalizers**.  When flags is one, the garbage collection is executed in the **GCCollectionMode.Optimized** state.

## -see-also

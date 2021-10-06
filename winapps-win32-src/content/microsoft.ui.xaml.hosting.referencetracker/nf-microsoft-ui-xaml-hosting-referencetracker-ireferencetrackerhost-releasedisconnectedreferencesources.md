---
UID: NF:microsoft.ui.xaml.hosting.referencetracker.IReferenceTrackerHost.ReleaseDisconnectedReferenceSources
tech.root: winuicominterop
title: IReferenceTrackerHost::ReleaseDisconnectedReferenceSources
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
 - IReferenceTrackerHost::ReleaseDisconnectedReferenceSources
f1_keywords:
 - IReferenceTrackerHost::ReleaseDisconnectedReferenceSources
 - microsoft.ui.xaml.hosting.referencetracker/IReferenceTrackerHost::ReleaseDisconnectedReferenceSources
dev_langs:
 - c++
---

## -description

Requests that the host call **IUnknown::Release** on any reference tracker objects that have been disconnected by a reference source.

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

It is not necessary for the **Release** calls to come in on the same thread.

## -see-also

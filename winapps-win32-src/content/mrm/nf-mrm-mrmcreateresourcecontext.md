---
UID: NF:mrm.MrmCreateResourceContext
tech.root: mrtcore 
title: MrmCreateResourceContext
ms.date: 05/18/2021 
targetos: Windows
description: Creates a new **ResourceContext**.
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: mrm.h
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
 - HeaderDef
api_location:
 - mrm.h
api_name:
 - MrmCreateResourceContext
f1_keywords:
 - MrmCreateResourceContext
 - mrm/MrmCreateResourceContext
dev_langs:
 - c++
---

## -description

Creates a new **ResourceContext**.

## -parameters

### -param resourceManager

The **ResourceManager** that will create the **ResourceContext**.

### -param resourceContext

Contains the created **ResourceContext** if the call was successful.

## -returns

**HRESULT** that indicates the result of the operation.

## -remarks

**ResourceContext** must be freed with [MrmDestroyResourceContext](nf-mrm-mrmdestroyresourcecontext.md).

## -see-also

- [MrmDestroyResourceContext](nf-mrm-mrmdestroyresourcecontext.md)

---
UID: NF:mrm.MrmLoadStringOrEmbeddedFromResourceUri
tech.root: mrtcore 
title: MrmLoadStringOrEmbeddedFromResourceUri
ms.date: 05/18/2021 
targetos: Windows
description: Loads a resource of any **MrmType** from the specified URI.
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
 - MrmLoadStringOrEmbeddedFromResourceUri
f1_keywords:
 - MrmLoadStringOrEmbeddedFromResourceUri
 - mrm/MrmLoadStringOrEmbeddedFromResourceUri
dev_langs:
 - c++
---


## -description

Loads a resource of any [MrmType](ne-mrm-mrmtype.md) from the specified URI.

## -parameters

### -param resourceManager

The **ResourceManager**.

### -param resourceContext

The **ResourceContext**. Uses the default context if null.

### -param resourceUri

The URI of the resource to load.

### -param resourceType

The [MrmType](ne-mrm-mrmtype.md) of the resource to be loaded.

### -param resourceString

Contains the resource string if the call was successful and resourceType was either [MrmType](ne-mrm-mrmtype.md).String or [MrmType](ne-mrm-mrmtype.md).Path.

Resource data must be freed by calling [MrmFreeResource](nf-mrm-mrmfreeresource.md).

### -param data

Contains the resource data if the call was successful and resourceType was [MrmType](ne-mrm-mrmtype.md).Embedded.

Resource data must be freed by calling [MrmFreeResource](nf-mrm-mrmfreeresource.md).

## -returns

**HRESULT** that indicates the result of the operation.

## -remarks

## -see-also

- [MrmFreeResource](nf-mrm-mrmfreeresource.md)

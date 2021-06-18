---
UID: NF:mrm.MrmAllocateBuffer
tech.root: mrtcore 
title: MrmAllocateBuffer
ms.date: 05/18/2021 
targetos: Windows
description: Allocates a resource buffer.
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
 - MrmAllocateBuffer
f1_keywords:
 - MrmAllocateBuffer
 - mrm/MrmAllocateBuffer
dev_langs:
 - c++
---

## -description

Allocates a resource buffer.

## -parameters

### -param size

Buffer size in bytes.

## -returns

Pointer to the allocated buffer.

## -remarks

Buffer must be freed with [MrmFreeResource](nf-mrm-mrmfreeresource.md).

## -see-also

- [MrmFreeResource](nf-mrm-mrmfreeresource.md)

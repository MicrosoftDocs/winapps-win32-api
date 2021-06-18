---
UID: NF:mrm.MrmFreeResource
tech.root: mrtcore 
title: MrmFreeResource
ms.date: 05/18/2021 
targetos: Windows
description: Frees a buffer that was allocated with **MrmAllocateBuffer**.
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
 - MrmFreeResource
f1_keywords:
 - MrmFreeResource
 - mrm/MrmFreeResource
dev_langs:
 - c++
---

## -description

Frees a buffer that was allocated with [MrmAllocateBuffer](nf-mrm-mrmallocatebuffer.md).

## -parameters

### -param resource

The resource buffer which will be freed.

## -remarks

Do not use this method to free arrays of names or values, such as those created by [MrmGetAllQualifierNames](nf-mrm-mrmgetallqualifiernames.md). For these types of arrays, use  [MrmFreeQualifierNamesOrValues](nf-mrm-mrmfreequalifiernamesorvalues.md) instead.

## -see-also

- [MrmAllocateBuffer](nf-mrm-mrmallocatebuffer.md)
-[MrmFreeQualifierNamesOrValues](nf-mrm-mrmfreequalifiernamesorvalues.md)

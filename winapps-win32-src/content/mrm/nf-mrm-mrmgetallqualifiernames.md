---
UID: NF:mrm.MrmGetAllQualifierNames
tech.root: mrtcore 
title: MrmGetAllQualifierNames
ms.date: 05/18/2021 
targetos: Windows
description: Gets all qualifier names for certain context.
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
 - MrmGetAllQualifierNames
f1_keywords:
 - MrmGetAllQualifierNames
 - mrm/MrmGetAllQualifierNames
dev_langs:
 - c++
---

## -description

Gets all qualifier names for certain context.

## -parameters

### -param resourceContext

The **ResourceContext** that contains the qualifier names.

### -param size

The number of qualifier names.

### -param names

Will contain the array of qualifier names if the call was successful.

This array should be freed using [MrmFreeQualifierNamesOrValues](nf-mrm-mrmfreequalifiernamesorvalues.md).

## -returns

**HRESULT** that indicates the result of the operation.

## -remarks

## -see-also

- [MrmFreeQualifierNamesOrValues](nf-mrm-mrmfreequalifiernamesorvalues.md).

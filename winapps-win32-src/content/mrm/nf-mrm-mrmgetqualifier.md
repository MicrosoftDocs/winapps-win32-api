---
UID: NF:mrm.MrmGetQualifier
tech.root: mrtcore 
title: MrmGetQualifier
ms.date: 05/18/2021 
targetos: Windows
description: Gets a qualifier value.
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
 - MrmGetQualifier
f1_keywords:
 - MrmGetQualifier
 - mrm/MrmGetQualifier
dev_langs:
 - c++
---

## -description

Gets a qualifier value.

## -parameters

### -param resourceContext

The **ResourceContext** that contains the value.

### -param qualifierName

The name of the value.

### -param qualifierValue

Contains the qualifier value if the call was successful.

## -returns

**HRESULT** that indicates the result of the operation.

## -remarks

## -see-also

- [MrmSetQualifier](nf-mrm-mrmsetqualifier.md)

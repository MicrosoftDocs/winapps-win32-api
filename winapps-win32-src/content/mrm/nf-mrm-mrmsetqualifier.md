---
UID: NF:mrm.MrmSetQualifier
tech.root: mrtcore 
title: MrmSetQualifier
ms.date: 05/18/2021 
targetos: Windows
description: Sets a resource qualifier value.
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
 - MrmSetQualifier
f1_keywords:
 - MrmSetQualifier
 - mrm/MrmSetQualifier
dev_langs:
 - c++
---

## -description

Sets a resource qualifier value.

## -parameters

### -param resourceContext

The **ResourceContext**.

### -param qualifierName

The qualifier name.

### -param qualifierValue

The qualifier value to be set.

## -returns

**HRESULT** that indicates the result of the operation.

## -remarks

## -see-also

-[MrmGetQualifier](nf-mrm-mrmgetqualifier.md)

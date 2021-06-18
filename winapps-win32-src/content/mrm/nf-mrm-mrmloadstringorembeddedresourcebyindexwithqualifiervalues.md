---
UID: NF:mrm.MrmLoadStringOrEmbeddedResourceByIndexWithQualifierValues
tech.root: mrtcore 
title: MrmLoadStringOrEmbeddedResourceByIndexWithQualifierValues
ms.date: 05/18/2021 
targetos: Windows
description: Loads a resource of any **MrmType**, along with that resource's qualifier values.
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
 - MrmLoadStringOrEmbeddedResourceByIndexWithQualifierValues
f1_keywords:
 - MrmLoadStringOrEmbeddedResourceByIndexWithQualifierValues
 - mrm/MrmLoadStringOrEmbeddedResourceByIndexWithQualifierValues
dev_langs:
 - c++
---

## -description

Loads a resource of any [MrmType](ne-mrm-mrmtype.md), along with that resource's qualifier values.

## -parameters

### -param resourceManager

The **ResourceManager**

### -param resourceContext

The **ResourceContext**. Uses the default context if null.

### -param resourceMap

The **ResourceMap**. Uses root if null.

### -param index

The index of the desired resource within the **ResourceMap**.

### -param resourceType

The [MrmType](ne-mrm-mrmtype.md) of the resource to be loaded.

### -param resourceName

Contains the name of the loaded resource if the call was successful.

Resource name must be freed by calling [MrmFreeResource](nf-mrm-mrmfreeresource.md).

### -param resourceString

Contains the resource string if the call was successful and resourceType was either [MrmType](ne-mrm-mrmtype.md).String or [MrmType](ne-mrm-mrmtype.md).Path.

Resource data must be freed by calling [MrmFreeResource](nf-mrm-mrmfreeresource.md).

### -param data

Contains the resource data if the call was successful and resourceType was [MrmType](ne-mrm-mrmtype.md).Embedded.

Resource data must be freed by calling [MrmFreeResource](nf-mrm-mrmfreeresource.md).

### -param qualifierCount

The number of qualifier names.

### -param qualifierNames

Will contain an array of qualifier names if the call was successful.

This array should be freed using [MrmFreeQualifierNamesOrValues](nf-mrm-mrmfreequalifiernamesorvalues.md).

### -param qualifierValues

Will contain an array of qualifier values if the call was successful.

This array should be freed using [MrmFreeQualifierNamesOrValues](nf-mrm-mrmfreequalifiernamesorvalues.md).

## -returns

**HRESULT** that indicates the result of the operation.

## -remarks

## -see-also

- [MrmFreeQualifierNamesOrValues](nf-mrm-mrmfreequalifiernamesorvalues.md)
- [MrmFreeResource](nf-mrm-mrmfreeresource.md)

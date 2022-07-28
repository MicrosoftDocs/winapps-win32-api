---
UID: NF:mrm.MrmGetResourceCount
tech.root: mrtcore 
title: MrmGetResourceCount
ms.date: 05/18/2021 
targetos: Windows
description: Gets the number of resources contained in a **ResourceMap**.
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
 - MrmGetResourceCount
f1_keywords:
 - MrmGetResourceCount
 - mrm/MrmGetResourceCount
dev_langs:
 - c++
---

## -description

Gets the number of resources contained in a **ResourceMap**.

## -parameters

### -param resourceManager

The **ResourceManager** that contains the **ResourceMap**.

### -param resourceMap

The **ResourceMap** that contains the resources.

### -param count

Contains the number of resources in the **ResourceMap** if the call was successful.

## -returns

**HRESULT** that indicates the result of the operation.

## -remarks

## -see-also

---
UID: NF:mrm.MrmGetChildResourceMap
tech.root: mrtcore 
title: MrmGetChildResourceMap
ms.date: 05/18/2021 
targetos: Windows
description: Gets the child resource map.
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
 - MrmGetChildResourceMap
f1_keywords:
 - MrmGetChildResourceMap
 - mrm/MrmGetChildResourceMap
dev_langs:
 - c++
---

## -description

Gets the child resource map.

## -parameters

### -param resourceManager

The **ResourceManager** that contains the child **ResourceMap**.

### -param resourceMap

The parent **ResourceMap**.

### -param childResourceMapName

The name of the child **ResourceMap**.

### -param childResourceMap

Will contain the child **ResourceMap** if the call was successful.

## -returns

**HRESULT** that indicates the result of the operation.

## -remarks

## -see-also

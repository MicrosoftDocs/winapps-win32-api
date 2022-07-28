---
UID: NF:mrm.MrmCreateResourceManager
tech.root: mrtcore 
title: MrmCreateResourceManager
ms.date: 05/18/2021 
targetos: Windows
description: Creates a new **ResourceManager**.
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
 - MrmCreateResourceManager
f1_keywords:
 - MrmCreateResourceManager
 - mrm/MrmCreateResourceManager
dev_langs:
 - c++
---

## -description

Creates a new **ResourceManager**.

## -parameters

### -param priFileName

The filename of the resource file the new **ResourceManager** will use.

### -param resourceManager

Contains the created **ResourceManager** if the call was successful.

## -returns

**HRESULT** that indicates the result of the operation.

## -remarks

**ResourceManager** must be freed with [MrmDestroyResourceManager](nf-mrm-mrmdestroyresourcemanager.md).

## -see-also

- [MrmDestroyResourceManager](nf-mrm-mrmdestroyresourcemanager.md)

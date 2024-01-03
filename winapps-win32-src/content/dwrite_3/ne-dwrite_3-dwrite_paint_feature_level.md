---
UID: NE:dwrite_3.DWRITE_PAINT_FEATURE_LEVEL
tech.root: dwritecore
title: DWRITE_PAINT_FEATURE_LEVEL
ms.date: 
targetos: Windows
description: 
prerelease: false
req.construct-type: enumeration
req.ddi-compliance: 
req.header: dwrite_3.h
req.include-header: 
req.kmdf-ver: 
req.max-support: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.2 or later)
req.target-min-winversvr: 
req.target-type: 
req.typenames: 
req.umdf-ver: 
topic_type:
 - apiref
api_type:
 - HeaderDef
api_location:
 - dwrite_3.h
api_name:
 - DWRITE_PAINT_FEATURE_LEVEL
f1_keywords:
 - DWRITE_PAINT_FEATURE_LEVEL
 - dwrite_3/DWRITE_PAINT_FEATURE_LEVEL
dev_langs:
 - c++
helpviewer_keywords:
 - DWRITE_PAINT_FEATURE_LEVEL
---

## -description

Defines constants that specify known feature levels for use with the [IDWritePaintReader](./nn-dwrite_3-idwritepaintreader) interface and related APIs. A feature level represents a level of functionality. For example, it determines what [DWRITE_PAINT_TYPE](./ne-dwrite_3-dwrite_paint_type.md) values might be returned.

## -enum-fields

### -field DWRITE_PAINT_FEATURE_LEVEL_NONE

No paint API support.

### -field DWRITE_PAINT_FEATURE_LEVEL_COLR_V0

Specifies a level of functionality corresponding to OpenType COLR version 0.

### -field DWRITE_PAINT_FEATURE_LEVEL_COLR_V1

Specifies a level of functionality corresponding to OpenType COLR version 1.

## -remarks

For info about which paint types are required for each feature level, see the [DWRITE_PAINT_TYPE](./ne-dwrite_3-dwrite_paint_type.md) enumeration.

## -see-also

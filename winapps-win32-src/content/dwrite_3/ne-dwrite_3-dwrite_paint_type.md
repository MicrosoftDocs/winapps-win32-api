---
UID: NE:dwrite_3.DWRITE_PAINT_TYPE
tech.root: dwritecore
title: DWRITE_PAINT_TYPE
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
 - DWRITE_PAINT_TYPE
f1_keywords:
 - DWRITE_PAINT_TYPE
 - dwrite_3/DWRITE_PAINT_TYPE
dev_langs:
 - c++
helpviewer_keywords:
 - DWRITE_PAINT_TYPE
---

## -description

Defines constants that specify a type of paint element in a color glyph. A color glyph's visual representation is defined by a tree of paint elements. A paint element's properties are specified by a [DWRITE_PAINT_ELEMENT](./ns-dwrite_3-dwrite_paint_element.md) structure, which combines a paint type an a union.

## -enum-fields

### -field DWRITE_PAINT_TYPE_NONE

Specifies no rendering action. Can be returned for color feature levels greater than or equal to [DWRITE_PAINT_FEATURE_LEVEL_COLR_V0](ne-dwrite_3-dwrite_paint_feature_level.md).

### -field DWRITE_PAINT_TYPE_LAYERS

Specifies a rendering action of rendering the child paint elements in bottom-up order. Can be returned for color feature levels greater than or equal to [DWRITE_PAINT_FEATURE_LEVEL_COLR_V0](ne-dwrite_3-dwrite_paint_feature_level.md).

### -field DWRITE_PAINT_TYPE_SOLID_GLYPH

Specifies a rendering action of filling the specified glyph shape with the specified color. Can be returned for color feature levels greater than or equal to [DWRITE_PAINT_FEATURE_LEVEL_COLR_V0](ne-dwrite_3-dwrite_paint_feature_level.md).

### -field DWRITE_PAINT_TYPE_SOLID

Specifies a rendering action of filling the current clip with the specified color. Can be returned for color feature levels greater than or equal to [DWRITE_PAINT_FEATURE_LEVEL_COLR_V1](ne-dwrite_3-dwrite_paint_feature_level.md).

### -field DWRITE_PAINT_TYPE_LINEAR_GRADIENT

Specifies a rendering action of filling the current clip with the specified gradient. Can be returned for color feature levels greater than or equal to [DWRITE_PAINT_FEATURE_LEVEL_COLR_V1](ne-dwrite_3-dwrite_paint_feature_level.md).

### -field DWRITE_PAINT_TYPE_RADIAL_GRADIENT

Specifies a rendering action of filling the current clip with the specified gradient. Can be returned for color feature levels greater than or equal to [DWRITE_PAINT_FEATURE_LEVEL_COLR_V1](ne-dwrite_3-dwrite_paint_feature_level.md).

### -field DWRITE_PAINT_TYPE_SWEEP_GRADIENT

Specifies a rendering action of filling the current clip with the specified gradient. Can be returned for color feature levels greater than or equal to [DWRITE_PAINT_FEATURE_LEVEL_COLR_V1](ne-dwrite_3-dwrite_paint_feature_level.md).

### -field DWRITE_PAINT_TYPE_GLYPH

Specifies a rendering action of filling the specified glyph shape with child paint element. Can be returned for color feature levels greater than or equal to [DWRITE_PAINT_FEATURE_LEVEL_COLR_V1](ne-dwrite_3-dwrite_paint_feature_level.md).

### -field DWRITE_PAINT_TYPE_COLOR_GLYPH

Specifies a rendering action of rendering the child paint element. Can be returned for color feature levels greater than or equal to [DWRITE_PAINT_FEATURE_LEVEL_COLR_V1](ne-dwrite_3-dwrite_paint_feature_level.md).

### -field DWRITE_PAINT_TYPE_TRANSFORM

Specifies a rendering action of rendering the child paint element with the specified transform. Can be returned for color feature levels greater than or equal to [DWRITE_PAINT_FEATURE_LEVEL_COLR_V1](ne-dwrite_3-dwrite_paint_feature_level.md).

### -field DWRITE_PAINT_TYPE_COMPOSITE

Specifies a rendering action of rendering the two child paint elements and compose them using the specified composite mode. Can be returned for color feature levels greater than or equal to [DWRITE_PAINT_FEATURE_LEVEL_COLR_V1](ne-dwrite_3-dwrite_paint_feature_level.md).

## -remarks

For more info about each paint type, see the [DWRITE_PAINT_ELEMENT](./ns-dwrite_3-dwrite_paint_element.md) structure.

## -see-also

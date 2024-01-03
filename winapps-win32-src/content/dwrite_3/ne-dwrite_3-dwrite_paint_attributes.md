---
UID: NE:dwrite_3.DWRITE_PAINT_ATTRIBUTES
tech.root: dwritecore
title: DWRITE_PAINT_ATTRIBUTES
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
 - DWRITE_PAINT_ATTRIBUTES
f1_keywords:
 - DWRITE_PAINT_ATTRIBUTES
 - dwrite_3/DWRITE_PAINT_ATTRIBUTES
dev_langs:
 - c++
helpviewer_keywords:
 - DWRITE_PAINT_ATTRIBUTES
---

## -description

Defines constants that specify (as combinable flags) attributes of a color glyph, or of specific color values in a color glyph.

## -enum-fields

### -field DWRITE_PAINT_ATTRIBUTES_NONE:0

Specifies no attribute.

### -field DWRITE_PAINT_ATTRIBUTES_USES_PALETTE:0x01

Specifies that the color value (or any color value in the glyph) comes from the font's color palette. This means that the appearance might depend on the current palette index, which might be important to clients that cache color glyphs.

### -field DWRITE_PAINT_ATTRIBUTES_USES_TEXT_COLOR:0x02

Specifies that the color value (or any color value in the glyph) comes from the client-specified text color. This means the appearance might depend on the text color, which might be important to clients that cache color glyphs.

## -remarks

## -see-also

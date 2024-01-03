---
UID: NS:dwrite_3.DWRITE_PAINT_COLOR
tech.root: dwritecore
title: DWRITE_PAINT_COLOR
ms.date: 
targetos: Windows
description: 
prerelease: false
req.construct-type: structure
req.ddi-compliance: 
req.dll: 
req.header: dwrite_3.h
req.include-header: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.2 or later)
req.target-min-winversvr: 
req.target-type: 
req.typenames: 
req.umdf-ver: 
req.unicode-ansi: 
topic_type:
 - apiref
api_type:
 - HeaderDef
api_location:
 - dwrite_3.h
api_name:
 - DWRITE_PAINT_COLOR
f1_keywords:
 - DWRITE_PAINT_COLOR
 - dwrite_3/DWRITE_PAINT_COLOR
dev_langs:
 - c++
helpviewer_keywords:
 - DWRITE_PAINT_COLOR
---

## -description

Represents a color in a color glyph.

## -struct-fields

### -field value

Type: **[DWRITE_COLOR_F](/windows/win32/directwrite/dwrite-color-f)**

Color value (not premultiplied). See the *colorAttributes* member for information about how the color is determined.

### -field paletteEntryIndex

Type: **[UINT16](/windows/win32/winprog/windows-data-types)**

If the *colorAttributes* member is set to **DWRITE_PAINT_ATTRIBUTES_USES_PALETTE**, then this member is the index of a palette entry in the selected color palette. Otherwise, this member is **DWRITE_NO_PALETTE_INDEX** (0xFFFF).

### -field alphaMultiplier

Type: **float**

Specifies an alpha value multiplier in the range 0 to 1 that was used to compute the color value. Color glyph descriptions can include alpha values to be multiplied with the alpha values of palette entries.

### -field colorAttributes

Type: **[DWRITE_PAINT_ATTRIBUTES](./ne-dwrite_3-dwrite_paint_attributes.md)**

Specifies how the color value is determined. If this member is **DWRITE_PAINT_ATTRIBUTES_USES_PALETTE**, then the color value is determined by getting the color at *paletteEntryIndex* in the current color palette. The color's alpha value is then multiplied by *alphaMultiplier*. If a font has multiple color palettes, then you can set the current color palette using the [IDWritePaintReader::SetColorPaletteIndex](./nf-dwrite_3-idwritepaintreader-setcolorpaletteindex.md) method. A client that uses a custom palette can use the *paletteEntryIndex* and *alphaMultiplier* methods to compute the color. If this member's value is **DWRITE_PAINT_ATTRIBUTES_USES_TEXT_COLOR**, then the color value is equal to the text foreground color, which can be set using the [IDWritePaintReader::SetTextColor](./nf-dwrite_3-idwritepaintreader-settextcolor.md) method.

## -remarks

## -see-also

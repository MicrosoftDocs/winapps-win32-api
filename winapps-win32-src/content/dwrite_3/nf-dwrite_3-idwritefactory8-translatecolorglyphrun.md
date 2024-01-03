---
UID: NF:dwrite_3.IDWriteFactory8.TranslateColorGlyphRun
tech.root: dwritecore
title: IDWriteFactory8::TranslateColorGlyphRun
ms.date: 
targetos: Windows
description: 
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: dwrite_3.h
req.idl: 
req.include-header: 
req.irql: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.namespace: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.2 or later)
req.target-min-winversvr: 
req.target-type: 
req.type-library: 
req.umdf-ver: 
req.unicode-ansi: 
topic_type:
 - apiref
api_type:
 - COM
api_location:
 - dwrite_3.h
api_name:
 - IDWriteFactory8::TranslateColorGlyphRun
f1_keywords:
 - IDWriteFactory8::TranslateColorGlyphRun
 - dwrite_3/IDWriteFactory8::TranslateColorGlyphRun
dev_langs:
 - c++
helpviewer_keywords:
 - TranslateColorGlyphRun
---

## -description

Translates a glyph run to a sequence of color glyph runs, which can be rendered to produce a color representation of the original "base" run. Adds a new *paintFeatureLevel* parameter, but is otherwise identical to [IDWriteFactory4::TranslateColorGlyphRun](./nf-dwrite_3-idwritefactory4-translatecolorglyphrun.md).

## -parameters

### -param baselineOrigin

Type: **[D2D1_POINT_2F](/windows/win32/direct2d/d2d1-point-2f)**

Horizontal and vertical origin of the base glyph run in pre-transform coordinates.

### -param glyphRun

Type: \_In\_ **[DWRITE_GLYPH_RUN](/windows/win32/api/dwrite/ns-dwrite-dwrite_glyph_run) const\***

Pointer to the original "base" glyph run.

### -param glyphRunDescription

Type: \_In\_opt\_ **[DWRITE_GLYPH_RUN_DESCRIPTION](/windows/win32/api/dwrite/ns-dwrite-dwrite_glyph_run_description) const\***

Optional glyph run description.

### -param desiredGlyphImageFormats

Type: **[DWRITE_GLYPH_IMAGE_FORMATS](/windows/win32/api/dcommon/ne-dcommon-dwrite_glyph_image_formats)**

The data formats that the method should split the runs into.

### -param paintFeatureLevel

Type: **[DWRITE_PAINT_FEATURE_LEVEL](./ne-dwrite_3-dwrite_paint_feature_level.md)**

The paint feature level supported by the caller. Used when *desiredGlyphImageFormats* includes **DWRITE_GLYPH_IMAGE_FORMATS_COLR_PAINT_TREE**. For more info, see [DWRITE_PAINT_FEATURE_LEVEL](./ne-dwrite_3-dwrite_paint_feature_level.md).

### -param measuringMode

Type: **[DWRITE_MEASURING_MODE](/windows/win32/api/dcommon/ne-dcommon-dwrite_measuring_mode)**

The measuring mode, which is needed to compute the origins of each glyph.

### -param worldAndDpiTransform

Type: \_In\_opt\_ **[DWRITE_MATRIX](/windows/win32/api/dwrite/ns-dwrite-dwrite_matrix) const\***

Matrix converting from the client's coordinate space to device coordinates (pixels)&mdash;that is, the world transform multiplied by any DPI scaling.

### -param colorPaletteIndex

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Zero-based index of the color palette to use. Valid indices are less than the number of palettes in the font, as returned by [IDWriteFontFace2::GetColorPaletteCount](../dwrite_2/nf-dwrite_2-idwritefontface2-getcolorpalettecount).

### -param colorEnumerator

Type: \_COM_Outptr\_ **[IDWriteColorGlyphRunEnumerator1](./nn-dwrite_3-idwritecolorglyphrunenumerator1.md) \*\***

If the function succeeds, receives a pointer to an enumerator object that can be used to obtain the color glyph runs. If the base run has no color glyphs, then the output pointer is NULL, and the method returns **DWRITE_E_NOCOLOR**.

## -returns

Returns **DWRITE_E_NOCOLOR** if the font has no color information, or if the glyph run doesn't contain any color glyphs, or if the specified color palette index is out of range. In those cases, the client should render the original glyph run. Otherwise, returns a standard HRESULT error code.

## -remarks

Calling [IDWriteFactory2::TranslateColorGlyphRun](../dwrite_2/nf-dwrite_2-idwritefactory2-translatecolorglyphrun.md) is equivalent to calling **IDWriteFactory2::TranslateColorGlyphRun**, and passing **DWRITE_GLYPH_IMAGE_FORMATS_TRUETYPE**|**CFF**|**COLR** in *desiredGlyphImageFormats*.

## -see-also

* [IDWriteFactory8](./nn-dwrite_3-idwritefactory8.md)

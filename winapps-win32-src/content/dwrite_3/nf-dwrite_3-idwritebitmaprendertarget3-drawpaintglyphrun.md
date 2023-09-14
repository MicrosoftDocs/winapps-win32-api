---
UID: NF:dwrite_3.IDWriteBitmapRenderTarget3.DrawPaintGlyphRun
tech.root: dwritecore
title: IDWriteBitmapRenderTarget3::DrawPaintGlyphRun
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
 - IDWriteBitmapRenderTarget3::DrawPaintGlyphRun
f1_keywords:
 - IDWriteBitmapRenderTarget3::DrawPaintGlyphRun
 - dwrite_3/IDWriteBitmapRenderTarget3::DrawPaintGlyphRun
dev_langs:
 - c++
helpviewer_keywords:
 - DrawPaintGlyphRun
---

## -description

Draws a glyph run in a "paint" image format returned by [IDWriteColorGlyphRunEnumerator1](./nn-dwrite_3-idwritecolorglyphrunenumerator1.md).

## -parameters

### -param baselineOriginX

Type: **[FLOAT](/windows/win32/winprog/windows-data-types)**

X-coordinate of the baseline.

### -param baselineOriginY

Type: **[FLOAT](/windows/win32/winprog/windows-data-types)**

Y-coordinate of the baseline.

### -param measuringMode

Type: **[DWRITE_MEASURING_MODE](/windows/win32/api/dcommon/ne-dcommon-dwrite_measuring_mode)**

Specifies measuring mode for positioning glyphs in the run.

### -param glyphRun

Type: \_In\_ **[DWRITE_GLYPH_RUN](/windows/win32/api/dwrite/ns-dwrite-dwrite_glyph_run) const\***

The glyph run to draw.

### -param glyphImageFormat

Type: **[DWRITE_GLYPH_IMAGE_FORMATS](/windows/win32/api/dcommon/ne-dcommon-dwrite_glyph_image_formats)**

The image format of the color glyph run, as returned by [IDWriteColorGlyphRunEnumerator1](./nn-dwrite_3-idwritecolorglyphrunenumerator1.md). This must be one of the "paint" image formats.

### -param textColor

Type: **[COLORREF](/windows/win32/gdi/colorref)**

Foreground color of the text, used in cases where a color glyph uses the text color.

### -param colorPaletteIndex

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Zero-based index of the font-defined color palette to use.

### -param blackBoxRect

Type: \_Out\_opt\_ **[RECT](/windows/win32/api/windef/ns-windef-rect) \***

Optional rectangle that receives the bounding box (in pixels, not DIPs) of all the pixels affected by drawing the glyph run. The black box rectangle might extend beyond the dimensions of the bitmap.

## -returns

A standard **HRESULT** error code.

## -remarks

## -see-also

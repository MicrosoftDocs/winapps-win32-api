---
UID: NF:dwrite_3.IDWritePaintReader.SetCurrentGlyph(UINT32,DWRITE_PAINT_ELEMENT,D2D_RECT_F,DWRITE_PAINT_ATTRIBUTES)
tech.root: dwritecore
title: IDWritePaintReader::SetCurrentGlyph
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
 - IDWritePaintReader::SetCurrentGlyph
f1_keywords:
 - IDWritePaintReader::SetCurrentGlyph
 - dwrite_3/IDWritePaintReader::SetCurrentGlyph
dev_langs:
 - c++
helpviewer_keywords:
 - SetCurrentGlyph
---

## -description

Sets the current glyph, and positions the reader on the root paint element of the selected glyph's visual tree. This method is an inline overload of [SetCurrentGlyph](./nf-dwrite_3-idwritepaintreader-setcurrentglyph(uint32_dwrite_paint_element_uint32_d2d_rect_f_dwrite_paint_attributes).md), in which *structSize* is implied.

## -parameters

### -param glyphIndex

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Glyph index to get the color glyph representation for.

### -param paintElement

Type: \_Out\_writes\_bytes\_\(structSize\) **[DWRITE_PAINT_ELEMENT](./ns-dwrite_3-dwrite_paint_element.md) \***

Receives information about the root paint element of the glyph's visual tree.

### -param clipBox

Type: \_Out\_ **[D2D_RECT_F](/windows/win32/api/dcommon/ns-dcommon-d2d_rect_f) \***

Receives a precomputed glyph box (in ems) for the specified glyph, if one is specified by the font. Otherwise, the glyph box is set to an empty rectangle (all zeros). If a non-empty clip box is specified, then you must clip the color glyph's representation to the specified box.

### -param glyphAttributes

Type: \_Out\_opt\_ **[DWRITE_PAINT_ATTRIBUTES](./ne-dwrite_3-dwrite_paint_attributes.md) \* = nullptr**

Receives optional paint attributes for the glyph.

## -returns

A standard **HRESULT** error code.

## -remarks

If the specified glyph index isn't a color glyph, then the method succeeds, but the paintType member of the [DWRITE_PAINT_ELEMENT](./ns-dwrite_3-dwrite_paint_element.md) structure is set to **DWRITE_PAINT_TYPE_NONE**. In that case, you should draw the input glyph as a non-color glyph.

## -see-also

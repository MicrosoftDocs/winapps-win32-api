---
UID: NF:dwrite_3.IDWritePaintReader.SetColorPaletteIndex
tech.root: dwritecore
title: IDWritePaintReader::SetColorPaletteIndex
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
 - IDWritePaintReader::SetColorPaletteIndex
f1_keywords:
 - IDWritePaintReader::SetColorPaletteIndex
 - dwrite_3/IDWritePaintReader::SetColorPaletteIndex
dev_langs:
 - c++
helpviewer_keywords:
 - SetColorPaletteIndex
---

## -description

Sets the current color palette index. The default value is zero. Changing the palette index can affect the appearance of a glyph if its definition references colors in the color palette. If that's the case, then the [SetCurrentGlyph](./nf-dwrite_3-idwritepaintreader-setcurrentglyph(uint32_dwrite_paint_element_uint32_d2d_rect_f_dwrite_paint_attributes).md) method returns the **DWRITE_PAINT_ATTRIBUTES_USES_PALETTE** flag via the *glyphAttributes* output parameter.

## -parameters

### -param colorPaletteIndex

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Specifies the color palette index.

## -returns

A standard **HRESULT** error code.

## -remarks

## -see-also

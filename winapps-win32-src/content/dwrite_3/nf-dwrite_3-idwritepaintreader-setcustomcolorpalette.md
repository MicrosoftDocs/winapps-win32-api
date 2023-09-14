---
UID: NF:dwrite_3.IDWritePaintReader.SetCustomColorPalette
tech.root: dwritecore
title: IDWritePaintReader::SetCustomColorPalette
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
 - IDWritePaintReader::SetCustomColorPalette
f1_keywords:
 - IDWritePaintReader::SetCustomColorPalette
 - dwrite_3/IDWritePaintReader::SetCustomColorPalette
dev_langs:
 - c++
helpviewer_keywords:
 - SetCustomColorPalette
---

## -description

Sets a custom color palette with client-defined palette entries, instead of using a font-defined color palette. Changing the color palette can affect the appearance of a glyph if its definition references colors in the color palette. If that's the case, then the [SetCurrentGlyph](./nf-dwrite_3-idwritepaintreader-setcurrentglyph(uint32_dwrite_paint_element_uint32_d2d_rect_f_dwrite_paint_attributes).md) method returns the **DWRITE_PAINT_ATTRIBUTES_USES_PALETTE** flag via the *glyphAttributes* output parameter.

## -parameters

### -param paletteEntries

Type: \_In\_reads\_\(paletteEntryCount\) **[DWRITE_COLOR_F](/windows/win32/directwrite/dwrite-color-f) const \***

Array of palette entries for the client-defined color palette.

### -param paletteEntryCount

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Size of the *paletteEntries* array. This must equal the font's palette entry count as returned by [IDWriteFontFace2::GetPaletteEntryCount](../dwrite_2/nf-dwrite_2-idwritefontface2-getpaletteentrycount.md).

## -returns

A standard **HRESULT** error code.

## -remarks

## -see-also

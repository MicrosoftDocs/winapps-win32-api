---
UID: NF:dwrite_3.IDWritePaintReader.SetTextColor
tech.root: dwritecore
title: IDWritePaintReader::SetTextColor
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
 - IDWritePaintReader::SetTextColor
f1_keywords:
 - IDWritePaintReader::SetTextColor
 - dwrite_3/IDWritePaintReader::SetTextColor
dev_langs:
 - c++
helpviewer_keywords:
 - SetTextColor
---

## -description

Sets the client-defined text color. The default value is transparent black. Changing the text color can affect the appearance of a glyph if its definition uses the current text color. If that's the case, then the [SetCurrentGlyph](./nf-dwrite_3-idwritepaintreader-setcurrentglyph(uint32_dwrite_paint_element_uint32_d2d_rect_f_dwrite_paint_attributes).md) method returns the **DWRITE_PAINT_ATTRIBUTES_USES_TEXT_COLOR** flag via the *glyphAttributes* output parameter.

## -parameters

### -param textColor

Type: \_In\_reads\_\(paletteEntryCount\) **[DWRITE_COLOR_F](/windows/win32/directwrite/dwrite-color-f) const \&**

Specifies the text color.

## -returns

A standard **HRESULT** error code.

## -remarks

## -see-also

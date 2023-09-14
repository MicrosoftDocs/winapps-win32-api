---
UID: NF:dwrite_3.IDWritePaintReader.MoveToFirstChild
tech.root: dwritecore
title: IDWritePaintReader::MoveToFirstChild
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
 - IDWritePaintReader::MoveToFirstChild
f1_keywords:
 - IDWritePaintReader::MoveToFirstChild
 - dwrite_3/IDWritePaintReader::MoveToFirstChild
dev_langs:
 - c++
helpviewer_keywords:
 - MoveToFirstChild
---

## -description

Sets the current position in the visual tree to the first child of the current paint element, and returns the newly-selected element's properties via the *paintElement* output parameter.

## -parameters

### -param paintElement

Type: \_Out\_writes\_bytes\_\(structSize\) **[DWRITE_PAINT_ELEMENT](./ns-dwrite_3-dwrite_paint_element.md) \***

Receives the properties of the newly-selected element.

### -param structSize

Type: **[UINT32](/windows/win32/winprog/windows-data-types) = sizeof(DWRITE_PAINT_ELEMENT)**

Size of the [DWRITE_PAINT_ELEMENT](./ns-dwrite_3-dwrite_paint_element.md) structure, in bytes.

## -returns

A standard **HRESULT** error code. The return value is **E_INVALIDARG** if the current paint element doesn't have any children.

## -remarks

You can determine (*a priori* from its paint type and properties) whether a paint element has children, and how many. For more info, see [DWRITE_PAINT_ELEMENT](./ns-dwrite_3-dwrite_paint_element.md).

## -see-also

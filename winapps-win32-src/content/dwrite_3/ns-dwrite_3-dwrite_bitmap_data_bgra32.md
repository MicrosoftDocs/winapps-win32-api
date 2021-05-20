---
UID: NS:dwrite_3.DWRITE_BITMAP_DATA_BGRA32
tech.root: dwritecore
title: DWRITE_BITMAP_DATA_BGRA32
ms.date: 05/18/2021
targetos: Windows
description: 
req.construct-type: structure
req.ddi-compliance: 
req.dll: 
req.header: dwrite_3.h
req.include-header: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Project Reunion)
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
 - DWRITE_BITMAP_DATA_BGRA32
f1_keywords:
 - DWRITE_BITMAP_DATA_BGRA32
 - dwrite_3/DWRITE_BITMAP_DATA_BGRA32
dev_langs:
 - c++
---

## -description

Represents bitmap data in BGRA32 format.

> [!IMPORTANT]
> This API is available as part of the [DWriteCore](/windows/win32/directwrite/dwritecore-overview) implementation of [DirectWrite](/windows/win32/directwrite).

## -struct-fields

### -field width

The width, in pixels, of the bitmap.

### -field height

The height, in pixels, of the bitmap.

### -field pixels

A pointer to the location of the bit values for the bitmap.

## -remarks

For more information, see [DWriteCore overview](/windows/win32/directwrite/dwritecore-overview) and the [DWriteCoreGallery](https://github.com/microsoft/Project-Reunion-Samples/tree/main/DWriteCore/DWriteCoreGallery) sample app.

## -see-also

[DWriteCore overview](/windows/win32/directwrite/dwritecore-overview)
---
UID: NS:dwrite_3.DWRITE_BITMAP_DATA_BGRA32
tech.root: dwritecore
title: DWRITE_BITMAP_DATA_BGRA32
ms.date: 05/18/2021
targetos: Windows
description: Represents bitmap data in BGRA32 format.
req.construct-type: structure
req.ddi-compliance: 
req.dll: 
req.header: dwrite_3.h
req.include-header: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 0.5 or later)
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
> This API is available as part of the DWriteCore implementation of [DirectWrite](/windows/win32/directwrite/direct-write-portal). For more info, and code examples, see [DWriteCore overview](/windows/win32/directwrite/dwritecore-overview).

## -struct-fields

### -field width

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

The width, in pixels, of the bitmap.

### -field height

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

The height, in pixels, of the bitmap.

### -field pixels

Type: \_Field\_size\_(width * height)**[UINT32](/windows/win32/winprog/windows-data-types)\***

A pointer to the location of the bit values for the bitmap.

## Examples

See the [DWriteCore overview](/windows/win32/directwrite/dwritecore-overview) topic, and the [DWriteCoreGallery](https://github.com/microsoft/WindowsAppSDK-Samples/tree/main/Samples/TextRendering/cpp-win32/DWriteCoreGallery) sample app.

## -remarks

## -see-also

[DWriteCore overview](/windows/win32/directwrite/dwritecore-overview)

[DWriteCoreGallery sample](https://github.com/microsoft/WindowsAppSDK-Samples/tree/main/Samples/TextRendering/cpp-win32/DWriteCoreGallery)

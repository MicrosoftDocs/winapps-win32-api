---
UID: NF:dwrite_3.IDWriteBitmapRenderTarget2.GetBitmapData
tech.root: dwritecore
title: IDWriteBitmapRenderTarget2::GetBitmapData
ms.date: 
targetos: Windows
description: Retrieves the pixel data from a bitmap render target.
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
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 0.5 or later) 
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
 - IDWriteBitmapRenderTarget2::GetBitmapData
f1_keywords:
 - IDWriteBitmapRenderTarget2::GetBitmapData
 - dwrite_3/IDWriteBitmapRenderTarget2::GetBitmapData
dev_langs:
 - c++
---

## -description

Retrieves the pixel data from a bitmap render target.

> [!IMPORTANT]
> This API is available as part of the [DWriteCore](/windows/win32/directwrite/dwritecore-overview) implementation of [DirectWrite](/windows/win32/directwrite).

## -parameters

### -param bitmapData

A pointer to the pixel data.

## -returns

If this method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

## -remarks

## -see-also

[DWriteCore](/windows/win32/directwrite/dwritecore-overview)

[DWriteCoreGallery sample](https://github.com/microsoft/Project-Reunion-Samples/tree/main/DWriteCore/DWriteCoreGallery)
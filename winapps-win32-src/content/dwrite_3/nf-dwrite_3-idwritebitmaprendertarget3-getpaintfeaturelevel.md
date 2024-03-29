---
UID: NF:dwrite_3.IDWriteBitmapRenderTarget3.GetPaintFeatureLevel
tech.root: dwritecore
title: IDWriteBitmapRenderTarget3::GetPaintFeatureLevel
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
 - IDWriteBitmapRenderTarget3::GetPaintFeatureLevel
f1_keywords:
 - IDWriteBitmapRenderTarget3::GetPaintFeatureLevel
 - dwrite_3/IDWriteBitmapRenderTarget3::GetPaintFeatureLevel
dev_langs:
 - c++
helpviewer_keywords:
 - GetPaintFeatureLevel
---

## -description

Retrieves the paint feature level supported by this render target. You can pass the return value of this method to [IDWriteFactory8::TranslateColorGlyphRun](./nf-dwrite_3-idwritefactory8-translatecolorglyphrun.md) in its *paintFeatureLevel* parameter.

## -returns

Type: **[DWRITE_PAINT_FEATURE_LEVEL](./ne-dwrite_3-dwrite_paint_feature_level.md)**

The paint feature level supported by this render target.

## -remarks

## -see-also

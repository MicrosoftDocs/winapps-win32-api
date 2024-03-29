---
UID: NF:dwrite_3.IDWritePaintReader.GetGradientStopColors
tech.root: dwritecore
title: IDWritePaintReader::GetGradientStopColors
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
 - IDWritePaintReader::GetGradientStopColors
f1_keywords:
 - IDWritePaintReader::GetGradientStopColors
 - dwrite_3/IDWritePaintReader::GetGradientStopColors
dev_langs:
 - c++
helpviewer_keywords:
 - GetGradientStopColors
---

## -description

Retrieves color information about each gradient stop, such as palette indices.

## -parameters

### -param firstGradientStopIndex

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Index of the first gradient stop to get.

### -param gradientStopCount

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Number of gradient stops to get.

### -param gradientStopColors

Type: \_Out\_writes\_\(gradientStopCount\) **[DWRITE_PAINT_COLOR](./ns-dwrite_3-dwrite_paint_color.md) \***

Receives the gradient stop colors.

## -returns

A standard **HRESULT** error code.

## -remarks

## -see-also

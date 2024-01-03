---
UID: NF:dwrite_3.IDWritePaintReader.GetGradientStops
tech.root: dwritecore
title: IDWritePaintReader::GetGradientStops
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
 - IDWritePaintReader::GetGradientStops
f1_keywords:
 - IDWritePaintReader::GetGradientStops
 - dwrite_3/IDWritePaintReader::GetGradientStops
dev_langs:
 - c++
helpviewer_keywords:
 - GetGradientStops
---

## -description

Retrieves the gradient stops of the current paint element.

## -parameters

### -param firstGradientStopIndex

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Index of the first gradient stop to retrieve.

### -param gradientStopCount

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Number of gradient stops to retrieve.

### -param gradientStops

Type: \_Out\_writes\_\(gradientStopCount\) **[D2D1_GRADIENT_STOP](/windows/win32/api/d2d1/ns-d2d1-d2d1_gradient_stop) \***

Receives the gradient stops.

## -returns

A standard **HRESULT** error code.

## -remarks

Gradient stops are guaranteed to be in ascending order by position.

## -see-also

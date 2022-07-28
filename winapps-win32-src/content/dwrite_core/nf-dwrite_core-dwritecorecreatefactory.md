---
UID: NF:dwrite_core.DWriteCoreCreateFactory
tech.root: dwritecore
title: DWriteCoreCreateFactory
ms.date: 05/18/2021
targetos: Windows
description: Creates a factory object that is used for subsequent creation of individual DWriteCore objects.
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: dwrite_core.h
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
 - HeaderDef
api_location:
 - dwrite_core.h
api_name:
 - DWriteCoreCreateFactory
f1_keywords:
 - DWriteCoreCreateFactory
 - dwrite_core/DWriteCoreCreateFactory
dev_langs:
 - c++
---

## -description

Creates a factory object that is used for subsequent creation of individual DWriteCore objects.

> [!IMPORTANT]
> This API is available as part of the DWriteCore implementation of [DirectWrite](/windows/win32/directwrite/direct-write-portal). For more info, and code examples, see [DWriteCore overview](/windows/win32/directwrite/dwritecore-overview).

## -parameters

### -param factoryType

Type: <b><a href="/windows/win32/api/dwrite/ne-dwrite-dwrite_factory_type">DWRITE_FACTORY_TYPE</a></b>

A value that specifies whether the factory object will be shared, isolated, or restricted.

### -param iid

Type: <b>REFIID</b>

A GUID value that identifies the DirectWrite factory interface, such as __uuidof(<a href="/windows/win32/api/dwrite/nn-dwrite-idwritefactory">IDWriteFactory</a>).

### -param factory

Type: <b>IUnknown**</b>

An address of a pointer to the newly created DirectWrite factory object.

## -returns

Type: <b>HRESULT</b>

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## Examples

See the [DWriteCore overview](/windows/win32/directwrite/dwritecore-overview) topic, and the [DWriteCoreGallery](https://github.com/microsoft/WindowsAppSDK-Samples/tree/main/Samples/TextRendering/cpp-win32/DWriteCoreGallery) sample app.

## -remarks

This is functionally the same as the [DWriteCreateFactory](/windows/win32/api/dwrite/nf-dwrite-dwritecreatefactory) function exported by the system version of DirectWrite. The DWriteCore function has a different name to avoid ambiguity.

## -see-also

[DWriteCore overview](/windows/win32/directwrite/dwritecore-overview)

[DWriteCoreGallery sample](https://github.com/microsoft/WindowsAppSDK-Samples/tree/main/Samples/TextRendering/cpp-win32/DWriteCoreGallery)

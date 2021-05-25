---
UID: NE:dwrite.DWRITE_FACTORY_TYPE
tech.root: dwritecore
title: DWRITE_FACTORY_TYPE
ms.date: 05/18/2021
targetos: Windows
description: Specifies the type of DirectWrite factory object.
req.construct-type: enumeration
req.ddi-compliance: 
req.header: dwrite.h
req.include-header: 
req.kmdf-ver: 
req.max-support: 
req.target-min-winverclnt: Windows 10, version 1809 and Project Reunion 0.5 (and later)
req.target-min-winversvr: 
req.target-type: 
req.typenames: 
req.umdf-ver: 
topic_type:
 - apiref
api_type:
 - HeaderDef
api_location:
 - dwrite.h
api_name:
 - DWRITE_FACTORY_TYPE
f1_keywords:
 - DWRITE_FACTORY_TYPE
 - dwrite/DWRITE_FACTORY_TYPE
dev_langs:
 - c++
---

## -description

Specifies the type of DirectWrite factory object.

> [!IMPORTANT]
> This API is available as part of the [DWriteCore](/windows/win32/directwrite/dwritecore-overview) implementation of [DirectWrite](/windows/win32/directwrite).

## -enum-fields

### -field DWRITE_FACTORY_TYPE_SHARED

Indicates that the DirectWrite factory is a shared factory and that it allows for the reuse of cached font data across multiple in-process components. Such factories also take advantage of cross process font caching components for better performance.

### -field DWRITE_FACTORY_TYPE_ISOLATED

Indicates that the DirectWrite factory object is isolated. Objects created from the isolated factory do not interact with internal DirectWrite state from other components.

### -field DWRITE_FACTORY_TYPE_ISOLATED2

Indicates that the DirectWrite factory object is restricted. Objects created from a restricted factory don't use nor modify internal state or cached data used by other factories. In addition, the system font collection contains only well-known fonts.

## -remarks

A DirectWrite factory object contains information about its internal state, such as font loader registration and cached font data. In most cases you should use the shared factory object, because it allows multiple components that use DirectWrite to share internal DirectWrite state information, thereby reducing memory usage. However, there are cases when it is desirable to reduce the impact of a component on the rest of the process, such as a plug-in from an untrusted source,  by sandboxing and isolating it from the rest of the process components. In such cases, you should use an isolated factory for the sandboxed component.

A restricted factory is more locked down than an isolated factory. It doesn't interact with a cross-process nor persistent font cache in any way. In addition, the system font collection returned from this factory includes only well-known fonts. If you pass **DWRITE_FACTORY_TYPE_ISOLATED2** to a version of DWrite that's older than DWriteCore, then [DWriteCreateFactory](/windows/win32/api/dwrite/nf-dwrite-dwritecreatefactory) returns **E_INVALIDARG**.

For more information, see [DWriteCore overview](/windows/win32/directwrite/dwritecore-overview) and the [DWriteCoreGallery](https://github.com/microsoft/Project-Reunion-Samples/tree/main/DWriteCore/DWriteCoreGallery) sample app.

## -see-also

[DWriteCore overview](/windows/win32/directwrite/dwritecore-overview)
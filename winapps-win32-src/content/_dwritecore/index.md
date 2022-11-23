---
UID: TP:dwritecore
title: DWriteCore
description: Provides information about the header files for the DWriteCore APIs.
ms.date: 09/12/2022
ms.keywords: 
ms.topic: conceptual
---

# DWriteCore

## -description

To develop with DWriteCore, you need these headers.

 * [dwrite_core.h](../dwrite_core/index.md)
 * [dwrite.h](../dwrite/index.md)
 * [dwrite_1.h](/windows/win32/api/dwrite_1/)
 * [dwrite_2.h](/windows/win32/api/dwrite_2/)
 * [dwrite_3.h](../dwrite_3/index.md)

For programming guidance for this technology, see [Render text with DWriteCore](/windows/win32/directwrite/dwritecore-overview).

> [!NOTE]
> The dwrite_core.h header is unique to DWriteCore. The dwrite.h and dwrite_3.h headers declare APIs that are supported by both DirectWrite and DWriteCore, in addition to a small set of APIs that are unique to DWriteCore. The dwrite_2.h header declares only APIs that are supported by both DirectWrite and DWriteCore.

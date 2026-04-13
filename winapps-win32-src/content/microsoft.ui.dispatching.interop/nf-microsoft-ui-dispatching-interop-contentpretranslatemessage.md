---
UID: NF:microsoft.ui.dispatching.interop.ContentPreTranslateMessage
tech.root: uiinterop
title: ContentPreTranslateMessage
ms.date: 02/15/2024
targetos: Windows
description: Filters window messages before they are dispatched to the TranslateMessage and DispatchMessage functions.
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: microsoft.ui.dispatching.interop.h
req.idl: 
req.include-header: 
req.irql: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.namespace: 
req.redist: 
req.target-min-winverclnt: 
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
 - microsoft.ui.dispatching.interop.h
api_name:
 - ContentPreTranslateMessage
f1_keywords:
 - ContentPreTranslateMessage
 - microsoft.ui.dispatching.interop/ContentPreTranslateMessage
dev_langs:
 - c++
helpviewer_keywords:
 - ContentPreTranslateMessage
---

## -description

Filters window messages before they are dispatched to the [TranslateMessage](/windows/win32/api/winuser/nf-winuser-translatemessage) and [DispatchMessage](/windows/win32/api/winuser/nf-winuser-dispatchmessage) functions.

## -parameters

### -param pmsg

A pointer to an [MSG structure](/windows/win32/api/winuser/ns-winuser-msg) that contains the message to process.

## -returns

True, if the message was fully processed by this function and should not be processed further. Otherwise, false if the message should go through standard processing.

## -remarks

Often used to intercept and process keyboard accelerators and focus navigation messages returned by the [GetMessage function](/windows/win32/api/winuser/nf-winuser-getmessage) before the messages are sent to a specific HWND WNDPROC.

## -see-also

[microsoft.ui.input.inputpretranslatesource.interop header](../microsoft.ui.input.inputpretranslatesource.interop/index.md), [Simple Island App](https://github.com/microsoft/WindowsAppSDK-Samples/tree/main/Samples/Islands)

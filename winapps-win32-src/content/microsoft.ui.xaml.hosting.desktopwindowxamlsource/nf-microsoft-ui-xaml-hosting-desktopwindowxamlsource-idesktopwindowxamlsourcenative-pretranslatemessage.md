---
UID: NF:microsoft.ui.xaml.hosting.desktopwindowxamlsource.IDesktopWindowXamlSourceNative.PreTranslateMessage
tech.root: winuicominterop
title: IDesktopWindowXamlSourceNative::PreTranslateMessage
ms.date: 09/10/2021
targetos: Windows
description: 
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: microsoft.ui.xaml.hosting.desktopwindowxamlsource.h
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
 - microsoft.ui.xaml.hosting.desktopwindowxamlsource.h
api_name:
 - IDesktopWindowXamlSourceNative::PreTranslateMessage
f1_keywords:
 - IDesktopWindowXamlSourceNative::PreTranslateMessage
 - microsoft.ui.xaml.hosting.desktopwindowxamlsource/IDesktopWindowXamlSourceNative::PreTranslateMessage
dev_langs:
 - c++
---

## -description

Enables the WinRT XAML framework to process a Windows message for a [IDesktopWindowXamlSourceNative](nn-microsoft-ui-xaml-hosting-desktopwindowxamlsource-idesktopwindowxamlsourcenative.md) object that hosts a WinRT XAML control.

## -parameters

### -param message

The Windows message to process.

### -param result

True if the message was processed. Otherwise, false.

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

For a code example that demonstrates how to use this method, see [XamlBridge.cpp](https://github.com/microsoft/Xaml-Islands-Samples/blob/master/Samples/Win32/SampleCppApp/XamlBridge.cpp) from the SampleCppApp sample in the XAML Island samples repo.

## -see-also

[Using the UWP XAML hosting API in a C++ desktop (Win32) app](/windows/apps/desktop/modernize/using-the-xaml-hosting-api)

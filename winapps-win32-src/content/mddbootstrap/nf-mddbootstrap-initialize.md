---
UID: NF:mddbootstrap.Initialize
tech.root: bootstrap
title: Initialize
ms.date: 03/28/2022
targetos: Windows
description: Calls [MddBootstrapInitialize](/windows/windows-app-sdk/api/win32/mddbootstrap/nf-mddbootstrap-mddbootstrapinitialize) to initialize the calling process to use the specified version of the Windows App SDK's framework package. If the call fails, throws an exception.
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: mddbootstrap.h
req.idl: 
req.include-header: 
req.irql: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.namespace: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK version 1.1 Stable or later)
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
 - mddbootstrap.h
api_name:
 - Initialize
f1_keywords:
 - Initialize
 - mddbootstrap/Initialize
dev_langs:
 - c++
helpviewer_keywords:
 - Initialize
---

## -description

Calls [MddBootstrapInitialize](/windows/windows-app-sdk/api/win32/mddbootstrap/nf-mddbootstrap-mddbootstrapinitialize) to initialize the calling process to use the specified version of the Windows App SDK's framework package. If the call fails, throws an exception.

## -parameters

### -param majorMinorVersion
See *majorMinorVersion* in [MddBootstrapInitialize](/windows/windows-app-sdk/api/win32/mddbootstrap/nf-mddbootstrap-mddbootstrapinitialize). Defaults to **WINDOWSAPPSDK_RELEASE_MAJORMINOR**.

### -param versionTag
See *versionTag* in [MddBootstrapInitialize](/windows/windows-app-sdk/api/win32/mddbootstrap/nf-mddbootstrap-mddbootstrapinitialize). Defaults to **WINDOWSAPPSDK_RELEASE_VERSION_TAG_W**.

### -param minVersion
See *minVersion* in [MddBootstrapInitialize](/windows/windows-app-sdk/api/win32/mddbootstrap/nf-mddbootstrap-mddbootstrapinitialize). Defaults to **WINDOWSAPPSDK_RUNTIME_VERSION_UINT64**.

## -returns

On success, returns a resource acquisition is initialization (RAII) object which, when it goes out of scope, undoes the changes that were made by the call to [MddBootstrapInitialize](/windows/windows-app-sdk/api/win32/mddbootstrap/nf-mddbootstrap-mddbootstrapinitialize).

## -remarks

## Example

```cpp
#include <windows.h>

#include <winrt\base.h>

#include <WindowsAppSDK-VersionInfo.h>
#include <MddBootstrap.h>

#include <iostream>

using MddBootstrap = MddBootstrap;

int main()
{
    try
    {
        auto mddBootstrapCleanup{ MddBootstrap::Initialize() };
        // Do work here.
    }
    catch (const winrt::hresult_error& ex)
    {
        const auto hr{ ex.code() };
        std::cout << "Error 0x" << std::hex << hr << " in Bootstraper initialization";
        return hr;
    }
    return 0;
}
```

## -see-also

* [MddBootstrap.h header](/windows/windows-app-sdk/api/win32/mddbootstrap/)
* [MddBootstrapInitialize](/windows/windows-app-sdk/api/win32/mddbootstrap/nf-mddbootstrap-mddbootstrapinitialize)

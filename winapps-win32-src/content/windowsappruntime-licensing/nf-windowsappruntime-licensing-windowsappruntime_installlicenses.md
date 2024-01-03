---
UID: NF:windowsappruntime-licensing.WindowsAppRuntime_InstallLicenses
tech.root: licensing
title: WindowsAppRuntime_InstallLicenses
ms.date: 01/27/2022
targetos: Windows
description: Install licenses (if any) for a Windows App SDK runtime release.
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: windowsappruntime-licensing.h
req.idl: 
req.include-header: 
req.irql: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.namespace: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.0 or later)
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
 - windowsappruntime-licensing.h
api_name:
 - WindowsAppRuntime_InstallLicenses
f1_keywords:
 - WindowsAppRuntime_InstallLicenses
 - windowsappruntime-licensing/WindowsAppRuntime_InstallLicenses
dev_langs:
 - c++
helpviewer_keywords:
 - WindowsAppRuntime_InstallLicenses
---

## -description

Install licenses (if any) for a Windows App SDK runtime release. This function finds the Windows App SDK runtime's framework package, and installs the contained licenses (if any).

> [!NOTE]
> Appropriate licenses must be installed in order for [MddBootstrapInitialize](/windows/windows-app-sdk/api/win32/mddbootstrap/nf-mddbootstrap-mddbootstrapinitialize) to succeed.

## -parameters

### -param majorMinorVersion

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

The major and minor version of the Windows App SDK framework package to use. The version is encoded as `0xMMMMNNNN`, where `M` = Major and `N` = Minor (for example, version 1.2 should be encoded as `0x00010002`).

### -param versionTag

Type: **[PCWSTR](/windows/win32/winprog/windows-data-types)**

The version tag of the Windows App SDK framework package to use (if any). For example, `"prerelease"`. Pass **NULL** (or `nullptr`) if none.

## -returns

Type: **[HRESULT](/windows/win32/com/structure-of-com-error-codes)**

If the function succeeds it returns **ERROR_SUCCESS**. Otherwise, the function returns an error code.

## -remarks

## -see-also

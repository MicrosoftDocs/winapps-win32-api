---
UID: NF:windowsappruntime-licensing.WindowsAppRuntime_InstallLicensesInPackage
tech.root: licensing
title: WindowsAppRuntime_InstallLicensesInPackage
ms.date: 01/27/2022
targetos: Windows
description: Install licenses (if any) in a Windows App SDK runtime's framework package.
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
 - WindowsAppRuntime_InstallLicensesInPackage
f1_keywords:
 - WindowsAppRuntime_InstallLicensesInPackage
 - windowsappruntime-licensing/WindowsAppRuntime_InstallLicensesInPackage
dev_langs:
 - c++
helpviewer_keywords:
 - WindowsAppRuntime_InstallLicensesInPackage
---

## -description

Install licenses (if any) in a Windows App SDK runtime's framework package. This function installs the licenses (if any) in the specified Windows App SDK runtime's framework package.

> [!NOTE]
> Appropriate licenses must be installed in order for [MddBootstrapInitialize](/windows/windows-app-sdk/api/win32/mddbootstrap/nf-mddbootstrap-mddbootstrapinitialize) to succeed.
>
> This function is primarily for testing purposes. We recommend that you use [WindowsAppRuntime_InstallLicenses](nf-windowsappruntime-licensing-windowsappruntime_installlicenses.md) instead.

## -parameters

### -param frameworkPackageFullName

Type: **[PCWSTR](/windows/win32/winprog/windows-data-types)**

The path to the Windows App SDK runtime's framework package.

## -returns

Type: **[HRESULT](/windows/win32/com/structure-of-com-error-codes)**

If the function succeeds it returns **ERROR_SUCCESS**. Otherwise, the function returns an error code.

## -remarks

## -see-also

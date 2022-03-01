---
UID: NF:mddbootstrap.MddBootstrapInitialize
tech.root: bootstrap
title: MddBootstrapInitialize
ms.date: 07/15/2021 
targetos: Windows
description: Initializes the calling process to use the version of the Windows App SDK framework package that best matches the specified criteria. This function is intended to be used by unpackaged desktop apps.
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
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.0 Preview 1 or later)
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
 - MddBootstrapInitialize
f1_keywords:
 - MddBootstrapInitialize
 - mddbootstrap/MddBootstrapInitialize
dev_langs:
 - c++
---

## -description

Initializes the calling process to use the version of the Windows App SDK framework package that best matches the specified criteria. This function is intended to be used by unpackaged desktop apps.

## -parameters

### -param majorMinorVersion

Type: **UINT32**

The major and minor version of the Windows App SDK framework package to load. The version is encoded as `0xMMMMNNNN`, where `M` = Major and `N` = Minor (for example, version 1.2 should be encoded as `0x00010002`).

### -param versionTag

Type: **PCWSTR**

The version tag of the Windows App SDK framework package to load (if any). For example, `"prerelease"`.

### -param minVersion

Type: [PACKAGE_VERSION](/windows/win32/api/appmodel/ns-appmodel-package_version)

The minimum version of the Windows App SDK framework package to use.

## -returns

Type: **HRESULT**

If the function succeeds it returns **ERROR_SUCCESS**. Otherwise, the function returns an error code.

## -remarks

This function finds a Windows App SDK framework package that meets the specified criteria and makes the package available for use by the current process. If multiple packages meet the criteria, this function selects the best candidate. For more information, see [Reference the Windows App SDK framework package at run time](/windows/apps/windows-app-sdk/reference-framework-package-run-time).

This function must be one of the first calls in the app's startup to ensure the bootstrapper component can properly initialize the Windows App SDK and add the run-time reference to the framework package.

This function also initializes the [Dynamic Dependency Lifetime Manager (DDLM)](/windows/apps/windows-app-sdk/deployment-architecture#dynamic-dependency-lifetime-manager-ddlm). The DDLM provides infrastructure to prevent the operating system (OS) from servicing the Windows App SDK framework package while it's being used by an unpackaged app.

Also see [Reference the Windows App SDK framework package at run time](/windows/apps/windows-app-sdk/reference-framework-package-run-time).

> [!NOTE]
> COM must be initialized for the current thread before you call this function.

## -see-also

* [Reference the Windows App SDK framework package at run time](/windows/apps/windows-app-sdk/reference-framework-package-run-time)

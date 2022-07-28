---
UID: NF:msixdynamicdependency.MddTryCreatePackageDependency
tech.root: dynamicdependency
title: MddTryCreatePackageDependency
ms.date: 07/15/2021 
targetos: Windows
description: Creates an install-time reference for a framework package dependency for the current app, using the specified package family name, minimum version, and additional criteria.
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: msixdynamicdependency.h
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
 - msixdynamicdependency.h
api_name:
 - MddTryCreatePackageDependency
f1_keywords:
 - MddTryCreatePackageDependency
 - msixdynamicdependency/MddTryCreatePackageDependency
dev_langs:
 - c++
---

## -description

Creates an install-time reference for a framework package dependency for the current app, using the specified package family name, minimum version, and additional criteria.

## -parameters

### -param user

Type: <b>PSID</b>

The user scope of the package dependency. If NULL, the caller's user context is used. Must be NULL if [ScopeIsSystem](ne-msixdynamicdependency-mddcreatepackagedependencyoptions.md) is specified for the *options* parameter.

### -param packageFamilyName

Type: <b>PCWSTR</b>

The package family name of the framework package on which to take dependency.

### -param minVersion

Type: [PACKAGE_VERSION](/windows/win32/api/appmodel/ns-appmodel-package_version)

The minimum version of the framework package on which to take dependency.

### -param packageDependencyProcessorArchitectures

Type: [PackageDependencyProcessorArchitectures](ne-msixdynamicdependency-mddpackagedependencyprocessorarchitectures.md)

The processor architectures of the package dependency.

### -param lifetimeKind

Type: [PackageDependencyLifetimeKind](ne-msixdynamicdependency-mddpackagedependencylifetimekind.md)

The type of artifact to use to define the lifetime of the package dependency. For more information, see the remarks.

### -param lifetimeArtifact

Type: **PCWSTR**

The name of the artifact used to define the lifetime of the package dependency. Must be NULL if the *lifetimeKind* parameter is [Process](ne-msixdynamicdependency-mddpackagedependencylifetimekind.md). For more information, see the remarks.

### -param options

Type: [CreatePackageDependencyOptions](ne-msixdynamicdependency-mddcreatepackagedependencyoptions.md)

The options to apply when creating the package dependency.

### -param packageDependencyId

Type: **PWSTR\***

The ID of the new package dependency. Use the [HeapAlloc](/windows/win32/api/heapapi/nf-heapapi-heapalloc) function to allocate memory for this parameter, and use [HeapFree](/windows/win32/api/heapapi/nf-heapapi-heapfree) to deallocate the memory.

## -returns

Type: **HRESULT**

If the function succeeds it returns **ERROR_SUCCESS**. Otherwise, the function returns an error code. The possible error codes include the following.

| Return code | Description |
|-------------|-------------|
| E_INVALIDARG | The *packageDependencyId* parameter is NULL on input. |

## -remarks

In your app's installer or during the first run of your app, call this method to specify a set of criteria for a framework package you want to use in your app. This informs the OS that your app has a dependency upon a framework package that meets the specified criteria. If one or more framework packages are installed that meet the criteria, Windows will ensure that at least one of these framework packages will remain installed until the install-time reference is deleted. For more information, see [Use the dynamic dependency API to reference framework packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api).

This function fails if the specified dependency criteria cannot be resolved to a specific package. This package resolution check is skipped if [DoNotVerifyDependencyResolution](ne-msixdynamicdependency-mddcreatepackagedependencyoptions.md) is specified for the *options* parameter. This is useful for installers running as user contexts other than the target user (for example, installers running as LocalSystem).

## -see-also

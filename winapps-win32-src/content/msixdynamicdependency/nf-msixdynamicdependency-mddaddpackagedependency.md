---
UID: NF:msixdynamicdependency.MddAddPackageDependency
tech.root: dynamicdependency
title: MddAddPackageDependency
ms.date: 07/15/2021 
targetos: Windows
description: Adds a run-time reference for the framework package dependency you created earlier by using the MddTryCreatePackageDependency method, with the specified options. After this method successfully returns, your app can activate types and use content from the framework package.
prerelease: true
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
 - MddAddPackageDependency
f1_keywords:
 - MddAddPackageDependency
 - msixdynamicdependency/MddAddPackageDependency
dev_langs:
 - c++
---

## -description

Adds a run-time reference for the framework package dependency you created earlier by using the [MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md) method, with the specified options. After this method successfully returns, your app can activate types and use content from the framework package.

## -parameters

### -param packageDependencyId

Type: **PCWSTR**

The ID of the package dependency to be resolved and added to the invoking process' package graph. This parameter must match a package dependency defined by using the [TryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md) function for the calling user or the system (via the [ScopeIsSystem](ne-msixdynamicdependency-mddcreatepackagedependencyoptions.md) option), or else an error is returned.

### -param rank

Type: **INT32**

The rank to use to add the resolved package to the caller's package graph. For more information, see the remarks.

### -param options

Type: [MddAddPackageDependencyOptions](ne-msixdynamicdependency-mddaddpackagedependencyoptions.md)

The options to apply when adding the package dependency.

### -param packageDependencyContext

Type: **PACKAGEDEPENDENCY_CONTEXT\***

The handle of the added package dependency. This handle is valid until it is passed to [RemovePackageDependency](nf-msixdynamicdependency-mddremovepackagedependency.md).

### -param packageFullName

Type: **PCWSTR\***

The full name of the package to which the dependency has been resolved. Use the [HeapAlloc](/windows/win32/api/heapapi/nf-heapapi-heapalloc) function to allocate memory for this parameter, and use [HeapFree](/windows/win32/api/heapapi/nf-heapapi-heapfree) to deallocate the memory.

## -returns

Type: **HRESULT**

If the function succeeds it returns **ERROR_SUCCESS**. Otherwise, the function returns an error code. The possible error codes include the following.

| Return code | Description |
|-------------|-------------|
| E_INVALIDARG | The *packageDependencyId* or *packageDependencyContext* parameter is NULL on input. |

## -remarks

Calling this method resolves the framework package dependency to a specific package on the system. It also informs the OS that the framework package is in active use and to handle any version updates in a side-by-side manner (effectively delay uninstalling or otherwise servicing the older version until after your app is done using it). Package resolution is specific to a user and can return different values for different users on a system.

Each successful **MddAddPackageDependency** call adds the resolved package to the calling process' package graph, even if already present. There is no duplicate detection or filtering applied by the API (that is, multiple references from a package is not harmful). After resolution is complete, the package dependency stays resolved for that user until the last reference across all processes for that user is removed via [MddRemovePackageDependency](nf-msixdynamicdependency-mddremovepackagedependency.md) or the process is terminated.

After this method successfully returns, your app can activate types and use content from the framework package until [MddRemovePackageDependency](nf-msixdynamicdependency-mddremovepackagedependency.md) is called.

If multiple packages are present in the package graph with the same rank as the call to **MddAddPackageDependency**, the resolved package is (by default) added after others of the same rank. To add a package before others of the same rank, specify [PrependIfRankCollision](ne-msixdynamicdependency-mddaddpackagedependencyoptions.md) for the *options* parameter.

For more information, see [Use the dynamic dependency API to reference framework packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api).

## -see-also

[MddRemovePackageDependency](nf-msixdynamicdependency-mddremovepackagedependency.md)


[MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md)


[Use the dynamic dependency API to reference framework packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api)
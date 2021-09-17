---
UID: NF:msixdynamicdependency.MddGetResolvedPackageFullNameForPackageDependency
tech.root: dynamicdependency
title: MddGetResolvedPackageFullNameForPackageDependency
ms.date: 07/15/2021 
targetos: Windows
description: Returns the package full name that would be used if the package dependency were to be resolved. This function does not add the package to the invoking process' package graph.
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
 - MddGetResolvedPackageFullNameForPackageDependency
f1_keywords:
 - MddGetResolvedPackageFullNameForPackageDependency
 - msixdynamicdependency/MddGetResolvedPackageFullNameForPackageDependency
dev_langs:
 - c++
---

## -description

Returns the package full name that would be used if the package dependency were to be resolved. This function does not add the package to the invoking process' package graph.

## -parameters

### -param packageDependencyId

Type: **PCWSTR**

The ID of the package dependency to be resolved. This parameter must match a package dependency defined by using the [MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md) function for the calling user or the system (via the [ScopeIsSystem](ne-msixdynamicdependency-mddcreatepackagedependencyoptions.md) option), or else an error is returned.

### -param packageFullName

Type: **PCWSTR\***

The full name of the package to which the dependency has been resolved. If the package dependency cannot be resolved, the function succeeds but this parameter is **nullptr** on output. Use the [HeapAlloc](/windows/win32/api/heapapi/nf-heapapi-heapalloc) function to allocate memory for this parameter, and use [HeapFree](/windows/win32/api/heapapi/nf-heapapi-heapfree) to deallocate the memory.

## -returns

| Return code | Description |
|-------------|-------------|
| E_INVALIDARG | The *packageDependencyId* or *packageFullName* parameter is NULL on input. |

## -remarks

To add the package to the invoking process' package graph, use the [MddAddPackageDependency](nf-msixdynamicdependency-mddaddpackagedependency.md) function.

## -see-also

[MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md)


[MddAddPackageDependency](nf-msixdynamicdependency-mddaddpackagedependency.md)
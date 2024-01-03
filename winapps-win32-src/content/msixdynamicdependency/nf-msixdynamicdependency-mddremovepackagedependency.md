---
UID: NF:msixdynamicdependency.MddRemovePackageDependency
tech.root: dynamicdependency
title: MddRemovePackageDependency
ms.date: 07/15/2021 
targetos: Windows
description: Removes a resolved package dependency from the current process' package graph (that is, a run-time reference for a framework package dependency that was added by using the MddAddPackageDependency function).
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
 - msixdynamicdependency.h
api_name:
 - MddRemovePackageDependency
f1_keywords:
 - MddRemovePackageDependency
 - msixdynamicdependency/MddRemovePackageDependency
dev_langs:
 - c++
---

## -description

Removes a resolved package dependency from the current process' package graph (that is, a run-time reference for a framework package dependency that was added by using the [MddAddPackageDependency](nf-msixdynamicdependency-mddaddpackagedependency.md) function).

## -parameters

### -param packageDependencyContext

Type: **PACKAGEDEPENDENCY_CONTEXT**

The handle of the package dependency to remove.

## -returns

Type: **HRESULT**

If the function succeeds it returns **ERROR_SUCCESS**. Otherwise, the function returns an error code. The possible error codes include the following.

| Return code | Description |
|-------------|-------------|
| E_INVALIDARG | The *packageDependencyContext* parameter is NULL on input. |

## -remarks

This function does not unload loaded resources such as DLLs. After removing a package dependency, any files loaded from the package can continue
to be used. Future file resolution will fail to see the removed package dependency.

Successful calls to this method change the generation ID value returned by [MddGetGenerationId](nf-msixdynamicdependency-mddgetgenerationid.md).

## -see-also

[MddAddPackageDependency](nf-msixdynamicdependency-mddaddpackagedependency.md)
---
UID: NF:msixdynamicdependency.MddDeletePackageDependency
tech.root: dynamicdependency
title: MddDeletePackageDependency
ms.date: 07/15/2021 
targetos: Windows
description: Deletes the install-time reference for the framework package dependency you created earlier by using the MddTryCreatePackageDependency method. This method informs the OS that it is safe to remove the framework package if no other apps have a dependency on it.
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
 - MddDeletePackageDependency
f1_keywords:
 - MddDeletePackageDependency
 - msixdynamicdependency/MddDeletePackageDependency
dev_langs:
 - c++
---

## -description

Deletes the install-time reference for the framework package dependency you created earlier by using the [MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md) method. This method informs the OS that it is safe to remove the framework package if no other apps have a dependency on it.

## -parameters

### -param packageDependencyId

Type: **PCWSTR**

The ID of the package dependency to remove.

## -returns

| Return code | Description |
|-------------|-------------|
| E_INVALIDARG | The *packageDependencyId* parameter is NULL on input. |

## -remarks

Removing a package dependency is typically done when an app is uninstalled. A package dependency is implicitly removed if its lifetime artifact (specified via the *lifetimeArtifact* parameter of the [MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md) function) is deleted. Package dependencies that are not referenced by other packages are elegible to be removed.

The caller of this function must have administrative privileges if the package dependency was created using [ScopeIsSystem](ne-msixdynamicdependency-mddcreatepackagedependencyoptions.md).

## -see-also

[MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md)


[Use the dynamic dependency API to reference framework packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api)


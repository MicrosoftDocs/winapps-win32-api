---
UID: NE:msixdynamicdependency.MddCreatePackageDependencyOptions
tech.root: dynamicdependency
title: MddCreatePackageDependencyOptions
ms.date: 07/15/2021 
targetos: Windows
description: Defines options that can be applied when creating a package dependency by using the MddTryCreatePackageDependency function.
prerelease: false
req.construct-type: enumeration
req.ddi-compliance: 
req.header: msixdynamicdependency.h
req.include-header: 
req.kmdf-ver: 
req.max-support: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.0 Preview 1 or later)
req.target-min-winversvr: 
req.target-type: 
req.typenames: 
req.umdf-ver: 
topic_type:
 - apiref
api_type:
 - HeaderDef
api_location:
 - msixdynamicdependency.h
api_name:
 - MddCreatePackageDependencyOptions
f1_keywords:
 - MddCreatePackageDependencyOptions
 - msixdynamicdependency/MddCreatePackageDependencyOptions
dev_langs:
 - c++
---

## -description

Defines options that can be applied when creating a package dependency by using the [MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md) function.

## -enum-fields

### -field None

No options are applied.

### -field DoNotVerifyDependencyResolution

Disables dependency resolution when pinning a package dependency. This is useful for installers running as user contexts other than the target user (for example, installers running as LocalSystem).

### -field ScopeIsSystem

Defines the package dependency for the system, accessible to all users (default is the package dependency is defined for a specific user). This option requires the caller has administrator privileges.

## -remarks

## -see-also

[MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md)

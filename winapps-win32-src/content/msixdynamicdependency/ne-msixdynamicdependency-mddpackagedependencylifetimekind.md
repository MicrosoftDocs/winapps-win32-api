---
UID: NE:msixdynamicdependency.MddPackageDependencyLifetimeKind
tech.root: dynamicdependency
title: MddPackageDependencyLifetimeKind
ms.date: 07/15/2021 
targetos: Windows
description: Specifies values that indicate the type of artifact that is used to define the lifetime of a package dependency.
prerelease: true
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
 - MddPackageDependencyLifetimeKind
f1_keywords:
 - MddPackageDependencyLifetimeKind
 - msixdynamicdependency/MddPackageDependencyLifetimeKind
dev_langs:
 - c++
---

## -description

Specifies values that indicate the type of artifact that is used to define the lifetime of a package dependency.

## -enum-fields

### -field Process

The current process is the lifetime artifact. The package dependency is implicitly deleted when the process terminates.

### -field FilePath

The lifetime artifact is an absolute filename or path. The package dependency is implicitly deleted when this is deleted.

### -field RegistryKey

The lifetime artifact is a registry key in the format *root*\\*subkey*, where *root* is one of the following: HKEY_LOCAL_MACHINE, HKEY_CURRENT_USER, HKEY_CLASSES_ROOT, or HKEY_USERS. The package dependency is implicitly deleted when this is deleted.

## -remarks

## -see-also

[MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md)

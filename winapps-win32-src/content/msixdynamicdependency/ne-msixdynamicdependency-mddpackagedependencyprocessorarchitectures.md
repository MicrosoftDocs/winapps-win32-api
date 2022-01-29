---
UID: NE:msixdynamicdependency.MddPackageDependencyProcessorArchitectures
tech.root: dynamicdependency
title: MddPackageDependencyProcessorArchitectures
ms.date: 07/15/2021 
targetos: Windows
description: Defines the processor architectures for a framework package dependency that you create by using the MddTryCreatePackageDependency function.
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
 - MddPackageDependencyProcessorArchitectures
f1_keywords:
 - MddPackageDependencyProcessorArchitectures
 - msixdynamicdependency/MddPackageDependencyProcessorArchitectures
dev_langs:
 - c++
---

## -description

Defines the processor architectures for a framework package dependency that you create by using the [MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md) function.

## -enum-fields

### -field None

No processor architecture is specified.

### -field Neutral

Specifies the neutral architecture.

### -field X86
 
Specifies the x86 architecture.

### -field X64

Specifies the x64 architecture.

### -field Arm

Specifies the ARM architecture.

### -field Arm64

Specifies the ARM64 architecture.

### -field X86A64

Specifies the x86/A64 architecture.

## -remarks

## -see-also

[MddTryCreatePackageDependency](nf-msixdynamicdependency-mddtrycreatepackagedependency.md)
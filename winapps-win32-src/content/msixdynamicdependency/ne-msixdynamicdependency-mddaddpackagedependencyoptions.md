---
UID: NE:msixdynamicdependency.MddAddPackageDependencyOptions
tech.root: dynamicdependency
title: MddAddPackageDependencyOptions
ms.date: 07/15/2021 
targetos: Windows
description: Defines options that can be applied when adding a run-time reference to a framework package by using the MddAddPackageDependency function.
prerelease: false
req.construct-type: enumeration
req.ddi-compliance: 
req.header: msixdynamicdependency.h
req.include-header: 
req.kmdf-ver: 
req.max-support: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.0 or later)
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
 - MddAddPackageDependencyOptions
f1_keywords:
 - MddAddPackageDependencyOptions
 - msixdynamicdependency/MddAddPackageDependencyOptions
dev_langs:
 - c++
---

## -description

Defines options that can be applied when adding a run-time reference to a framework package by using the [MddAddPackageDependency](nf-msixdynamicdependency-mddaddpackagedependency.md) function.

## -enum-fields

### -field None

No options are applied.

### -field PrependIfRankCollision

If multiple packages are present in the package graph with the same rank as the call to [MddAddPackageDependency](nf-msixdynamicdependency-mddaddpackagedependency.md), the resolved package is added before others of the same rank.

## -remarks

## -see-also

[MddAddPackageDependency](nf-msixdynamicdependency-mddaddpackagedependency.md)

[Use the dynamic dependency API to reference MSIX packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api)

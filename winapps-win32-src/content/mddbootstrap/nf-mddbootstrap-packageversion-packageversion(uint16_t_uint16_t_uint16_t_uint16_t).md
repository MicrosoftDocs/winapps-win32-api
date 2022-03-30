---
UID: NF:mddbootstrap.PackageVersion.PackageVersion(uint16_t,uint16_t,uint16_t,uint16_t)
tech.root: bootstrap
title: PackageVersion::PackageVersion
ms.date: 03/28/2022
targetos: Windows
description: Initializes a new instance of the **PackageVersion** class.
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
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK version 1.1 Stable or later)
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
 - PackageVersion::PackageVersion
f1_keywords:
 - PackageVersion::PackageVersion
 - mddbootstrap/PackageVersion::PackageVersion
dev_langs:
 - c++
helpviewer_keywords:
 - PackageVersion
---

## -description

Initializes a new instance of the **PackageVersion** class.

## -parameters

### -param major

A **uint16_t** value representing the `major` position of a `major.minor.build.revision` sequence.

### -param minor

An optional **uint16_t** value representing the `minor` position of a `major.minor.build.revision` sequence. Defaults to 0.

### -param build

An optional **uint16_t** value representing the `build` position of a `major.minor.build.revision` sequence. Defaults to 0.

### -param revision

An optional **uint16_t** value representing the `revision` position of a `major.minor.build.revision` sequence. Defaults to 0.

## -remarks

## -see-also

* [PackageVersion class](nl-mddbootstrap-packageversion.md)

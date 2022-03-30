---
UID: NF:mddbootstrap.PackageVersion.ToVersion
tech.root: bootstrap
title: PackageVersion::ToVersion
ms.date: 03/28/2022
targetos: Windows
description: Retrieves the version as a **uint64_t**.
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
 - PackageVersion::ToVersion
f1_keywords:
 - PackageVersion::ToVersion
 - mddbootstrap/PackageVersion::ToVersion
dev_langs:
 - c++
helpviewer_keywords:
 - ToVersion
---

## -description

Retrieves the version as a **uint64_t**.

## -returns

The `major.minor.build.revision` sequence encoded as a (little-endian) **uint64_t** (so that the first 16 bits contain the revision, and so on).

## -remarks

## -see-also

* [PackageVersion class](nl-mddbootstrap-packageversion.md)

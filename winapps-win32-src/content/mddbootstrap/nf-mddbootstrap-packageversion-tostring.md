---
UID: NF:mddbootstrap.PackageVersion.ToString
tech.root: bootstrap
title: PackageVersion::ToString
ms.date: 03/28/2022
targetos: Windows
description: Retrieves the version as a **std::wstring**.
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
 - PackageVersion::ToString
f1_keywords:
 - PackageVersion::ToString
 - mddbootstrap/PackageVersion::ToString
dev_langs:
 - c++
helpviewer_keywords:
 - ToString
---

## -description

Retrieves the version as a **std::wstring**.

## -returns

The `major.minor.build.revision` sequence encoded as a string (**std::wstring**) in the format "12345.12345.12345.12345" + null-terminator.

## -remarks

## -see-also

* [PackageVersion class](nl-mddbootstrap-packageversion.md)

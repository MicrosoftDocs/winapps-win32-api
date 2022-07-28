---
UID: NF:mrm.MrmGetFilePathFromName
tech.root: mrtcore 
title: MrmGetFilePathFromName
ms.date: 05/18/2021 
targetos: Windows
description: Gets the default path for a filename.
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: mrm.h
req.idl: 
req.include-header: 
req.irql: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.namespace: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 0.5 or later) 
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
 - mrm.h
api_name:
 - MrmGetFilePathFromName
f1_keywords:
 - MrmGetFilePathFromName
 - mrm/MrmGetFilePathFromName
dev_langs:
 - c++
---

## -description

Gets the default path for a filename.

## -parameters

### -param filename

The filename.

### -param filePath

Will contain the file path if the call was successful.

## -returns

**HRESULT** that indicates the result of the operation.

## -remarks

This method first looks in the current module path for a file with the specified name (or `resources.pri` if no name was provided). If this file exists, the `filePath` parameter will be set to the full path of that file.

If no file was found in the previous step, this method looks in the parent directory of the current module path for a file with the specified name (or `[current module name].pri` if no name was provided). If this file exists, the `filePath` parameter will be set to the full path of that file.

If neither file exists, the `filePath` parameter will be set to `[current module path]\[fileName]`, where fileName defaults to `resources.pri` if no filename was specified. Note that **this file may not exist**.

> [!WARNING]
> `MrmGetFilePathFromName` will always return a path on success. The path may not always exist.

## -see-also

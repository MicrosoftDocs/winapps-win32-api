---
UID: TP:bootstrap
title: Bootstrapper API for the Windows App SDK framework package
description: Provides information about the header files for the Bootstrapper API for Windows App SDK framework package.
ms.date: 04/21/2022
ms.keywords: 
ms.topic: conceptual
---

# Bootstrapper API for the Windows App SDK framework package

## -description

This API is designed to be used by unpackaged desktop apps to load the Windows App SDK [framework package](/windows/apps/desktop/modernize/framework-packages/framework-packages-overview). After the framework package is loaded by an unpackaged desktop app, the app can call APIs provided by the Windows App SDK.

To use this API, you need this header:

 * [mddbootstrap.h](../mddbootstrap/index.md)

For more information about this API, see [Reference the Windows App SDK framework package at run time](/windows/apps/windows-app-sdk/reference-framework-package-run-time).

## Constants

The following constants (for use with the Bootstrapper API) are declared in `WindowsAppSDK-VersionInfo.h`.

| Constant | Value | Description |
|-|-|-|
| WINDOWSAPPSDK_RELEASE_MAJOR | \[release-dependent\] | The major version of the Windows App SDK release. |
| WINDOWSAPPSDK_RELEASE_MINOR | \[release-dependent\] | The minor version of the Windows App SDK release. |
| WINDOWSAPPSDK_RELEASE_PATCH | \[release-dependent\] | The patch version of the Windows App SDK release. |
| WINDOWSAPPSDK_RELEASE_MAJORMINOR | \[release-dependent\] | The major and minor version of the Windows App SDK release, encoded as a uint32 (0xMMMMNNNN where M=major, N=minor). |
| WINDOWSAPPSDK_RELEASE_CHANNEL | \[release-dependent\] | The Windows App SDK release's channel (const char*); for example, "preview", or empty string for stable. |
| WINDOWSAPPSDK_RELEASE_CHANNEL_W | \[release-dependent\] | The Windows App SDK release's channel (const wchar_t*); for example, L"preview", or empty string for stable. |
| WINDOWSAPPSDK_RELEASE_VERSION_TAG | \[release-dependent\] | The Windows App SDK release's version tag (const char*); for example, "preview2", or empty string for stable. |
| WINDOWSAPPSDK_RELEASE_VERSION_TAG_W | \[release-dependent\] | The Windows App SDK release's version tag (const wchar_t*); for example, L"preview2", or empty string for stable. |
| WINDOWSAPPSDK_RELEASE_VERSION_SHORTTAG | \[release-dependent\] | The Windows App SDK release's short-form version tag (const char*); for example, "p2", or empty string for stable. |
| WINDOWSAPPSDK_RELEASE_VERSION_SHORTTAG_W | \[release-dependent\] | The Windows App SDK release's short-form version tag (const wchar_t*); for example, L"p2", or empty string for stable. |
| WINDOWSAPPSDK_RUNTIME_<br/>IDENTITY_PUBLISHER | "CN=Microsoft Corporation, O=Microsoft Corporation, L=Redmond, S=Washington, C=US" | The Windows App SDK runtime's package identity's Publisher (const char*). |
| WINDOWSAPPSDK_RUNTIME_<br/>IDENTITY_PUBLISHER_W | L"CN=Microsoft Corporation, O=Microsoft Corporation, L=Redmond, S=Washington, C=US" | The Windows App SDK runtime's package identity's Publisher (const wchar_t*). |
| WINDOWSAPPSDK_RUNTIME_<br/>IDENTITY_PUBLISHERID | "8wekyb3d8bbwe" | The Windows App SDK runtime's package identity's PublisherId (const char*). |
| WINDOWSAPPSDK_RUNTIME_<br/>IDENTITY_PUBLISHERID_W | L"8wekyb3d8bbwe" | The Windows App SDK runtime's package identity's PublisherId (const wchar_t*). |
| WINDOWSAPPSDK_RUNTIME_<br/>VERSION_MAJOR | \[release-dependent\] | The major version of the Windows App SDK runtime; for example, 1000. |
| WINDOWSAPPSDK_RUNTIME_<br/>VERSION_MINOR | \[release-dependent\] | The minor version of the Windows App SDK runtime; for example, 446. |
| WINDOWSAPPSDK_RUNTIME_<br/>VERSION_BUILD | \[release-dependent\] | The build version of the Windows App SDK runtime; for example, 804. |
| WINDOWSAPPSDK_RUNTIME_<br/>VERSION_REVISION | \[release-dependent\] | The revision version of the Windows App SDK runtime; for example, 0. |
| WINDOWSAPPSDK_RUNTIME_<br/>VERSION_UINT64 | \[release-dependent\] | The version of the Windows App SDK runtime, as a uint64l for example, 0x03E801BE03240000. |
| WINDOWSAPPSDK_RUNTIME_<br/>VERSION_DOTQUADSTRING | \[release-dependent\] | The version of the Windows App SDK runtime, as a string (const char*); for example, "1000.446.804.0". |
| WINDOWSAPPSDK_RUNTIME_<br/>VERSION_DOTQUADSTRING_W | \[release-dependent\] | The version of the Windows App SDK runtime, as a string (const wchar_t*); for example, L"1000.446.804.0". |
| WINDOWSAPPSDK_RUNTIME_<br/>PACKAGE_FRAMEWORK_PACKAGEFAMILYNAME | "Microsoft.WindowsAppRuntime.1.1-preview1_8wekyb3d8bbwe" | The Windows App SDK runtime's Framework package's family name (const char*). |
| WINDOWSAPPSDK_RUNTIME_<br/>PACKAGE_FRAMEWORK_PACKAGEFAMILYNAME_W | "Microsoft.WindowsAppRuntime.1.1-preview1_8wekyb3d8bbwe" | The Windows App SDK runtime's Framework package's family name (const wchar_t*). |
| WINDOWSAPPSDK_RUNTIME_<br/>PACKAGE_MAIN_PACKAGEFAMILYNAME | "MicrosoftCorporationII.WinAppRuntime.Main.1.1-p1_8wekyb3d8bbwe" | The Windows App SDK runtime's Main package's family name (const char*). |
| WINDOWSAPPSDK_RUNTIME_<br/>PACKAGE_MAIN_PACKAGEFAMILYNAME_W | L"MicrosoftCorporationII.WinAppRuntime.Main.1.1-p1_8wekyb3d8bbwe" | The Windows App SDK runtime's Main package's family name (const wchar_t*). |
| WINDOWSAPPSDK_RUNTIME_<br/>PACKAGE_SINGLETON_PACKAGEFAMILYNAME | "Microsoft.WindowsAppRuntime.Singleton-preview1_8wekyb3d8bbwe" | The Windows App SDK runtime's Singleton package's family name (const char*). |
| WINDOWSAPPSDK_RUNTIME_<br/>PACKAGE_SINGLETON_PACKAGEFAMILYNAME_W | L"Microsoft.WindowsAppRuntime.Singleton-preview1_8wekyb3d8bbwe" | The Windows App SDK runtime's Singleton package's family name (const wchar_t*). |

## See also

* [Bootstrapper C# APIs](/windows/apps/api-reference/cs-bootstrapper-apis/)
* [Bootstrapper C++ API](/windows/apps/api-reference/bootstrapper-cpp-api/)

---
UID: NF:microsoft.ui.xaml.window.IWindowNative.get_WindowHandle
tech.root: winuicominterop
title: IWindowNative::get_WindowHandle
ms.date: 09/10/2021
targetos: Windows
description: Gets the requested handle for the window
prerelease: false
req.assembly: 
req.construct-type: function
req.ddi-compliance: 
req.dll: 
req.header: microsoft.ui.xaml.window.h
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
 - COM
api_location:
 - microsoft.ui.xaml.window.h
api_name:
 - IWindowNative::get_WindowHandle
f1_keywords:
 - IWindowNative::get_WindowHandle
 - microsoft.ui.xaml.window/IWindowNative::get_WindowHandle
dev_langs:
 - c++
---

## -description

Gets the requested handle for the window.

## -parameters

### -param hWnd

Handle to the window.

## -returns

If this method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

## -remarks

Before trying the following example, review the following topics:

- To use the WinUI 3 for desktop project templates, configure your development computer and [set up your development environment](/windows/apps/windows-app-sdk/set-up-your-development-environment).
- Confirm your dev environment is functioning as expected by creating and running an initial template app as described in [Create your first WinUI 3 app](/windows/apps/winui/winui3/create-your-first-winui3-app).

### Customized window icon

In the following example, we start with the initial **WinUI in Desktop C#/.NET 5** template code and show how to customize the window title bar and its content using a **WindowHandle**.

#### MainWindow.xaml

1. In MainWindow.xaml, we add two buttons and specify Click handlers for each. In the Click handler for the first button (`basicButton_Click`) we set the title bar icon and text, while in the second (`customButton_Click`) we demonstrate more significant customization by replacing the title bar with the content of the `customTitleBarPanel` StackPanel.

:::code language="xaml" source="snippets/window-titlebar/window-titlebar/MainWindow.xaml":::

#### MainWindow.xaml.cs

1. In the `basicButton_Click` handler, we first ensure that the custom title bar is not being displayed by collapsing the `customTitleBarPanel` StackPanel and setting the [ExtendsContentIntoTitleBar](/windows/winui/api/microsoft.ui.xaml.window.extendscontentintotitlebar) property to false.
1. We then call **GetWindowHandle** for the hwnd of the current window.
1. Next, we set the application icon using PInvoke to call the [LoadImage](/windows/win32/api/winuser/nf-winuser-loadimagea) and [SendMessage](/windows/win32/api/winuser/nf-winuser-sendmessage) functions.
1. Finally, we call [SetWindowText](/windows/win32/api/winuser/nf-winuser-setwindowtexta) to update the title bar string.

:::code language="csharp" source="snippets/window-titlebar/window-titlebar/MainWindow.xaml.cs" id="basicButton_Click" highlight="3-7,8-9,12-23":::

1. In the `customButton_Click` handler, we set the visibility of the `customTitleBarPanel` StackPanel to Visible.
1. We then set the [ExtendsContentIntoTitleBar](/windows/winui/api/microsoft.ui.xaml.window.xtendscontentintotitlebar) property to true and call [SetTitleBar](/windows/winui/api/microsoft.ui.xaml.window.settitlebar) to display the `customTitleBarPanel` StackPanel as our custom title bar.

:::code language="csharp" source="snippets/window-titlebar/window-titlebar/MainWindow.xaml.cs" id="customButton_Click":::

#### App.xaml

In the App.xaml file we define some custom colors for the title bar as shown here.

:::code language="csharp" source="snippets/window-titlebar/window-titlebar/App.xaml":::

6. If you've followed these steps in your own app, build and run the app. You should see an application window similar to the following (with the custom app icon):

    :::image type="content" source="images/template-app-windowhandle.png" alt-text="Template app with no customization.":::<br/>*Template app.*

- Here's the basic custom title bar:

    :::image type="content" source="images/template-app-windowhandle-basic-custom.png" alt-text="Template app with custom application icon.":::<br/>*Template app with custom application icon.*

- Here's the fully custom title bar:

    :::image type="content" source="images/template-app-windowhandle-full-custom.png" alt-text="Template app with custom title bar.":::<br/>*Template app with custom title bar.*

## -examples

## -see-also

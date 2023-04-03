---
UID: NF:microsoft.ui.xaml.window.IWindowNative.get_WindowHandle
title: IWindowNative::get_WindowHandle
description: Retrieves the window handle (**[HWND](/windows/win32/winprog/windows-data-types)**) of the window represented by the object that implements [IWindowNative](/windows/windows-app-sdk/api/win32/microsoft.ui.xaml.window/nn-microsoft-ui-xaml-window-iwindownative).
ms.date: 02/28/2023
tech.root: winuicominterop
targetos: Windows
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

Retrieves the window handle (**[HWND](/windows/win32/winprog/windows-data-types)**) of the window represented by the object that implements [IWindowNative](/windows/windows-app-sdk/api/win32/microsoft.ui.xaml.window/nn-microsoft-ui-xaml-window-iwindownative).

## -parameters

### -param hWnd

The window handle (**HWND**).

## -returns

If this method succeeds, it returns **S_OK**. Otherwise, it returns an **HRESULT** error code.

## -remarks

For more info, and code examples, see [Retrieve a window handle (HWND)](/windows/apps/develop/ui-input/retrieve-hwnd).

## Examples

Before following along with this example, review these topics:

* [Install tools for the Windows App SDK](/windows/apps/windows-app-sdk/set-up-your-development-environment).
* [Create your first WinUI 3 project](/windows/apps/winui/winui3/create-your-first-winui3-app).

### Customized window icon

In this example, we show how to retrieve the window handle (**HWND**) of our main window, and use that to customize the window's title bar and its content.

#### Create a new project

1. In Visual Studio, create a new C# or C++/WinRT project from the **Blank App, Packaged (WinUI 3 in Desktop)** project template.

#### MainWindow.xaml

> [!NOTE]
> If you need an icon file to use with this walkthrough, you can download the [`computer.ico` file](https://github.com/microsoft/Windows-classic-samples/blob/main/Samples/Win7Samples/netds/wlan/WirelessHostedNetwork/HostedNetwork/res/computer.ico) from the **WirelessHostednetwork** sample app. Place that file in your `Assets` folder, and add the file to your project as content. You'll then be able to refer to the file using the uri `Assets/computer.ico`.
>
> Otherwise, feel free to use an icon file that you already have, and change the two references to it in the code listings below.

1. In the code listing below, you'll see that in `MainWindow.xaml` we've added two buttons, and specified **Click** handlers for each. In the **Click** handler for the first button (**basicButton_Click**), we set the title bar icon and text. In the second (**customButton_Click**), we demonstrate more significant customization by replacing the title bar with the content of the **StackPanel** named *customTitleBarPanel*.

:::code language="xaml" source="snippets/window-titlebar/window-titlebar/MainWindow.xaml":::

#### MainWindow.xaml.cs/cpp

1. In the code listing below for the **basicButton_Click** handler&mdash;in order to keep the custom title bar hidden&mdash;we collapse the *customTitleBarPanel* **StackPanel**, and we set the [ExtendsContentIntoTitleBar](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.window.extendscontentintotitlebar) property to `false`.
2. We then call **IWindowNative::get_WindowHandle** (for C#, using the interop helper method **GetWindowHandle**) to retrieve the window handle (**HWND**) of the main window.
3. Next, we set the application icon (for C#, using the [PInvoke.User32](https://www.nuget.org/packages/PInvoke.User32/) NuGet package) by calling the [LoadImage](/windows/win32/api/winuser/nf-winuser-loadimagea) and [SendMessage](/windows/win32/api/winuser/nf-winuser-sendmessage) functions.
4. Finally, we call [SetWindowText](/windows/win32/api/winuser/nf-winuser-setwindowtexta) to update the title bar string.

:::code language="csharp" source="snippets/window-titlebar/window-titlebar/MainWindow.xaml.cs" id="basicButton_Click" highlight="3-7,8-9,12-23":::

```cppwinrt
// pch.h
...
#include <microsoft.ui.xaml.window.h>
...

// MainWindow.xaml.h
...
void basicButton_Click(Windows::Foundation::IInspectable const& sender, Microsoft::UI::Xaml::RoutedEventArgs const& args);
...

// MainWindow.xaml.cpp
void MainWindow::basicButton_Click(IInspectable const&, RoutedEventArgs const&)
{
    // Ensure the that custom title bar content is not displayed.
    customTitleBarPanel().Visibility(Visibility::Collapsed);

    // Disable custom title bar content.
    ExtendsContentIntoTitleBar(false);

    // Get the window's HWND
    auto windowNative{ this->try_as<::IWindowNative>() };
    HWND hWnd{ 0 };
    windowNative->get_WindowHandle(&hWnd);

    HICON icon{ reinterpret_cast<HICON>(::LoadImage(nullptr, L"Assets/computer.ico", IMAGE_ICON, 0, 0, LR_DEFAULTSIZE | LR_LOADFROMFILE)) };
    ::SendMessage(hWnd, WM_SETICON, 0, (LPARAM)icon);

    this->Title(L"Basic customization of title bar");
}
```

5. In the **customButton_Click** handler, we set the visibility of the *customTitleBarPanel* **StackPanel** to **Visible**.
6. We then set the [ExtendsContentIntoTitleBar](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.window.extendscontentintotitlebar) property to `true`, and call [SetTitleBar](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.window.settitlebar) to display the *customTitleBarPanel* **StackPanel** as our custom title bar.

:::code language="csharp" source="snippets/window-titlebar/window-titlebar/MainWindow.xaml.cs" id="customButton_Click":::

```cppwinrt
// MainWindow.xaml.h
...
void customButton_Click(Windows::Foundation::IInspectable const& sender, Microsoft::UI::Xaml::RoutedEventArgs const& args);
...

// MainWindow.xaml.cpp
void MainWindow::customButton_Click(IInspectable const&, RoutedEventArgs const&)
{
    customTitleBarPanel().Visibility(Visibility::Visible);

    // Enable custom title bar content.
    ExtendsContentIntoTitleBar(true);

    // Set the content of the custom title bar.
    SetTitleBar(customTitleBarPanel());
}
```

#### App.xaml

1. In the `App.xaml` file, immediately after the `<!-- Other app resources here -->` comment, we've added some custom-colored brushes for the title bar, as shown below.

:::code language="csharp" source="snippets/window-titlebar/window-titlebar/App.xaml":::

1. If you've been following along with these steps in your own app, then you can build your project now, and run the app. You'll see an application window similar to the following (with the custom app icon):

    :::image type="content" source="images/template-app-windowhandle.png" alt-text="Template app with no customization.":::<br/>*Template app.*

- Here's the basic custom title bar:

    :::image type="content" source="images/template-app-windowhandle-basic-custom.png" alt-text="Template app with custom application icon.":::<br/>*Template app with custom application icon.*

- Here's the fully custom title bar:

    :::image type="content" source="images/template-app-windowhandle-full-custom.png" alt-text="Template app with custom title bar.":::<br/>*Template app with custom title bar.*

## -see-also

* [IWindowNative](/windows/windows-app-sdk/api/win32/microsoft.ui.xaml.window/nn-microsoft-ui-xaml-window-iwindownative)
* [Retrieve a window handle (HWND)](/windows/apps/develop/ui-input/retrieve-hwnd)

using Microsoft.UI.Xaml;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace window_titlebar
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            // Set the initial Window title.
            Title = "Basic WinUI 3 Window title bar sample";
        }

        // <basicButton_Click>
        private void basicButton_Click(object sender, RoutedEventArgs e)
        {
            // Ensure the custom title bar content is not displayed.
            customTitleBarPanel.Visibility = Visibility.Collapsed;

            // Disable custom title bar content.
            ExtendsContentIntoTitleBar = false;

            //Get the Window's HWND
            var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(this);

            IntPtr hIcon = PInvoke.User32.LoadImage(
                IntPtr.Zero,
                "Images/windowIcon.ico",
                PInvoke.User32.ImageType.IMAGE_ICON,
                20, 20,
                PInvoke.User32.LoadImageFlags.LR_LOADFROMFILE);

            PInvoke.User32.SendMessage(
                hwnd,
                PInvoke.User32.WindowMessage.WM_SETICON,
                (IntPtr)0,
                hIcon);

            PInvoke.User32.SetWindowText(hwnd, "Basic customization of title bar");
        }
        // </basicButton_Click>

        // <customButton_Click>
        private void customButton_Click(object sender, RoutedEventArgs e)
        {
            customTitleBarPanel.Visibility = Visibility.Visible;

            // Enable custom title bar content.
            ExtendsContentIntoTitleBar = true;
            // Set the content of the custom title bar.
            SetTitleBar(customTitleBarPanel);
        }
        // </customButton_Click>
    }
}
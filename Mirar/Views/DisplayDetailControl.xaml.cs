using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WindowsDisplayAPI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Mirar.Views;
public sealed partial class DisplayDetailControl : UserControl
{
    public Display? DisplayDetailItem
    {
        get => GetValue(DisplayDetailItemProperty) as Display;
        set => SetValue(DisplayDetailItemProperty, value);
    }

    public DisplayDetailControl()
    {
        InitializeComponent();
    }

    public static readonly DependencyProperty DisplayDetailItemProperty = DependencyProperty.Register("DisplayDetailItem", typeof(Display), typeof(ListDetailControl), new PropertyMetadata(null, OnDisplayDetailItemPropertyChanged));

    private static void OnDisplayDetailItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is DisplayDetailControl control)
        {
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}

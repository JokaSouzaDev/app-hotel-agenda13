using AppHotelJoaquim.Views;

namespace AppHotelJoaquim;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(ResultadoPage), typeof(ResultadoPage));
    }
}

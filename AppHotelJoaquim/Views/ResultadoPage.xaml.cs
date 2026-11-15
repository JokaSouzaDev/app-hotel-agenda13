using AppHotelJoaquim.Models;

namespace AppHotelJoaquim.Views;

public partial class ResultadoPage : ContentPage, IQueryAttributable
{
    public ResultadoPage()
    {
        InitializeComponent();
    }

    // O Shell entrega o objeto enviado na tela de reserva.
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("reserva", out var dado) && dado is ReservaResumo resumo)
            BindingContext = resumo;
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}

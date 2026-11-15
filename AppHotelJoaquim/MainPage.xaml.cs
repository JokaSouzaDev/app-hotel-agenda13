using AppHotelJoaquim.Models;
using AppHotelJoaquim.Views;

namespace AppHotelJoaquim;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        pckQuarto.SelectedIndex = 0;
        dtpCheckin.MinimumDate = DateTime.Today;
        dtpCheckin.Date = DateTime.Today;
        dtpCheckout.MinimumDate = DateTime.Today.AddDays(1);
        dtpCheckout.Date = DateTime.Today.AddDays(1);
    }

    private void OnCheckinChanged(object sender, DateChangedEventArgs e)
    {
        if (dtpCheckin.Date is not DateTime checkin)
            return;

        var primeiraSaidaPossivel = checkin.AddDays(1);
        dtpCheckout.MinimumDate = primeiraSaidaPossivel;
        if (dtpCheckout.Date is not DateTime checkout || checkout < primeiraSaidaPossivel)
            dtpCheckout.Date = primeiraSaidaPossivel;
    }

    private async void OnCalcularClicked(object sender, EventArgs e)
    {
        var adultos = (int)stpAdultos.Value;
        var criancas = (int)stpCriancas.Value;
        if (adultos < 1)
        {
            await DisplayAlertAsync("Verifique os hóspedes", "Selecione pelo menos um adulto.", "OK");
            return;
        }

        if (dtpCheckin.Date is not DateTime checkin || dtpCheckout.Date is not DateTime checkout)
        {
            await DisplayAlertAsync("Confira as datas", "Selecione as datas de entrada e saída.", "OK");
            return;
        }

        if (checkout <= checkin)
        {
            await DisplayAlertAsync("Confira as datas", "O check-out deve ser posterior ao check-in.", "OK");
            return;
        }

        var opcoes = new[]
        {
            (Nome: "Suíte Standard", Preco: 220m),
            (Nome: "Suíte Luxo", Preco: 350m),
            (Nome: "Suíte Premium", Preco: 490m)
        };
        var indice = pckQuarto.SelectedIndex;
        if (indice < 0 || indice >= opcoes.Length)
        {
            await DisplayAlertAsync("Escolha uma suíte", "Selecione a acomodação desejada.", "OK");
            return;
        }

        var escolhida = opcoes[indice];
        var reserva = new ReservaResumo(
            escolhida.Nome,
            escolhida.Preco,
            adultos,
            criancas,
            checkin,
            checkout
        );

        await Shell.Current.GoToAsync(nameof(ResultadoPage), new Dictionary<string, object>
        {
            ["reserva"] = reserva
        });
    }
}

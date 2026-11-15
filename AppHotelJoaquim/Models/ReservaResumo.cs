using System.Globalization;

namespace AppHotelJoaquim.Models;

public class ReservaResumo
{
    public ReservaResumo(string suite, decimal valorDiaria, int adultos, int criancas,
                         DateTime entrada, DateTime saida)
    {
        Suite = suite;
        ValorDiaria = valorDiaria;
        Adultos = adultos;
        Criancas = criancas;
        Entrada = entrada;
        Saida = saida;
    }

    public string Suite { get; }
    public decimal ValorDiaria { get; }
    public int Adultos { get; }
    public int Criancas { get; }
    public DateTime Entrada { get; }
    public DateTime Saida { get; }
    public int Noites => (Saida - Entrada).Days;
    public decimal Total => Noites * ValorDiaria;

    public string HospedesTexto => "${Adultos} adulto(s) e ${Criancas} criança(s)";
    public string PeriodoTexto => "${Entrada:dd/MM/yyyy} a ${Saida:dd/MM/yyyy}";
    public string NoitesTexto => "${Noites} diária(s)";
    public string ValorDiariaTexto => ValorDiaria.ToString("C", new CultureInfo("pt-BR"));
    public string TotalTexto => Total.ToString("C", new CultureInfo("pt-BR"));
}

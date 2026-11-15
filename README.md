# App Hotel Aurora | Agenda 13 🏨

Projeto desenvolvido por **Joaquim de Souza Araujo** em **2026**, para a atividade de **Programação Mobile I** (ETEC).

## Descrição
Aplicativo educacional de simulação de hospedagem, desenvolvido em **C#**, **XAML** e **.NET MAUI 10** utilizando o **Visual Studio Code** no Windows.

### Funcionalidades
- Seleção de adultos e crianças com `Stepper` e atualização visual por `BindingContext`;
- Escolha de suíte com `Picker`;
- Datas de check-in e check-out com `DatePicker` e validação;
- Cálculo estimado das diárias;
- Tela de resumo da reserva;
- Tela **Sobre** com o nome do desenvolvedor e o ano de desenvolvimento.

Os valores das suítes são fictícios, apenas para demonstração escolar. O aplicativo não realiza reservas reais.

## Executar no Windows
Pré-requisitos: **.NET SDK 10** e workload **maui-windows**.

Abra a pasta `AppHotelJoaquim` no terminal e execute:

```powershell
dotnet restore
dotnet build -f net10.0-windows10.0.19041.0
dotnet run -f net10.0-windows10.0.19041.0
```

As pastas `bin` e `obj` não são enviadas ao repositório, conforme `.gitignore`.

## Testes
O desenvolvedor confirmou o funcionamento do layout, seletores de hóspedes e suíte, escolha e validação de datas, cálculo de hospedagem e acesso à tela Sobre.

## Referência didática
Material **Agenda 13: Imagens e Componentes Diversos de Interface Gráfica**, Centro Paula Souza (2024). [Repositório de referência do professor](https://github.com/tiagotas/MauiAppHotel/tree/f4651e5172dedfceec4630538ffe4bf340bce128).

Esta é uma implementação própria dos conceitos apresentados no material.

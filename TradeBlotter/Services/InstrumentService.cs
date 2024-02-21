using TradeBlotter.Model;

namespace TradeBlotter.Services;

public class InstrumentService
{
    public List<Instrument> Instruments { get; } = new List<Instrument>();
    public string[] Currencies { get; } = new[] { "USD", "GBP", "EUR", "AUD", "JPY", "CHF" };

    private string[] NamesPart1 = { "BARC", "CGMSE", "GRNKNG", "CLO", "WHSE", "KING" };
    private string[] Tranches = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "X" };

    public InstrumentService()
    {
        for (int i = 0; i < 10000; i++)
        {
            Instruments.Add(new Instrument
            {
                Id = "0164hrs" + i.ToString(),
                Name = $"{NamesPart1[i % NamesPart1.Length]} {i} Tranche {Tranches[i % Tranches.Length]} CLO",
                Currency = Currencies[i % Currencies.Length]
            });
        }
    }
}
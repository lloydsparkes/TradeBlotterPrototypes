using TradeBlotter.Model;

namespace TradeBlotter.Services;

public class TradeService
{
    private readonly InstrumentService _instrumentService;
    public List<Trade> Trades { get; set; } = new List<Trade>();

    private string[] Funds = new[]
        { "FundA", "FundB", "FundC", "FundD", "AL_ONE", "WAREHOUSE2023", "BIN", "Liquidate" };

    private string[] Counterparties = new[]
    {
        "EastLodge", "Barclays", "JPMorgan", "GoldmansSacs", "SalmonBrothers", "Stratton", "Scion", "Robbie"
    };

    public TradeService(InstrumentService instrumentService)
    {
        
        _instrumentService = instrumentService;
        
        var random = new Random();
        var instrument = _instrumentService.Instruments[random.Next(_instrumentService.Instruments.Count)];
        for (var i = 0; i < 10000; i++)
        {
            Trades.Add(new Trade
            {
                TradeId = i,
                InstrumentId = instrument.Id,
                Fund = Funds[i % Funds.Length],
                Counterparty = Counterparties[i % Counterparties.Length],
                Currency = instrument.Currency,
                OriginalFace = random.Next(1_000_000_000),
                Price = Convert.ToDecimal(random.NextDouble() * 100),
                PoolFactor = Convert.ToDecimal(random.NextDouble())
            });
        }
    }
    
    public void AddTrade(Trade newTrade)
    {
        Trades.Add(newTrade);
    }
}
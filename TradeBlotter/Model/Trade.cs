namespace TradeBlotter.Model;

public class Trade
{
    public int TradeId { get; set; }
    public string InstrumentId { get; set; }
    public string Fund { get; set; }
    public string Counterparty { get; set; }
    public string Currency { get; set; }
    public decimal OriginalFace { get; set; }
    public decimal Price { get; set; }
    public decimal PoolFactor { get; set; }

    public decimal Proceeds => OriginalFace * Price * PoolFactor * 0.01m;
    public decimal ProceedsUsd => Currency == "USD" ? Proceeds : Proceeds * 1.4m;
}
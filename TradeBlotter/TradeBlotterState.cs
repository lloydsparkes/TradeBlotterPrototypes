namespace TradeBlotter;

public class TradeBlotterState
{
    private static readonly Lazy<TradeBlotterState> lazy =
        new Lazy<TradeBlotterState>(() => new TradeBlotterState());

    public static TradeBlotterState Instance { get { return lazy.Value; } }

    private TradeBlotterState()
    {
        
    }
    
    
}
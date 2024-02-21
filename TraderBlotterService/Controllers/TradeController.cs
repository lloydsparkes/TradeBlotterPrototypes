using Microsoft.AspNetCore.Mvc;
using TradeBlotter.Model;

namespace TraderBlotterService.Controllers;

[ApiController]
[Route("trades")]
public class TradeController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Trade> GetTrades()
    {
        return TradeBlotter.TradeBlotterState.Instance.TradeService.Trades;
    }
}
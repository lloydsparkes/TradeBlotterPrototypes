using Microsoft.AspNetCore.Mvc;
using TradeBlotter.Model;

namespace TraderBlotterService.Controllers;

[ApiController]
[Route("instruments")]
public class InstrumentController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Instrument> Get()
    {
        return TradeBlotter.TradeBlotterState.Instance.InstrumentService.Instruments;
    }

    [HttpGet("search")]
    public IEnumerable<Instrument> Search(string search)
    {
        if (string.IsNullOrEmpty(search)) return Get();

        return TradeBlotter.TradeBlotterState.Instance.InstrumentService.Instruments
            .Where(x => x.Name.Contains(search)).ToList();
    }
}
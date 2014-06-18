using My2AccountsInAGlance.Model;
using System.Collections.Generic;

namespace My2AccountsInAGlance.Repository
{
    public interface IMarketsAndNewsRepository
    {
        MarketQuotes GetMarkets();
        List<TickerQuote> GetMarketTickerQuotes();
        List<string> GetMarketNews();
    }
}

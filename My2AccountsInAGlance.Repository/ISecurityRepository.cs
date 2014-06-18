using My2AccountsInAGlance.Model;
using System.Collections.Generic;

namespace My2AccountsInAGlance.Repository
{
    public interface ISecurityRepository
    {
        Security GetSecurity(string symbol);
        List<TickerQuote> GetSecurityTickerQuotes();
        OperationStatus UpdateSecurities();
    }
}

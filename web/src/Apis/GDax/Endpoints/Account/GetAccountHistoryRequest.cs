using Apis.GDax.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apis.GDax.Endpoints.Account
{
    public class GetAccountHistoryRequest : ExchangePageableRequestBase
    {
        public GetAccountHistoryRequest(string accountId) : base("GET")
        {
            if (String.IsNullOrWhiteSpace(accountId))
                throw new ArgumentNullException("accountId");

            var urlFormat = String.Format("/accounts/{0}/ledger", accountId);
            this.RequestUrl = urlFormat;
        }
    }
}

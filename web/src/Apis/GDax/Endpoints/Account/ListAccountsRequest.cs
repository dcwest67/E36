using Apis.GDax.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apis.GDax.Endpoints.Account
{
    public class ListAccountsRequest : ExchangePageableRequestBase
    {
        public ListAccountsRequest(
            string accountId = null,
            string cursor = null,
            long recordCount = 100,
            RequestPaginationType paginationType = RequestPaginationType.After) : base("GET")
        {
            var urlFormat = String.Format("/accounts/{0}", accountId ?? String.Empty);
            this.RequestUrl = urlFormat;
        }
    }
}

using Apis.GDax.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apis.GDax.Endpoints.Fills
{
    public class GetFillsRequest : ExchangePageableRequestBase
    {
        public GetFillsRequest()
            : base("GET")
        {
            var urlFormat = String.Format("/fills");
            this.RequestUrl = urlFormat;
        }
    }
}

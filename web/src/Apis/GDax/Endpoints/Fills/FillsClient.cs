using Apis.GDax.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apis.GDax.Endpoints.Fills
{
    public class FillsClient : ExchangeClientBase
    {
        public FillsClient(CBAuthenticationContainer authenticationContainer) : base(authenticationContainer)
        {

        }

        public async Task<GetFillsResponse> GetFills()
        {
            var request = new GetFillsRequest();
            var response = await this.GetResponse(request);
            var accountHistoryResponse = new GetFillsResponse(response);
            return accountHistoryResponse;
        }
    }
}

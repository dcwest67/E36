using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using RestSharp;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Linq;
using Apis.GDax.Core;
using Apis.GDax.Endpoints.Account;

namespace Apis.GDax
{
    public class GDaxApiService
    {
        AccountClient client;
        public GDaxApiService(string apiKey, string passphrase, string secret)
        {
            client = new AccountClient(new CBAuthenticationContainer(apiKey, passphrase, secret));
        }

        public void Ping()
        {
            var result = client.ListAccounts().Result;

            foreach (var account in result.Accounts)
            {
                Console.WriteLine(account.ToString());
            }
        }
    }
}
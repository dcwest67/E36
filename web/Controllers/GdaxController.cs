using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apis.GDax;
using Apis.GDax.Core;
using Apis.GDax.Endpoints.Account;
using DbService;
using DbService.Models;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{



    [Route("api/[controller]")]
    public class GdaxController : Controller
    {
        private AccountClient client;

        // GET api/values
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            var gdax = DocumentDBRepository<Integration>.GetItemsAsync(d => d.Name == "Gdax").Result.FirstOrDefault();
             var service = new AccountClient(new CBAuthenticationContainer(gdax.ApiKey, gdax.Nonce, gdax.ApiSecret));
             var accounts = service.ListAccounts().Result;
             return accounts.Accounts;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

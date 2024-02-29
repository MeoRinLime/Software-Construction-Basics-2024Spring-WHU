using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class OrderController : ApiController
    {
        public List<String> GetOrders()
        {
            return new List<string> { "jia","li"};
        }
    }
}

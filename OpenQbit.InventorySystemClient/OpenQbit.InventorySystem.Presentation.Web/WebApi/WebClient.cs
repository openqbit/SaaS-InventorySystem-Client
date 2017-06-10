using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Http;
using OpenQbit.InventorySystem.Presentation.Web.Models;
using System.Web.Script.Serialization;
using System.Threading.Tasks;

namespace OpenQbit.InventorySystem.Presentation.Web.WebApi
{
    public class WebClient
    {
        HttpClient _client;
        JavaScriptSerializer _jsonSerializer = new JavaScriptSerializer();

        public WebClient()
        {
            _client = new HttpClient();
        }
    }
}
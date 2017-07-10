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
        string url = "http://localhost:51622/api";

        public WebClient()
        {
            _client = new HttpClient();
        }

        public async Task<bool> LoginCustomer(string userName,string password)
        {
            bool isSuccess = false;


            using (var response = await _client.GetAsync(url+"/ApiLoggin/SearchCustomerByUserName?userName="+userName+"&password="+password))
            {
                if (response.IsSuccessStatusCode)
                {
                    if (response.Equals(true))
                    {
                        isSuccess = true;
                    }
                }
            }


            return isSuccess;

        }
    }
}
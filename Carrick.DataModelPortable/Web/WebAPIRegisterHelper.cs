using Newtonsoft.Json;
using Carrick.DataModel;
using System;
using System.Globalization;
using System.Net.Http;
using System.Net;
using System.Text;

namespace Carrick.ClientData.Web
{
    public class WebAPIRegisterHelper
    {

        private string relativepath = "";
        private HttpClient client;

        internal WebAPIRegisterHelper(HttpClient client, string relativepath)
        {
            this.client = client;
            this.relativepath = relativepath;
        }

        private DataStoredResponse DeserializeObject(HttpResponseMessage response)
        {
            DataStoredResponse data = JsonConvert.DeserializeObject<DataStoredResponse>(response.Content.ReadAsStringAsync().Result);
            return data;
        }

        class creds
        {
            //String Email = "wilstonPersons@gmail.com";
            //String Password = "*******";
            //String ConfirmPassword = "*******";
        }

        internal Object Register()
        {
            creds obj = new creds();
            HttpResponseMessage response = client.PostAsJsonAsync(client.BaseAddress.ToString() + "api/Account", obj)
                .ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode()).Result;
            return DeserializeObject(response);
        }

    }
}



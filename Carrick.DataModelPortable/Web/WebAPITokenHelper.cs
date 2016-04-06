using Newtonsoft.Json;
using ScoutDataModelPortable.Model;
using System;
using System.Globalization;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ScoutDataModelPortable.Web
{
    public class WebAPITokenHelper
    {

        private string relativepath = "";
        private HttpClient client;
        private LoginTokenResult token;

        public string Token { get { return token.AccessToken; }}

        internal WebAPITokenHelper(HttpClient client, string relativepath)
        {
            this.client = client;
            this.relativepath = relativepath;
        }

        private DataStoredResponse DeserializeObject(HttpResponseMessage response)
        {
            DataStoredResponse data = JsonConvert.DeserializeObject<DataStoredResponse>(response.Content.ReadAsStringAsync().Result);
            return data;
        }

        public void LoadLoginToken(string username, string password)
        {
            token = GetLoginToken(username, password);
        }

        private LoginTokenResult GetLoginToken(string username, string password)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(relativepath);
            //TokenRequestViewModel tokenRequest = new TokenRequestViewModel() { 
            //password=userInfo.Password, username=userInfo.UserName};
            HttpResponseMessage response =
                client.PostAsync("Token",
                new StringContent(string.Format("grant_type=password&username={0}&password={1}",
                    WebUtility.UrlEncode(username),
                    WebUtility.UrlEncode(password)), Encoding.UTF8,
                    "application/x-www-form-urlencoded")).Result;

            string resultJSON = response.Content.ReadAsStringAsync().Result;
            LoginTokenResult result = JsonConvert.DeserializeObject<LoginTokenResult>(resultJSON);

            return result;
        }

            public class LoginTokenResult
        {
            public override string ToString()
            {
                return AccessToken;
            }

            [JsonProperty(PropertyName = "access_token")]
            public string AccessToken { get; set; }

            [JsonProperty(PropertyName = "error")]
            public string Error { get; set; }

            [JsonProperty(PropertyName = "error_description")]
            public string ErrorDescription { get; set; }
        }
    }
}



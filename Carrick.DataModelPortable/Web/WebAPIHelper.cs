
using Newtonsoft.Json;
using Carrick.DataModel;
using System;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

namespace Carrick.ClientData.Web
{
    public class WebAPIHelper<Z>
    {


        private string relativepath = "";
        private HttpClient client;

        internal WebAPIHelper(HttpClient client, string relativepath)
        {
            this.client = client;
            this.relativepath = relativepath;
        }

        //internal Z[] GetSync(DateTime? syncdatetime)
        //{
        //    return GetSync<T>(syncdatetime);
        //}

        internal Z[] Get(string Id = "")
        {

            Z[] data = new Z[0];

            if (Id == "")
            {
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + "api/" + relativepath + "/getallitems").Result;


                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    data = JsonConvert.DeserializeObject<Z[]>(response.Content.ReadAsStringAsync().Result);
                }
            }
            else
            {
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + "api/" + relativepath + "/getitem" + Id).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Z obj = JsonConvert.DeserializeObject<Z>(response.Content.ReadAsStringAsync().Result);
                    data = new Z[1];
                    data[0] = obj;
                }
            }
            return data;
        }


        internal Z[] GetSync(DateTime? syncdatetime)
        {
            
            Z[] data = new Z[0];

            if (syncdatetime == null)
            {
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + relativepath + "/getallitems").Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    data = JsonConvert.DeserializeObject<Z[]>(response.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new Exception(response.RequestMessage 
                        + Environment.NewLine 
                        + response.StatusCode.ToString());
                }
            }
            else
            {

                //+ ""
                String s = client.BaseAddress + relativepath + "/getupdateditems/"
                    + WebUtility.UrlEncode(syncdatetime.Value.ToString("s", CultureInfo.InvariantCulture));

                HttpResponseMessage response = client.GetAsync(s).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    data = JsonConvert.DeserializeObject<Z[]>(response.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString() + ' ' + s);
                }

            }
            return data;
        }

        private DataStoredResponse DeserializeObject(HttpResponseMessage response)
        {
            DataStoredResponse data = JsonConvert.DeserializeObject<DataStoredResponse>(response.Content.ReadAsStringAsync().Result);
            return data;
        }

        internal DataStoredResponse Insert(Z obj)
        {
            HttpResponseMessage response = client.PostAsJsonAsync(client.BaseAddress.ToString() + relativepath, obj)
                .ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode()).Result;
            return DeserializeObject(response);
        }

        internal DataStoredResponse Update(int id, Z obj)
        {
            HttpResponseMessage response = client.PutAsJsonAsync(client.BaseAddress.ToString() + relativepath + '/' + id.ToString(), obj)
                 .ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode()).Result;
            return DeserializeObject(response);
        }

        internal DataStoredResponse Delete(int id)
        {
            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress.ToString() + relativepath + id.ToString()).Result;
            return DeserializeObject(response);
        }
    }
}

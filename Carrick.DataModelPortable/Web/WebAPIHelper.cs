
using Newtonsoft.Json;
using Carrick.DataModel;
using System;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ScoutDataModelPortable.Web
{
    public class WebAPIHelper<T>
    {


        private string relativepath = "";
        private HttpClient client;

        internal WebAPIHelper(HttpClient client, string relativepath)
        {
            this.client = client;
            this.relativepath = relativepath;
        }

        internal T[] GetSync(DateTime? syncdatetime)
        {
            return GetSync<T>(syncdatetime);
        }

        private Z[] Get<Z>(string Id = "")
        {

            Z[] data = new Z[0];

            if (Id == "")
            {
                

                HttpResponseMessage response = client.GetAsync(client.BaseAddress + relativepath).Result;
               
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    data = JsonConvert.DeserializeObject<Z[]>(response.Content.ReadAsStringAsync().Result);
                }
            }
            else
            {
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + relativepath + Id).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Z obj = JsonConvert.DeserializeObject<Z>(response.Content.ReadAsStringAsync().Result);
                    data = new Z[1];
                    data[0] = obj;
                }
            }
            return data;
        }


        private Z[] GetSync<Z>(DateTime? syncdatetime)
        {

            Z[] data = new Z[0];

            if (syncdatetime == null)
            {
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + relativepath).Result;
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
                String s = client.BaseAddress + relativepath + "?updatetimestamp=" + syncdatetime.Value.ToString("s", CultureInfo.InvariantCulture);
                HttpResponseMessage response = client.GetAsync(s).Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    data = JsonConvert.DeserializeObject<Z[]>(response.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }

            }
            return data;
        }

        private DataStoredResponse DeserializeObject(HttpResponseMessage response)
        {
            DataStoredResponse data = JsonConvert.DeserializeObject<DataStoredResponse>(response.Content.ReadAsStringAsync().Result);
            return data;
        }

        internal DataStoredResponse Insert(T obj)
        {
            HttpResponseMessage response = client.PostAsJsonAsync(client.BaseAddress.ToString() + relativepath, obj)
                .ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode()).Result;
            return DeserializeObject(response);
        }

        internal DataStoredResponse Update(int id, T obj)
        {
            HttpResponseMessage response = client.PutAsJsonAsync(client.BaseAddress.ToString() + relativepath + '/' + id.ToString(), obj)
                 .ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode()).Result;
            return DeserializeObject(response);
        }

        internal DataStoredResponse Delete(int id)
        {
            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress.ToString() + '/' + id.ToString()).Result;
            return DeserializeObject(response);
        }
    }
}

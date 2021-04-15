using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace QBalanceDesktop
{
    internal class WebApiClient : IDisposable
    {

        private bool _isDispose;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (!_isDispose)
            {

                if (disposing)
                {

                }
            }

            _isDispose = true;
        }

        private void SetHeaderParameters(WebClient client)
        {
            client.Headers.Clear();
            client.Headers.Add("Content-Type", "application/json");
            client.Headers.Add("Accept", "application/json");
            client.Headers.Add("User-Agent: Other");
        }

        public async Task<T> PostJsonWithModelAsync<T>(string address, string data)
        {
            using (var client = new GZipWebClient())
            {
                SetHeaderParameters(client);
                string result = client.UploadString(address, "POST", data);

                // Response Headers
                WebHeaderCollection myWebHeaderCollection = client.ResponseHeaders;
                var lst = new List<string>();
                for (int i = 0; i < myWebHeaderCollection.Count; i++)
                    lst.Add("\t" + myWebHeaderCollection.GetKey(i) + " = " + myWebHeaderCollection.Get(i));
                string reponseHeaders = String.Join(Environment.NewLine, lst);


                dynamic jdata = JObject.Parse(result);
                var tt = jdata.success.ToString();
                return JsonConvert.DeserializeObject<T>(result);
            }
        }

        public async Task<string> PostJsonAsync(string address, string data)
        {
            using (var client = new GZipWebClient())
            {
                SetHeaderParameters(client);
                string result = client.UploadString(address, "POST", data);

                // Response Headers
                WebHeaderCollection myWebHeaderCollection = client.ResponseHeaders;
                var lst = new List<string>();
                for (int i = 0; i < myWebHeaderCollection.Count; i++)
                    lst.Add("\t" + myWebHeaderCollection.GetKey(i) + " = " + myWebHeaderCollection.Get(i));
                string reponseHeaders = String.Join(Environment.NewLine, lst);


                dynamic jdata = JObject.Parse(result);
                var tt = jdata.success.ToString();
                return result;
            }
        }
    }
}
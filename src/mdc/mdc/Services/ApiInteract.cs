using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.Devices.SmartCards;
using Newtonsoft.Json;
using mdc.Templates;

namespace mdc.Services
{
    internal static class ApiInteract
    {
	    public async static Task<string> PostCompanyDataIn(string name, string missionStatement)
	    {
			var postData = new List<KeyValuePair<string, string>>();
			postData.Add(new KeyValuePair<string, string>("mission_statement", missionStatement));
			postData.Add(new KeyValuePair<string, string>("name", name));

		    return await HTTPPost("http://mdump.herokuapp.com/companies", postData);
	    }
	    public async static Task<ObservableCollection<mdc.Templates.SummaryReturn.Root>> GetSummaryDecoded(string company)
	    {
		    var x = await HttpGet("http://mdump.herokuapp.com/sample.json?name=" + company);

		    var y = JsonConvert.DeserializeObject<ObservableCollection<mdc.Templates.SummaryReturn.Root>>(x);

		    //throw new NotImplementedException();

		    return y;
	    }
		public async static Task<string> GetSummaryRaw(string company)
		{
			var x = await HttpGet("http://mdump.herokuapp.com/sample.json?name=" + company);

			return x;
		}

        private static async Task<string> HttpGet(string urlIn)
        {
            var request = (HttpWebRequest) WebRequest.Create(urlIn);
            request.Accept = "application/json";

            WebResponse response = await request.GetResponseAsync();

            string temp;

            using (Stream stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
                temp = reader.ReadToEnd();
            return temp;
        }

	    private static async Task<string> HTTPPost(string urlIn, List<KeyValuePair<string, string>> postData)
	    {

			var cred = new NetworkCredential(mdc.Secrets.username, mdc.Secrets.password);
		    var credcache = new CredentialCache {{new Uri(urlIn), "Basic", cred}};

		    HttpResponseMessage response;
		    using (var handler = new HttpClientHandler {Credentials = credcache} )
		    {
				var httpClient = new HttpClient(handler);
				HttpContent content = new FormUrlEncodedContent(postData);
				response = await httpClient.PostAsync(urlIn, content);
		    }
		    return response.StatusCode.ToString();
	    }
    }
}
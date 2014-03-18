using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Devices.SmartCards;
using Newtonsoft.Json;
using mdc.Templates;
using mdc.Services;

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
	    public async static Task<List<mdc.Templates.SummaryReturn.Root>> GetSummaryDecoded(string company)
	    {
			var x = await HttpGet("http://mdump.herokuapp.com/search/" + company.Trim().Replace(" ", "_") + ".json");

		    var y = JsonConvert.DeserializeObject<List<mdc.Templates.SummaryReturn.Root>>(x);

		    //throw new NotImplementedException();

		    return y;
	    }
		public async static Task<string> GetSummaryRaw(string company)
		{
			var test = company.Trim().Replace(" ", "_") + ".json";
			var x = await HttpGet("http://mdump.herokuapp.com/search/" + test );

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
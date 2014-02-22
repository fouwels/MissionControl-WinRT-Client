using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using mdc.Templates;

namespace mdc.Services
{
    internal static class ApiInteract
    {
	    public async static Task PostCompanyDataIn()
	    {
		    
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
    }
}
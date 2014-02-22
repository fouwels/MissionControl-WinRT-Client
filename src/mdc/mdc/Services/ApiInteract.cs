using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using mdc.Templates;

namespace mdc.Services
{
    internal class ApiInteract
    {
	    public Task<mdc.Templates.SummaryReturn.Root> GetSummary(string company)
	    {
		    //HttpGet(*url*)
			throw new NotImplementedException();
	    }

        private async Task<string> HttpGet(string urlIn)
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
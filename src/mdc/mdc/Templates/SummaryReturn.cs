using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdc.Templates
{
	public class SummaryReturn
	{
		public class NewsSource
		{
			public int id { get; set; }
			public int company_id { get; set; }
			public string name { get; set; }
			public string headline { get; set; }
			public double polarity { get; set; }
			public string url { get; set; }

			public string color { get; set; }
		}

		public class Tweet
		{
			public string username { get; set; }
			public string text { get; set; }
			
			public DateTime timestamp { get; set; }
		}

		public class Root
		{
			public string name { get; set; }
			public string mission_statement { get; set; }
			public object mission_statement_proof { get; set; }
			public object mission_statement_investigator { get; set; }
			public List<NewsSource> news_sources { get; set; }
			public List<Tweet> tweets_popular { get; set; }
		}
	}
}

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
			public string name { get; set; }
			public string headline { get; set; }
			public double polarity { get; set; }
		}

		public class Root
		{
			public string name { get; set; }
			public string mission_statement { get; set; }
			public string mission_statement_proof { get; set; }
			public string mission_statement_investigator { get; set; }
			public List<NewsSource> news_sources { get; set; }
		}
	}
}

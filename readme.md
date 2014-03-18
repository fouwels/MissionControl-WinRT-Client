#'Mission Control'
Client to consume the data produced by missiondump_core + other (ie. Twitter)

Currently fully populates an object as per below for each company, most of which is displayed in UI?

```csharp

public class Root
{
	public string name { get; set; }
	public string mission_statement { get; set; }
	public object mission_statement_proof { get; set; }
	public object mission_statement_investigator { get; set; }
	public List<NewsSource> news_sources { get; set; }
	public List<Tweet> tweets_popular { get; set; }
}

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

'''
### Requires:
* Json.net
* LinqToTwitter
* .NET 4.5 for WinRT

### Status
***
Working?

###Example:
(Very unlikely to be current)

![ui](http://i.imgur.com/FGFnfOc.png)

Code is good, UI is crap.
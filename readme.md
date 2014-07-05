#'Mission Control'
Client to consume the data produced by missiondump_core (https://github.com/atleastimtrying/missiondump) and others.

We make use the mission statement data from above, along with news stories, twitter interaction and Sentiment Analysis on said stories to generate an overview of a Company, with the aim to allow for quick and easy comparison. Currently this is rather limited with the news aspect only hooked into one source, the aim would be to expand this, as well as add more functionality to compare and generate an overview of several desired companies, for example an overview of all the companies producing x product, or invested in y economic sector/

Currently fully populates an object as per below for each company, most of which is displayed in UI.

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

```

### Requires: (Use NuGET)
* Json.net
* LinqToTwitter
* .NET 4.5 for WinRT

### Status
***
Working?

###Example:
(Very unlikely to be current)

![ui](http://i.imgur.com/AgMSPJb.png)

Code is hack code but usable, UI needs work.

Kaelan Fouwels 2014 - @kfouwels on Twitter, Github and Outlook.

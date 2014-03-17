using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToTwitter;

namespace mdc.Services
{
	class TwitterInteract
	{
		async void GetTweets(string query, IAuthorizer auth) //lol oauth
		{
			var twitterCtx = new TwitterContext(auth);
			var searchResults =
				twitterCtx.Search.Where(search => search.Type == SearchType.Search
				                                  && search.Query == query);

			var searched = searchResults.SingleOrDefault();
		}
	}
}

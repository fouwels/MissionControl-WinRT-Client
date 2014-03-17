using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToTwitter;

namespace mdc.Services
{
	static class TwitterInteract
	{

		public async static Task<IAuthorizer> GetAuth()
		{
			var auth = new ApplicationOnlyAuthorizer
			{
				CredentialStore = new InMemoryCredentialStore()
				{
					ConsumerKey = Secrets.twitterConsumerKey,
					ConsumerSecret = Secrets.twitterConsumerSecret
				}
			};

			await auth.AuthorizeAsync();
			return auth;
		}

		public async static Task<LinqToTwitter.Search> Search(IAuthorizer auth, string query, ResultType resultType) //lol oauth
		{
			var twitterCtx = new TwitterContext(auth);

			var srch = await (from search in twitterCtx.Search where search.Type == SearchType.Search && search.Query == query && search.ResultType == resultType select search).SingleOrDefaultAsync();

			//DEBUG
			Debug.WriteLine("\nQuery: {0}\n", srch.SearchMetaData.Query);
			foreach (var status in srch.Statuses)
			{
				Debug.WriteLine("\n" + status.Text);
			}

			return srch;
		}
	}
}

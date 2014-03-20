using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using LinqToTwitter;
using mdc.Pages;
using mdc.Services;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using mdc.Templates;

namespace mdc.Pages
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	/// 
	public partial class MainPage : Page
	{
		private List<SummaryReturn.Root> _currentResultItems = new List<SummaryReturn.Root>();
		private LinqToTwitter.IAuthorizer _auth;
		private bool _areWeTwitAuthed = false;
		public List<SummaryReturn.Root> CurrentResultItems //used by xaml
		{
			get { return _currentResultItems; }
			//set { _currentResultItems = value; }
		}
		public MainPage()
		{
			this.InitializeComponent();
			this.DataContext = this;
			StartAuthHardshake();
		}

		private async void StartAuthHardshake()
		{
			_areWeTwitAuthed = false;
			this._auth = await TwitterInteract.GetAuth();
			_areWeTwitAuthed = true;
		}

		private void StartRequestSequencer()
		{
			StartRequestSequence();
		}

		private async void StartRequestSequence()
		{
			var companymash = CompanyFor.Text.ToLower();
			var companiesList = new List<string>();

			if (companymash.Contains("+"))
			{
				foreach (var company in companymash.Split('+')) { companiesList.Add(company); }
			}
			else
			{
				companiesList.Add(companymash);
			}

			FadeResultsOut.Begin();

			_currentResultItems.Clear(); //empty the bottle, reset companies
			var _tempCurrentResultItems = new List<SummaryReturn.Root>();
			var _tempCurrentResultItem = new SummaryReturn.Root();

			foreach (var company in companiesList)
			{
				_tempCurrentResultItem = (await mdc.Services.ApiInteract.GetSummaryDecoded(company))[0]; //just grab first copy of the company, no dupes.
				_tempCurrentResultItem.tweets_popular = new List<SummaryReturn.Tweet>();

				if (_areWeTwitAuthed)
				{
					var tweetObjects = await TwitterInteract.Search(_auth, company, ResultType.Popular); //grab tweets

					foreach (var tweet in tweetObjects.Statuses) //mash tweets into the root article object
					{
						_tempCurrentResultItem.tweets_popular.Add(new SummaryReturn.Tweet
						{
							text = tweet.Text,
							timestamp = tweet.CreatedAt,
							username = tweet.User.Name
						});
					}
				}
				else
				{
					Debug.WriteLine("Error, Still Authorising with TW");
					_tempCurrentResultItem.tweets_popular.Add(new SummaryReturn.Tweet { text = "Still waiting for Token from Twitter", timestamp = DateTime.Now, username = "System" });
				}
				_tempCurrentResultItems.Add(_tempCurrentResultItem); //mash back together into one list of above
			}

			foreach (var item in _tempCurrentResultItems) //strip out nulls
			{
				if (item.mission_statement_investigator == null)
				{
					item.mission_statement_investigator = "Not Verified!";
				}
				if (item.mission_statement_proof == null)
				{
					item.mission_statement_proof = "N/A";
				}

				foreach (var story in item.news_sources)
				{

					if (story.polarity > 1)
					{
						story.color = new SolidColorBrush(Colors.Crimson);
					}
					else if (story.polarity > 0.5)
					{
						story.color = new SolidColorBrush(Colors.DeepPink);
					}
					else if (story.polarity > 0.25)
					{
						story.color = new SolidColorBrush(Colors.LightGreen);
					}
					else if (story.polarity > 0)
					{
						story.color = new SolidColorBrush(Colors.DarkGreen);
					}
				}
				//remove from view?
			}

			//TextBlockDump.Text = string.Concat("RAW Json output:\n", await mdc.Services.ApiInteract.GetSummaryRaw(company.Split('+')[0]));
			_currentResultItems = _tempCurrentResultItems;
			ResultItemsControl.ItemsSource = CurrentResultItems;
			FadeResultsIn.Begin();

		}
		private async void CompanyFor_OnKeyDown(object sender, KeyRoutedEventArgs e)
		{
			if (e.Key == VirtualKey.Enter)
			{
				StartRequestSequencer();
			}

		}

		private void AddComp_OnClick(object sender, RoutedEventArgs e)
		{
			var fr = new Frame();
			fr.Navigate(typeof(SubmitCompany));
			Window.Current.Content = fr;
			Window.Current.Activate();
		}

		private void Submit_OnClick(object sender, RoutedEventArgs e)
		{
			StartRequestSequencer();
		}
		private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var y = (SummaryReturn.NewsSource)e.AddedItems[0];
			var z = y.url;
			Windows.System.Launcher.LaunchUriAsync(new Uri(z));
		}
	}
}

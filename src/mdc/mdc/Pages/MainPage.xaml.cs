using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	    private ObservableCollection<SummaryReturn.Root> _currentResultItems = new ObservableCollection<SummaryReturn.Root>();
	    public ObservableCollection<SummaryReturn.Root> CurrentResultItems
	    {
		    get { return _currentResultItems; }
		    //set { _currentResultItems = value; }
	    }
	    public MainPage()
	    {
		    this.InitializeComponent();
	    }

	    private async void StartRequestSequence()
	    {
		    var company = CompanyFor.Text;
			_currentResultItems = await mdc.Services.ApiInteract.GetSummaryDecoded(company);

		    foreach (var item in _currentResultItems)
		    {
			    if (item.mission_statement_investigator == null){item.mission_statement_investigator = "Not Verified!";}
				if (item.mission_statement_proof == null) { item.mission_statement_proof = "N/A"; }
				//remove from view?
		    }
			
		    TextBlockDump.Text = string.Concat("RAW Json output:\n", await mdc.Services.ApiInteract.GetSummaryRaw(company));

		    this.DataContext = this;
	    }
	    private async void CompanyFor_OnKeyDown(object sender, KeyRoutedEventArgs e)
	    {
			if (e.Key == VirtualKey.Enter)
			{
				StartRequestSequence();
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
		    StartRequestSequence();
	    }
    }
}

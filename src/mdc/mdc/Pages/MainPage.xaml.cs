using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using mdc.Services;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using mdc.Templates;

namespace mdc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
	    private List<SummaryReturn.Root> currentResultItems;
        public MainPage()
        {
            this.InitializeComponent();

	        ResultItemsControl.DataContext = currentResultItems;
	        //testRquest();
        }

		//public async void testRquest()
		//{
		//	var x = await mdc.Services.ApiInteract.GetSummary("test");
		//}

	    private async void StartRequestSequence()
	    {
			currentResultItems = await mdc.Services.ApiInteract.GetSummaryDecoded("test");
		    TextBlockDump.Text = await mdc.Services.ApiInteract.GetSummaryRaw("test");
	    }
	    private async void CompanyFor_OnKeyDown(object sender, KeyRoutedEventArgs e)
	    {
			if (e.Key == VirtualKey.Enter)
			{
				StartRequestSequence();
			}
			
	    }
    }
}

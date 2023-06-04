using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PacoteExtra.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AbasPage : Xamarin.Forms.TabbedPage
    {
		public AbasPage ()
		{
			InitializeComponent ();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }
	}
}
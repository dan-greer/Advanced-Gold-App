using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdvGold2018
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FacebookPage : ContentPage
	{
		public FacebookPage ()
		{
            InitializeComponent();
            Device.OpenUri(new Uri("https://www.facebook.com/groups/183026928882130/"));
        }
	}
}
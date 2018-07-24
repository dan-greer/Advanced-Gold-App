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
	public partial class TwitterPage : ContentPage
	{
		public TwitterPage ()
		{
			InitializeComponent ();
            Device.OpenUri(new Uri("https://twitter.com/PASCAdvGold"));
        }
	}
}
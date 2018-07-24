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
    public partial class SchedulePage : TabbedPage
    {
        public SchedulePage()
        {
            InitializeComponent();

            switch (int.Parse(DateTime.Now.Day.ToString()))
            {

                case 16:
                    this.CurrentPage = this.Children[1];
                    break;
                case 17:
                    this.CurrentPage = this.Children[2];
                    break;
                case 18:
                    this.CurrentPage = this.Children[3];
                    break;
                case 19:
                    this.CurrentPage = this.Children[4];
                    break;
                case 20:
                    this.CurrentPage = this.Children[5];
                    break;
                case 21:
                    this.CurrentPage = this.Children[6];
                    break;

                default:
                    this.CurrentPage = this.Children[0];
                    break;
            }
        }
    }
}
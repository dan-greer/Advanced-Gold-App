using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdvGold2018
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotesItemPage : ContentPage
	{
		public NotesItemPage ()
		{
			InitializeComponent ();
		}

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (NotesItem)BindingContext;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (NotesItem)BindingContext;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
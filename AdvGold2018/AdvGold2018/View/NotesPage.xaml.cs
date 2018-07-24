using System;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdvGold2018
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotesPage : ContentPage
	{

        public NotesPage ()
		{
			InitializeComponent ();

        }

        public int ResumeAtTodoId { get; set; }

        protected override async void OnAppearing()
		{
			base.OnAppearing();

			listView.ItemsSource = await App.Database.GetItemsAsync();
		}

		async void OnItemAdded(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NotesItemPage
			{
				BindingContext = new NotesItem()
			});
		}

		async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
            //((App)App.Current).ResumeAtTodoId = (e.SelectedItem as TodoItem).ID;
            //Debug.WriteLine("setting ResumeAtTodoId = " + (e.SelectedItem as TodoItem).ID);
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NotesItemPage
                {
                    BindingContext = e.SelectedItem as NotesItem
                });
            }
		}
	}
}
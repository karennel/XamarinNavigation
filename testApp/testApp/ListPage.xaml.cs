using Notes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace testApp
{
	public partial class ListPage : ContentPage
	{

		List<ListItem> listitems;

		public ListPage()
		{
			InitializeComponent();

			listitems = new List<ListItem>();

			NavigationPage.SetHasNavigationBar(this, false);
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var listitems = new List<ListItem>();

			listitems.Add(new ListItem { Text = "Item1" });
			listitems.Add(new ListItem { Text = "Item2" });
			listitems.Add(new ListItem { Text = "Item3" });
			listitems.Add(new ListItem { Text = "Item4" });
			listitems.Add(new ListItem { Text = "Item5" });

			listView.ItemsSource = listitems
					.ToList();
		}

		async void OnBackButtonClicked(object sender, EventArgs e)
		{
			await Application.Current.MainPage.Navigation.PopAsync();
		}

		protected override bool OnBackButtonPressed()
		{
			return false;
		}

		public void OnTest(object sender, EventArgs e)
		{
			DisplayAlert("Testing", "Testing message", "OK");
		}

		void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				DisplayAlert("Selected", "", "OK");
			}
		}
	}
}
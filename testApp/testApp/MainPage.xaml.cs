using System;
using Xamarin.Forms;

namespace testApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		async void OnEnterButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ListPage());
		}
	}
}

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testApp.ViewModels
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class View1 : ContentView
	{
		public View1()
		{
			InitializeComponent();
			BindingContext = new View1ViewModel();
		}
	}
}
namespace testApp.ViewModels
{
	public class View1ViewModel
	{

		public string displayvalue => GetDisplayValue();

		string GetDisplayValue()
		{
			return "The display value";
		}

		string _labelcontent;
		string LabelContent
		{
			get { return _labelcontent; }
			set { _labelcontent = value; }
		}

		public View1ViewModel()
		{

		}
	}
}

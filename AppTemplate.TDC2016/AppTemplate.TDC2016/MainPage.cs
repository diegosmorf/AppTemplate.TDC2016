using LoginPattern;
using Xamarin.Forms;

namespace AppTemplate.TDC2016
{
	public class MainPage : MasterDetailPage
	{
		public MainPage ()
		{
			Master = new MenuPage ();
			Detail = new DetailPage ();
		}
	}
}


using System;
using AppTemplate.TDC2016;
using Xamarin.Forms;

namespace LoginPattern
{
	public class MenuPage : ContentPage
	{
		MasterDetailPage master;

		TableView tableView;

		public MenuPage ()
		{
			Title = "TDC2016";
			Icon = "slideout.png";

			var section = new TableSection () {
				new TextCell {Text = "Sessão"},
				new TextCell {Text = "Palestrantes"},
				new TextCell {Text = "Favoritos"},
				new TextCell {Text = "Salas"},
				new TextCell {Text = "Mapa"},
			};

			var root = new TableRoot () {section} ;

			tableView = new TableView ()
			{ 
				Root = root,
				Intent = TableIntent.Menu,
			};

			var logoutButton = new Button { Text = "Sair" };
			logoutButton.Clicked += (sender, e) => {
				App.Current.Logout();
			};

			Content = new StackLayout {
				BackgroundColor = Color.Gray,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					tableView, 
					logoutButton
				}
			};
		}


	}
}


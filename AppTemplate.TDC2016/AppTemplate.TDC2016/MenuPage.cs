using Xamarin.Forms;

namespace AppTemplate.TDC2016
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Title = "TDC2016";
            Icon = "slideout.png";

            var section = new TableSection
            {
                new TextCell {Text = "Sessão"},
                new TextCell {Text = "Palestrantes"},
                new TextCell {Text = "Favoritos"},
                new TextCell {Text = "Salas"},
                new TextCell {Text = "Mapa"}
            };

            var root = new TableRoot {section};

            var tableView = new TableView
            {
                Root = root,
                Intent = TableIntent.Menu
            };

            var logoutButton = new Button {Text = "Sair"};
            logoutButton.Clicked += (sender, e) => { App.Current.Logout(); };

            Content = new StackLayout
            {
                BackgroundColor = Color.Gray,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    tableView,
                    logoutButton
                }
            };
        }
    }
}
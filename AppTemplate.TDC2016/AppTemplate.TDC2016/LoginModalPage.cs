using LoginPattern;
using Xamarin.Forms;

namespace AppTemplate.TDC2016
{
	public class LoginModalPage : CarouselPage
	{
		ContentPage login, create;
		public LoginModalPage (ILoginManager ilm)
		{
			login = new LoginPage (ilm);
			create = new CreateAccountPage (ilm);
			this.Children.Add (login);
			this.Children.Add (create);

			MessagingCenter.Subscribe<ContentPage> (this, "Login TDC 2016", (sender) => {
				this.SelectedItem = login;
			});
			MessagingCenter.Subscribe<ContentPage> (this, "Cadastrar", (sender) => {
				this.SelectedItem = create;
			});
		}
	}
}


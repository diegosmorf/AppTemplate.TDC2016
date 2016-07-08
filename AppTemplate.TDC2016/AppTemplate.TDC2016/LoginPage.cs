using System;
using Xamarin.Forms;

namespace AppTemplate.TDC2016
{
	public class LoginPage : ContentPage
	{
	    protected readonly Entry Username;
	    protected readonly Entry Password;

	    public LoginPage (ILoginManager ilm)
		{
			var button = new Button { Text = "Entrar" };
			button.Clicked += (sender, e) => {
				if (String.IsNullOrEmpty(Username.Text) || String.IsNullOrEmpty(Password.Text))
				{
					DisplayAlert("Erro de Validação", "Usuário e senha são campos obrigatórios", "Tente Novamente");
				} else {
					// REMEMBER LOGIN STATUS!
					App.Current.Properties["IsLoggedIn"] = true;
					ilm.ShowMainPage();
				}
			};
			var create = new Button { Text = "Cadastrar novo usuário" };
			create.Clicked += (sender, e) => {
				MessagingCenter.Send<ContentPage> (this, "Cadastrar");
			};

            var imageSource = ImageSource.FromFile("tdc2016sampa-eu-vou.png");
            
            Username = new Entry { Text = "" };
			Password = new Entry { Text = "" };
			Content = new StackLayout { 
				//Padding = new Thickness (10, 40, 10, 10),
				Children = {

                    new Label { Text = "Login", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) }, 
					new Label { Text = "Usuário" },
					Username,
					new Label { Text = "Senha" },
					Password,
					button, create,
                    new Image {Source = imageSource}
                }
			};
		}
	}
}


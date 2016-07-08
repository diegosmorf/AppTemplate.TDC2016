using Xamarin.Forms;

namespace AppTemplate.TDC2016
{
    public class CreateAccountPage : ContentPage
    {
        public CreateAccountPage(ILoginManager ilm)
        {
            var button = new Button {Text = "Criar novo usuário"};
            button.Clicked += (sender, e) =>
            {
                DisplayAlert("Sucesso.", "Novo usuário criado com sucesso.", "OK");
                ilm.ShowMainPage();
            };
            var cancel = new Button {Text = "Cancelar"};
            cancel.Clicked += (sender, e) => { MessagingCenter.Send<ContentPage>(this, "Entrar"); };
            Content = new StackLayout
            {
                Padding = new Thickness(10, 40, 10, 10),
                Children =
                {
                    new Label {Text = "Cadastrar novo usuário"},
                    new Label {Text = "Escolha um usuário"},
                    new Entry {Text = ""},
                    new Label {Text = "Senha"},
                    new Entry {Text = ""},
                    new Label {Text = "Confirmação Senha"},
                    new Entry {Text = ""},
                    button, cancel
                }
            };
        }
    }
}
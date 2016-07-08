using Xamarin.Forms;

namespace AppTemplate.TDC2016.Windows.Properties
{
    public class LoginModalPage : CarouselPage
    {
        private readonly ContentPage create;
        private readonly ContentPage login;

        public LoginModalPage(ILoginManager ilm)
        {
            login = new LoginPage(ilm);
            create = new CreateAccountPage(ilm);
            Children.Add(login);
            Children.Add(create);

            MessagingCenter.Subscribe<ContentPage>(this, "Login TDC 2016", sender => { SelectedItem = login; });
            MessagingCenter.Subscribe<ContentPage>(this, "Cadastrar", sender => { SelectedItem = create; });
        }
    }
}
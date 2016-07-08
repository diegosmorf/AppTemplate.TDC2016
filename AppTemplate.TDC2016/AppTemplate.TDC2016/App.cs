using Xamarin.Forms;

namespace AppTemplate.TDC2016
{
    public class App : Application, ILoginManager
    {
        public new static App Current;

        public App()
        {
            Current = this;

            var isLoggedIn = Properties.ContainsKey("IsLoggedIn") && (bool) Properties["IsLoggedIn"];

            
            if (isLoggedIn)
                MainPage = new MainPage();
            else
                MainPage = new LoginModalPage(this);
        }

        public void ShowMainPage()
        {
            MainPage = new MainPage();
        }

        public void Logout()
        {
            Properties["IsLoggedIn"] = false; 
            MainPage = new LoginModalPage(this);
        }
    }
}
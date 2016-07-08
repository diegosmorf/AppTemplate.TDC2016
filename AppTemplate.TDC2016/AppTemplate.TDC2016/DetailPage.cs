using Xamarin.Forms;

namespace AppTemplate.TDC2016
{
	public class DetailPage : ContentPage
	{
		public DetailPage ()
		{
			BackgroundColor = new Color (0, 0, 1, 0.2);

            var text = "Versão Windows";

			if (Device.OS == TargetPlatform.Android) {
				text = @"Versão Android";
			} else if (Device.OS == TargetPlatform.WinPhone) {
                text = @"Versão Windows Phone";
            }

			Content = new StackLayout { 
				HorizontalOptions = LayoutOptions.Center,
				Padding = new Thickness (10, 40, 10, 10),
				Children = {

					new Label { Text = text }
				}
			};
		}
	}
}


namespace Groot_App_Maui;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	public async void OnClickBtn(object sender, EventArgs e)
	{
		await Application.Current.MainPage.DisplayAlert(null, "Again I am Groot :)", "OK");
	}
}


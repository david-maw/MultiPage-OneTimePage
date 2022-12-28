namespace MultiPage;

public partial class StartupPage : ContentPage
{
	public StartupPage()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        for (int i = 9; i > 0; i--)
        {
            msg.Text = i.ToString();
            await Task.Delay(1000);
        }
        await Shell.Current.GoToAsync("//FirstPage");
    }
}
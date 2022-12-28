namespace MultiPage;

public partial class OneTimePage : ContentPage
{
    public OneTimePage()
    {
        InitializeComponent();
    }
    protected async override void OnAppearing()
    {
        base.OnAppearing();

        if (App.FirstUse)
        {
            App.FirstUse = false;
            for (int i = 5; i > 0; i--)
            {
                msg.Text = i.ToString();
                await Task.Delay(1000);
            }
        }
#if WINDOWS // Workaround to avoid crash in Windows, not needed in Android 
        //else
        //    await Task.Delay(1);
#endif
        await Shell.Current.GoToAsync("//StartupPage");
    }
}
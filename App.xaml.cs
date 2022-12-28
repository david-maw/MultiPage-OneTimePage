namespace MultiPage;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    public static bool FirstUse
    {
        get => Preferences.Get(nameof(FirstUse), true);
        set
        {
            Preferences.Set(nameof(FirstUse), value);
        }
    }
}

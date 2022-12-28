namespace MultiPage;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}
    public DateTime PageCreatedTime { get; } = DateTime.Now;

    private void MainPage_Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void Page1_Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page1());
    }

    private void Page2_Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page2());
    }

    private void SimulatedCommand(object sender, EventArgs e)
    {
        string actionText = "some";
        if (sender is Button button)
            actionText = button.CommandParameter.ToString();
        else if (sender is ToolbarItem toolbarItem)
            actionText = toolbarItem.CommandParameter.ToString();

        DisplayAlert("Simulated Action", $"'{actionText}' action for " + GetType().Name, "Cancel");
    }
}
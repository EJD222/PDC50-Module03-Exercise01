namespace Module03Exercise01.View;

public partial class OfflinePage : ContentPage
{
	public OfflinePage()
	{
		InitializeComponent();
	}
    private void OnExitButtonClicked(object sender, EventArgs e)
    {
        System.Environment.Exit(0);
    }
}
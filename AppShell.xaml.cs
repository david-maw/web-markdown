namespace web;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(HelpPage), typeof(HelpPage));
    }
    private async void OnWebPageClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = false;
        await Shell.Current.GoToAsync($"{nameof(HelpPage)}");
    }
}

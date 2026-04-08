namespace web;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Dark = true;
        OnPropertyChanged(nameof(Dark));
    }

    private async void OnWebClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = false;
        await Shell.Current.GoToAsync($"{nameof(HelpPage)}");
    }

    public bool Dark
    {
        set
        {
            if (value != Dark)
            {
                Application.Current?.UserAppTheme = value ? AppTheme.Dark : AppTheme.Light;
            }
        }
        get => Application.Current?.UserAppTheme == AppTheme.Dark || Application.Current?.RequestedTheme == AppTheme.Dark;
    }
}

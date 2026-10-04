namespace DualisPos;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OpenStockClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StockPage));
    }

    private async void OpenOrderClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(OrderPage));
    }

    private async void OpenSalesClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SalesPage));
    }
}
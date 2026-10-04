namespace DualisPos;

public partial class StockPage : ContentPage
{
    public StockPage()
    {
        InitializeComponent();
    }

    private async void OpenStockViewClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StockViewPage));
    }

    private async void OpenAddStockClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddStockPage));
    }

    private async void OpenAddProductClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddProductPage));
    }
}
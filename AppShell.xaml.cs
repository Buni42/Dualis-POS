namespace DualisPos;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(StockPage), typeof(StockPage));
        Routing.RegisterRoute(nameof(StockViewPage), typeof(StockViewPage));
        Routing.RegisterRoute(nameof(AddStockPage), typeof(AddStockPage));
        Routing.RegisterRoute(nameof(AddProductPage), typeof(AddProductPage));

        Routing.RegisterRoute(nameof(OrderPage), typeof(OrderPage));

        Routing.RegisterRoute(nameof(SalesPage), typeof(SalesPage));
        Routing.RegisterRoute(nameof(PosPage), typeof(PosPage));
    }
}
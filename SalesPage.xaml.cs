using System.Collections.ObjectModel;

namespace DualisPos;

public partial class SalesPage : ContentPage
{
    public ObservableCollection<string> Basket { get; } = new();

    public SalesPage()
    {
        InitializeComponent();

        BindingContext = this;
    }

    private async void AddProductClicked(object sender, EventArgs e)
    {
        string? barcode = BarcodeEntry.Text?.Trim();

        if (string.IsNullOrWhiteSpace(barcode))
        {
            await DisplayAlert(
                "Barkod Eksik",
                "Lütfen bir barkod girin.",
                "Tamam");

            return;
        }

        Basket.Add($"Barkod: {barcode}");

        BarcodeEntry.Text = string.Empty;
        BarcodeEntry.Focus();
    }

    private async void CompleteSaleClicked(object sender, EventArgs e)
    {
        if (Basket.Count == 0)
        {
            await DisplayAlert(
                "Sepet Boþ",
                "Satýþý tamamlamak için ürüne ihtiyaç var.",
                "Tamam");

            return;
        }

        await Shell.Current.GoToAsync(nameof(PosPage));
    }
}
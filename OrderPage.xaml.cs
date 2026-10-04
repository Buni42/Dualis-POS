namespace DualisPos;

public partial class OrderPage : ContentPage
{
    public OrderPage()
    {
        InitializeComponent();
    }

    private async void CreateOrderClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(BarcodeEntry.Text))
        {
            await DisplayAlert("Eksik Bilgi", "Barkod girin.", "Tamam");
            return;
        }

        await DisplayAlert(
            "Sipariþ",
            "Sipariþ iþlemi arayüz olarak hazýr. Veritabaný baðlantýsý sonraki aþamada eklenecek.",
            "Tamam");
    }
}
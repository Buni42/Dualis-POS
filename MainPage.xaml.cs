namespace DualisPos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void OnShowClicked(object sender, EventArgs e)
        {
            ResultLabel.Text = TextBox.Text;
        }

       

    }

}

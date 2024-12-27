namespace BottomSheet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenBottomSheet(object sender, EventArgs e)
        {
            bottomSheet.Show();
        }
    }
}

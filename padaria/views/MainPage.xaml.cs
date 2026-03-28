namespace padaria
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("cadastro");
        }
    }
}

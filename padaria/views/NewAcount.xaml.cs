using System.Globalization;

namespace padaria.views; 

public partial class NewAcount : ContentPage
{
    public NewAcount()
    {
        InitializeComponent();
    }

    List<User> ListUsers = new List<User>();
    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameUser.Text) ||
            string.IsNullOrWhiteSpace(CPF.Text) ||
            string.IsNullOrWhiteSpace(Number.Text) ||
            string.IsNullOrWhiteSpace(EmailUser.Text))
        {

            await DisplayAlert("WhiteSpace", "preencha todos os campos", "ok");
            return;
        }

        
            User newUser = new User();

            newUser.name = NameUser.Text;
            newUser.number = Number.Text;
            newUser.cpf = CPF.Text;
            newUser.email = EmailUser.Text;

            ListUsers.Add(newUser);



        

    }
}
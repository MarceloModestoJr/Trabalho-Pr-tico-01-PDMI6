
namespace TP01;

//Marcelo Modesto de Lima Junior            CB3015823
//Bruna Helena Silva Santos                 CB3016111

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}



    private void OnLoginClicked(object sender, EventArgs e)
    {


        var username = "admin";
        var password = "senha@dmin";

         if(UserEntry.Text == username && PassEntry.Text == password)
        {
            isLogin.Text = "Logado com Sucesso !";
        }
        else
        {
            isLogin.Text = "Usuário ou senha inválidos !";
        }



       //SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void OnClearClicked(object sender, EventArgs e)
    {

        UserEntry.Text = String.Empty;
        PassEntry.Text = String.Empty;
        UserEntry.Focus();

        // SemanticScreenReader.Announce(CounterBtn.Text);
    }



    private void OnCreditsClicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new Credits());
    }
}


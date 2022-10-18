using ENCHERE_SIO.VuesModeles;
namespace ENCHERE_SIO.Vues;

public partial class LoginVue : ContentPage
{
	LoginVueModele vueModele;
	public LoginVue()
	{
		InitializeComponent();
		BindingContext =vueModele= new LoginVueModele();
	}

    private void Visiteur_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AccueilVue(), true);
    }
	private void VerificationUserAndPass()
	{
		string password = Password.Text;
		string email = Email.Text;
		
	}
}
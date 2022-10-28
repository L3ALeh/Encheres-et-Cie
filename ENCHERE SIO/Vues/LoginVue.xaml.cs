using ENCHERE_SIO.VuesModeles;
using ENCHERE_SIO.Modeles;
namespace ENCHERE_SIO.Vues;

public partial class LoginVue : ContentPage
{
	LoginVueModele vueModele;
	public LoginVue()
	{
		InitializeComponent();
		BindingContext =vueModele= new LoginVueModele();
        motDePasseIncorect.IsVisible = false;
    }

    private void Visiteur_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AccueilVue(), true);
    }
	private void VerificationUserAndPass()
	{
		string password = Password.Text;
		string email = Email.Text;
		vueModele.GetUserByMailAndPass(new User(0,password,email,""));
		if(password == vueModele.UnUser.Password && vueModele.UnUser.Email == email)
		{
            Navigation.PushAsync(new AccueilVue(), true);
        }
		else
		{
			//Navigation.PushAsync(new AccueilVue(), false);
		}
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        VerificationUserAndPass();
		motDePasseIncorect.IsVisible = true;
    }
}
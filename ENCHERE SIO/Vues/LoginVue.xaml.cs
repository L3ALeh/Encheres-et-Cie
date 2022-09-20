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
}
using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

public partial class EnchereFlashVue : ContentPage
{
    EnchereFlashVueModele vueModele;

    public EnchereFlashVue()
	{
		InitializeComponent();
        BindingContext = vueModele = new EnchereFlashVueModele();

    }
}
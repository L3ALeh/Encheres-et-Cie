using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

public partial class EnchereInverseeVue : ContentPage
{
    EnchereInverseeVueModele vueModele;

    public EnchereInverseeVue()
	{
        InitializeComponent();
        BindingContext = vueModele = new EnchereInverseeVueModele();

    }
}
using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

public partial class AccueilVue : ContentPage
{
    AccueilVueModele vueModele;

    public AccueilVue()
	{
		InitializeComponent();
        BindingContext = vueModele = new AccueilVueModele();

    }
}
using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

using ENCHERE_SIO.VuesModeles;

public partial class AccueilVue : ContentPage
{
    AccueilVueModele vueModele;

    public AccueilVue()
	{
		InitializeComponent();
        BindingContext = vueModele = new AccueilVueModele();
    }
    private void EnchereClass_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new EnchereClassiqueVue(), true);
    }
    private void EnchereInversee_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EnchereInverseeVue(), true);
    }
    private void EnchereFlash_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EnchereFlashVue(), true);
    }
}
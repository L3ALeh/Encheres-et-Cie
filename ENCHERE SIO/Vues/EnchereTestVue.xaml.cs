using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

using ENCHERE_SIO.VuesModeles;

public partial class EnchereTestVue : ContentPage
{
	EnchereTestVueModele _vueModele;
	public EnchereTestVue()
	{
		InitializeComponent();
		BindingContext = _vueModele = new EnchereTestVueModele();
	}

    private void validerMontant_Clicked(object sender, EventArgs e)
    {
        _vueModele.PostEnchereTest(int.Parse(montantEnchere.Text));
    }
}
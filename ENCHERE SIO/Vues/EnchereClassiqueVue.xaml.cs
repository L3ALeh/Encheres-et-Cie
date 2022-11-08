using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.VuesModeles;

public partial class EnchereTestVue : ContentPage
{
	EnchereClassiqueVueModele _vueModele;
	public EnchereTestVue(Enchere currentEnchere)
	{
		InitializeComponent();
		BindingContext = _vueModele = new EnchereClassiqueVueModele(currentEnchere);
	}

    private void validerMontant_Clicked(object sender, EventArgs e)
    {
        _vueModele.PostEnchereTest(int.Parse(montantEnchere.Text));
    }

	private void Button_Clicked(object sender, EventArgs e)
	{

	}
}
using ENCHERE_SIO.VuesModeles;
using ENCHERE_SIO.Modeles;

namespace ENCHERE_SIO.Vues;

public partial class EnchereVue : ContentPage
{
	EnchereVueModele vueModele;
	public EnchereVue(Enchere currentEnchere)
	{
		InitializeComponent();
		BindingContext = vueModele = new EnchereVueModele(currentEnchere);
	}
}
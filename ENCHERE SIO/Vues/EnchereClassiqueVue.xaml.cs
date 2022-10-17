using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

public partial class EnchereClassiqueVue : ContentPage
{
    EnchereClassiqueVueModele vueModele;

    public EnchereClassiqueVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new EnchereClassiqueVueModele();
	}
}
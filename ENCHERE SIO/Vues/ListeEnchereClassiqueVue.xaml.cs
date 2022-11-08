using ENCHERE_SIO.VuesModeles;
using System.Xml.Linq;
using ENCHERE_SIO.Modeles;

namespace ENCHERE_SIO.Vues;

public partial class EnchereClassiqueVue : ContentPage
{

	ListeEnchereClassiqueVueModele vueModele;
	public EnchereClassiqueVue()
	{
		InitializeComponent();
        BindingContext = vueModele = new ListeEnchereClassiqueVueModele();

    }
    private void Enchere_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new EnchereVue(),true);
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var current = (Enchere)e.CurrentSelection.FirstOrDefault();
        Navigation.PushAsync(new EnchereTestVue(current), true);
    }
}
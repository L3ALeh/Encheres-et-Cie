using ENCHERE_SIO.VuesModeles;
using System.Xml.Linq;
using ENCHERE_SIO.Modeles;

namespace ENCHERE_SIO.Vues;

public partial class ListeEnchereClassiqueVue : ContentPage
{

	ListeEnchereClassiqueVueModele vueModele;
	public ListeEnchereClassiqueVue()
	{
		InitializeComponent();
        BindingContext = vueModele = new ListeEnchereClassiqueVueModele();
        collView.SelectedItem = null;
    }
    private void Enchere_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new EnchereVue(),true);
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var current = (Enchere)e.CurrentSelection.FirstOrDefault();
        Navigation.PushAsync(new EnchereClassiqueVue(current), true);
    }
}
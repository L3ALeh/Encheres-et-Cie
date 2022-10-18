using ENCHERE_SIO.VuesModeles;
using System.Xml.Linq;
using ENCHERE_SIO.Modeles;

namespace ENCHERE_SIO.Vues;

public partial class EnchereClassiqueVue : ContentPage
{

	EnchereClassiqueVueModele vueModele;
	public EnchereClassiqueVue()
	{
		InitializeComponent();
        BindingContext = vueModele = new EnchereClassiqueVueModele();

    }
    private void Enchere_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new EnchereVue(),true);
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var current = (Enchere)e.CurrentSelection.FirstOrDefault();
        Navigation.PushAsync(new EnchereVue(current), true);
    }
}
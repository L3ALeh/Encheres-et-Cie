using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

public partial class ListeEnchereInverseeVue : ContentPage
{
	ListeEnchereInverseeVueModele vueModele;
	public ListeEnchereInverseeVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new ListeEnchereInverseeVueModele();
		collView.SelectedItem = null;
	}

	private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var current = (Enchere)e.CurrentSelection.FirstOrDefault();
		Navigation.PushAsync(new EnchereInverseeVue(current), true);
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		
	}
}
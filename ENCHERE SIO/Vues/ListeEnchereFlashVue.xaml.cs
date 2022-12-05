using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

public partial class ListeEnchereFlashVue : ContentPage
{
	ListeEnchereFlashVueModele _vueModele;
	public ListeEnchereFlashVue()
	{
		InitializeComponent();
		BindingContext = _vueModele = new ListeEnchereFlashVueModele();
	}

	//private void collView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	//{
	//	var current = (Enchere)e.CurrentSelection.FirstOrDefault();
	//	Navigation.PushAsync(new EnchereFlashVue(current), true);
	//}

	private void Button_Clicked(object sender, EventArgs e)
	{

	}
}
namespace ENCHERE_SIO.Vues;

public partial class ListeEnchereFlashVue : ContentPage
{
	ListeEnchereFlashVue _vueModele;
	public ListeEnchereFlashVue()
	{
		InitializeComponent();
		BindingContext = _vueModele = new ListeEnchereFlashVue();
	}

	private void collView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{

	}

	private void Button_Clicked(object sender, EventArgs e)
	{

	}
}
//using ENCHERE_SIO.VuesModeles;

//namespace ENCHERE_SIO.Vues;

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
		//_vueModele.miser(double.Parse(montantEnchere.Text.ToString()));
	}
}
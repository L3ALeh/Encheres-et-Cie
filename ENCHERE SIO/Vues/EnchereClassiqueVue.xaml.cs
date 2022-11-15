using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.VuesModeles;

public partial class EnchereClassiqueVue : ContentPage
{
	EnchereClassiqueVueModele _vueModele;
	public EnchereClassiqueVue(Enchere currentEnchere)
	{
		InitializeComponent();
        
        BindingContext = _vueModele = new EnchereClassiqueVueModele(currentEnchere);
		
	}

    private void validerMontant_Clicked(object sender, EventArgs e)
    {
		if (montantEnchere.Text == "" || montantEnchere.Text is null)
		{
			montantNul.IsVisible = true;
		}
		else
		{
            _vueModele.PostEnchereTest(int.Parse(montantEnchere.Text));
			montantNul.IsVisible = false;
			montantEnchere.Text = "";
        }       
    }

	private void Button_Clicked(object sender, EventArgs e)
	{

	}

	private void ImageButton_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ListeEnchereClassiqueVue());
	}

	private void validerAuto_Clicked(object sender, EventArgs e)
	{
		_vueModele.ValeurMax = int.Parse(AutoMontant.Text);
	}
}
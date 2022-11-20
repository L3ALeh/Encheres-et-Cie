using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

public partial class EnchereInverseeVue : ContentPage
{
    EnchereInverseeVueModele _vueModele;

    public EnchereInverseeVue(Enchere currentEnchere)
    {
        InitializeComponent();
        BindingContext = _vueModele = new EnchereInverseeVueModele(currentEnchere);

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListeEnchereInverseeVue());
    }

    private void validerMontant_Clicked(object sender, EventArgs e)
    {
        if(montantEnchere.Text == "" || montantEnchere.Text == null)
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
}
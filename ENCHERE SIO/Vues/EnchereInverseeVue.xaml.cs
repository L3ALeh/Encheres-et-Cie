using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.VuesModeles;
namespace ENCHERE_SIO.Vues;

public partial class EnchereInverseeVue : ContentPage
{
    EnchereInverseeVueModele _vueModele;

    public EnchereInverseeVue(Enchere currentEnchere)
    {
        InitializeComponent();
        BindingContext = vueModele = new EnchereInverseeVueModele();

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListeEnchereInverseeVue());
    }

    private void validerMontant_Clicked(object sender, EventArgs e)
    {
        
        {
            montantNul.IsVisible = true;
        }
        else
        {
            
            montantNul.IsVisible = false;
            montantEnchere.Text = "";
        }
    }
}
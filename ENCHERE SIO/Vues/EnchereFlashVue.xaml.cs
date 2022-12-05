using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.VuesModeles;
using ENCHERE_SIO.Vues;
using ENCHERE_SIO.Modeles;

namespace ENCHERE_SIO.Vues;

public partial class EnchereFlashVue : ContentPage
{
    EnchereFlashVueModele vueModele;

    public EnchereFlashVue(Enchere currentEnchere)
    {
        InitializeComponent();
        BindingContext = vueModele = new EnchereFlashVueModele(currentEnchere);

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        collection.IsVisible = false;
    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        
    }

    private void ImageButton_Clicked_2(object sender, EventArgs e)
    {

    }

    private void ImageButton_Clicked_3(object sender, EventArgs e)
    {
        
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var current = (string)e.CurrentSelection.FirstOrDefault();
        
    }
}
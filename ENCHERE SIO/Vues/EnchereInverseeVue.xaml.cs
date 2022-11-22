using ENCHERE_SIO.VuesModeles;
using ENCHERE_SIO.Modeles;
namespace ENCHERE_SIO.Vues;

public partial class EnchereInverseeVue : ContentPage
{
    EnchereInverseeVueModele vueModele;

    public EnchereInverseeVue(Enchere current)
    {
        InitializeComponent();
        BindingContext = vueModele = new EnchereInverseeVueModele();

    }
}
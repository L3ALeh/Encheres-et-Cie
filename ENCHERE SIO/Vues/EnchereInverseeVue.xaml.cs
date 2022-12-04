using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.VuesModeles;
namespace ENCHERE_SIO.Vues;

public partial class EnchereInverseeVue : ContentPage
{
    EnchereInverseeVueModele _vueModele;

    public EnchereInverseeVue(Enchere currentEnchere)
    {
        InitializeComponent();
        BindingContext = vueModele = new EnchereInverseeVueModele(currentEnchere);


    }
}
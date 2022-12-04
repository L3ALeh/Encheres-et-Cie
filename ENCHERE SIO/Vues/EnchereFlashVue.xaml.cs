using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO.Vues;

public partial class EnchereFlashVue : ContentPage
{
    EnchereFlashVueModele vueModele;

    public EnchereFlashVue(Enchere currentEnchere)
    {
        InitializeComponent();
        BindingContext = vueModele = new EnchereFlashVueModele(currentEnchere);

    }
}
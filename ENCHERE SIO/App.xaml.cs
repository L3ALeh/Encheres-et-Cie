using ENCHERE_SIO.Vues;
using ENCHERE_SIO.VuesModeles;

namespace ENCHERE_SIO;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new EnchereTestVue());
    }
}

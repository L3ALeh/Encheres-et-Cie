using ENCHERE_SIO.Vues;

namespace ENCHERE_SIO;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new LoginVue();
    }
}

//using ENCHERE_SIO.Modeles;
//using ENCHERE_SIO.services;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ENCHERE_SIO.VuesModeles
//{
    //public class EnchereTestVueModele : BaseVueModele
    //{
    //    #region Attribut
    //    private readonly Api _apiServices = new Api();

    //    private ObservableCollection<EnchereClassique> _maListeEncheresEnCoursTypeClassique;
    //    private EnchereClassique _maEnchere;

    //    #endregion

    //    #region Constructeur
    //    public EnchereTestVueModele()
    //    {
    //        this.GetEnchereTest("19");
    //    }
    //    #endregion

    //    #region Getter/setter
    //    public ObservableCollection<EnchereClassique> MaListeEncheresEnCoursTypeClassique
    //    {
    //        get { return _maListeEncheresEnCoursTypeClassique; }
    //        set { SetProperty(ref _maListeEncheresEnCoursTypeClassique, value); }
    //    }

    //    public EnchereClassique MaEnchere
    //    {
    //        get { return _maEnchere; }
    //        set { SetProperty(ref _maEnchere, value); }
    //    }
    //    #endregion

    //    #region Methode
    //    public async void GetListeEnCheresEnCoursTypeClassique()
    //    {
    //        MaListeEncheresEnCoursTypeClassique = await _apiServices.GetAllAsync<EnchereClassique>
    //            ("api/getEncheresEnCours", EnchereClassique.CollClasse);
    //        EnchereClassique.CollClasse.Clear();

    //    }

    //    public async void GetEnchereTest(string param)
    //    {
    //        MaEnchere = await _apiServices.GetOneAsyncID<EnchereClassique>
    //            ("api/getEnchereTest", param);
    //        EnchereClassique.CollClasse.Clear();

    //    }
    //    #endregion


//    }
//}

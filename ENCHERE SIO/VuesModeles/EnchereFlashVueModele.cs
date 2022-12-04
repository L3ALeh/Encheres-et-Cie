using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENCHERE_SIO.Modeles;
using ENCHERE_SIO.services;

namespace ENCHERE_SIO.VuesModeles
{
    public class EnchereFlashVueModele:BaseVueModele
    {
        #region Attributes
        private readonly Api _apiServices = new Api();

        private Enchere _maEnchere;
        public static User leUser;
        #endregion

        #region Constructor
        public EnchereFlashVueModele(Enchere currentEnchere)
        {
            GetEnchereTest("" + currentEnchere.Id);
        }
        #endregion

        #region Getters/Setters
        public Enchere MaEnchere
        {
            get { return _maEnchere; }
            set { SetProperty(ref _maEnchere, value); }
        }
        #endregion

        #region Methods
        public async void GetEnchereTest(string param)
        {
            MaEnchere = await _apiServices.GetOneAsyncID<Enchere>
                ("api/getEnchereTest", param);
            Enchere.CollClasse.Clear();
           
        }

        

        public void initialiserPrix()
        {

        }
        #endregion
    }
}

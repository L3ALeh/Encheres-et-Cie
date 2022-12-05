using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENCHERE_SIO.Modeles;

namespace ENCHERE_SIO.VuesModeles
{
    public class EnchereFlashVueModele:BaseVueModele
    {
        #region Attributes
        private Enchere _maEnchere;
        private List<string> _imageUrl = new List<string>();
        #endregion

        #region Constructor
        public EnchereFlashVueModele(/*Enchere currentEnchere*/)
        {
            AjoutListe();
        }
        #endregion

        #region Getters/Setters
        public Enchere MaEnchere
        {
            get { return _maEnchere; }
            set { SetProperty(ref _maEnchere, value); }
        }
        public List<string> ImageUrl
        {
            get { return _imageUrl; }
            set { SetProperty(ref _imageUrl, value); }
        }
        #endregion

        #region Methods
        public void AjoutListe()
        {
            for(int i = 0; i < 4; i++)
            {
                ImageUrl.Add("https://www.ecotra-parement.fr/wp-content/uploads/2020/06/BRIKELIA-Vintage-Ancienne-ton-rouge-2.jpg");
            }
        }
        #endregion
    }
}

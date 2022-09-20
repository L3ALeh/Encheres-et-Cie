using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Modeles
{
    public class Magasin
    {
        #region Attribut
        public static List<Magasin> CollClasse = new List<Magasin>();
        private double _lattitude;
        private double _longitude;
        private string _nomMagasin;
        private int _id;
        #endregion

        #region Constructeur
        public Magasin(double lattitude, double longitude, string nomMagasin)
        {
            CollClasse.Add(this);
            _lattitude = lattitude;
            _longitude = longitude;
            _nomMagasin = nomMagasin;
            _id = CollClasse.Count()+1;    
        }

        #endregion

        #region Getter/setter
        public double Lattitude { get => _lattitude; set => _lattitude = value; }
        public double Longitude { get => _longitude; set => _longitude = value; }
        public string NomMagasin { get => _nomMagasin; set => _nomMagasin = value; }
        public int Id { get => _id; }

        #endregion

        #region Methode
        #endregion


    }
}

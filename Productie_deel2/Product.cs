using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productie_deel2
{
    public class Product
    {
        private string _sNaam;
        private int _iHoeveelheid;

        public Product(string sNaam)
        {
            _sNaam = sNaam;
            Random r = new Random();
            _iHoeveelheid = r.Next(1,101); //hoeveelheid tussen 1 en 100
        }

        public string Gegevens()
        {
            return $"Product: {_sNaam} - Hoeveelheid: {_iHoeveelheid}";
        }


        public string Naam
        {
            get { return _sNaam; }
        }
    }
}

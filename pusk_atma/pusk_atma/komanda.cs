using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pusk_atma
{
    class komanda
    {
        private string komandaAdi;
        private string komandaOlke;

        public komanda(string ad,string olke)
        {
            komandaAdi = ad;
            komandaOlke = olke;
        }

        public string TeamName
        {
            get
            {
                return komandaAdi;
            }
            set
            {
                komandaAdi = value;
            }
        }

        public string TeamCountry
        {
            get
            {
                return komandaOlke;
            }
            set
            {
                komandaOlke = value;
            }
        }

        public override string ToString()
        {
            return komandaAdi + "-" + komandaOlke;
        }
    }
}

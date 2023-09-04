using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSSS.Modeli
{
    public class Trener : Korisnik
    {

        private Korisnik _korisnik;
        public Korisnik Korisnik
        {
            get { return _korisnik; }
            set { _korisnik = value; }
        }

        private String _licenca;

        public string Licenca
        {
            get { return _licenca; }
            set { _licenca = value; }
        }

        private bool _odobren;

        public bool Odobren
        {
            get { return _odobren; }
            set { _odobren = value; }
        }

        public Trener() { }

        public override string ToString()
        {
            return Korisnik.ToString() + 
                "Licenca : " + Licenca + "\n" +
                "Odobren: " + Odobren + "\n" + "\n";
        }

        // ?
        public string UpisTreneraUFajl()
        {
            return Korisnik.Email;
        }

    }
}

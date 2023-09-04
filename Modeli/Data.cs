using ProjekatSSS.Servisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSSS.Modeli
{
    public sealed class Data
    {
        public static readonly Data instance = new Data();
        private IKorisnikServis korisnikServis;
        private ITrenerServis trenerServis;
        private Data() {

        }

        static Data() { }

        public static Data Instance
        {
            get { return instance; }
        }

        public List<Korisnik> Korisnici { get; set; }
        public List<Trener> Treneri { get; set; }


        public void Initialize()
        {
            Korisnici = new List<Korisnik>();
            Treneri = new List<Trener>();


        }

        public void SacuvajEntitete(String imeFajla)
        {
            if (imeFajla.Contains("korisnici"))
            {
                korisnikServis.CuvajKorisnike(imeFajla);
            }
            else if (imeFajla.Contains("treneri"))
            {
                trenerServis.CuvajKorisnike(imeFajla);
            }
        }

        public void CitajEntitete(String imeFajla)
        {
            if (imeFajla.Contains("users"))
            {
                korisnikServis.CitajKorisnike(imeFajla);
            }
            else if (imeFajla.Contains("treneri"))
            {
                trenerServis.CitajKorisnike(imeFajla);
            }
        }


    }
}

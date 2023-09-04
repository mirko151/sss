using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjekatSSS.Modeli
{
    public class Korisnik
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
 
        private string _ime;

        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }

        private string _prezime;

        public string Prezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _kontaktTelefon;
        public string KontaktTelefon
        {
            get { return _kontaktTelefon; }
            set { _kontaktTelefon = value; }
        }



        private int _brPlatneKartice;
        public int BrPlatneKartice
        {
            get { return _brPlatneKartice; }
            set { _brPlatneKartice = value; }
        }

        private string _jezik;

        public string Jezik
        {
            get { return _jezik; }
            set { _jezik = value; }
        }

        private string _lozinka;

        public string Lozinka
        {
            get { return _lozinka; }
            set { _lozinka = value; }
        }

        private ETipKorisnika _tipKorisnika;

        public ETipKorisnika TipKorisnika
        {
            get { return _tipKorisnika; }
            set { _tipKorisnika = value; }
        }

        private bool _aktivan;

        public bool Aktivan
        {
            get { return _aktivan; }
            set { _aktivan = value; }
        }


        private Adresa _adresa;

        public Adresa Adresa
        {
            get { return _adresa; }
            set { _adresa = value; }
        }

        public Korisnik() { }

        // id, ime, prezime, email, kontakt telefonn, brplatnekartice, jezik,
        // lozinka, tip korisnika, aktivan, adresa

        public override string ToString()
        {
            return
                    "ID: " + Id + "\n" +
                    "Ime: " + Ime + "\n" +
                    "Prezime: " + Prezime + "\n" +
                    "Kontakt telefon: " + KontaktTelefon + "\n" +
                   
                    "Broj platne kartice: " + BrPlatneKartice + "\n" +
                    "Jezik: " + Jezik + "\n" +
                    "Lozinka: " + Lozinka + "\n" +
                    "Tip korisnika: " + TipKorisnika + "\n" +
                    "Aktivan " + Aktivan + "\n" +
                    "Adresa: " + Adresa + "\n" + "\n"; //11
        }


        public string UpisKorisnikaUFajl()
        {
            return
                Id + "|" +
                Ime + "|" + 
                Prezime + "|" + 
                Email + "|" + 
                KontaktTelefon + "|" + 
     
                BrPlatneKartice + "|" + 
                Jezik + "|" + 
                Lozinka + "|" + 
                TipKorisnika + "|" + 
                Aktivan + "|" + 
                Adresa + "|" + "\n"; // 11
        }


    }
}

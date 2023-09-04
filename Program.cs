using ProjekatSSS.Izuzeci;
using ProjekatSSS.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSSS
{
    class Program
    {

        //Registracija novih clanova(trener/klijent)
        //Logovanje/prikaz profila i zakazanih treninga (trener/klijent) + logovanje admin
        //Vlasnik sekcija(izvestaj platforme)(vlasnicki pristup)
      
        /// ///////////////////////////////////////////////////////////////////////////////////////



        //
        //
        //
        //
        //
        //

        //Registracija novih clanova(trener/klijent)
        //Tip korisnickog naloga(opcije): [1]Trener [2]Klijent

        //[1]Unosi podatke za novog korisnika + zvanje(opcija odobren bi trebala biti podesena na false) BOLJE JE UNETI LICENCU NEGO ZVANJE; 
        //Nakon kreiranja obavestenje "Vas nalog je kreiran. Potrebno je da sacekate odobrenje admina."

        //[2]Unosi podatke za novog korisnika samo
        //Nakon kreiranja ispisati potvrdno obavestenje samo.

        public static void DodajNovogKorisnika()
        {

            string Opcija = "";
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine(" Sekcija za registraciju novih korisnika");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("[1] Kreiraj nalog trenera");
                Console.WriteLine("[2] Kreiraj nalog klijenta");
                Console.WriteLine("[x] Povratak na glavni meni");   // implementirati
                Console.WriteLine("\n");
                Console.WriteLine("Izaberite tip korisnickog naloga:");
                Opcija = Console.ReadLine();
                switch (Opcija)
                {
                    case "1":
                        DodajNovogTrenera();
                        break;
                    case "2":
                        DodajNovogKlijenta();
                        break;
                    case "x":
                       //// Povratak
                        break;
                    default:
                        Console.WriteLine("Pogresan unos!");
                        break;
                }
            }
            while (!Opcija.Equals("x"));
        }

        public static void DodajNovogTrenera()
        {

            // id, ime, prezime, email, kontakt telefonn, brplatnekartice, jezik,
            // lozinka, tip korisnika, aktivan, adresa

            //Console.WriteLine("Unesite id: ");
            //string id = Console.ReadLine();            

            Console.WriteLine("Unesite ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Unesite prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("Unesite email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Unesite kontakt telefon: ");
            string kontaktTelefon = Console.ReadLine();

            Console.WriteLine("Unesite grad: ");
            string grad = Console.ReadLine();
            Console.WriteLine("Unesite ulicu: ");
            string ulica = Console.ReadLine();
            Console.WriteLine("Unesite grad: ");
            string Broj = Console.ReadLine();
            int.TryParse(Broj, out int broj);

            Adresa adresa = new Adresa
            {
                Ulica = ulica,
                Broj = broj,
                Grad = grad
            };


            Console.WriteLine("Unesite broj platne kartice: ");
            string BrPlatneKartice = Console.ReadLine();
            int.TryParse(BrPlatneKartice, out int brPlatneKartice);

            Console.WriteLine("Unesite maternji jezik: ");
            string jezik = Console.ReadLine();

            Console.WriteLine("Unesite zeljenu lozinku: ");
            string lozinka = Console.ReadLine();
            
            Console.WriteLine("Unesite licencu: ");
            string licenca = Console.ReadLine();


            // id, ime, prezime, email, kontakt telefonn, brplatnekartice, jezik,
            // lozinka, tip korisnika, aktivan, adresa

            Korisnik korisnik = new Korisnik
            {
                //   Id = id
                Ime = ime,
                Prezime = prezime,
                Email = email,
                KontaktTelefon = kontaktTelefon,
                BrPlatneKartice = brPlatneKartice,
                Jezik = jezik,
                Lozinka = lozinka,
                TipKorisnika = ETipKorisnika.Klijent,
                Aktivan = true,
                Adresa = adresa,
            };



            Trener trener = new Trener
            {
                Korisnik = korisnik,
                Licenca = licenca,
                Odobren = false  /// Dok ne odobri administrator
            };

            Data.Instance.Treneri.Add(trener);
            Console.WriteLine("Vas zahtev za kreiranje novog trenera je kreiran!");
            Console.WriteLine("Za aktivaciju naloga potrebno je sacekati odobrenje administratora!");
        }

        public static void DodajNovogKlijenta()
        {

            // id, ime, prezime, email, kontakt telefonn, brplatnekartice, jezik,
            // lozinka, tip korisnika, aktivan, adresa

            //Console.WriteLine("Unesite id: ");
            //string id = Console.ReadLine();            

            Console.WriteLine("Unesite ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Unesite prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("Unesite email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Unesite kontakt telefon: ");
            string kontaktTelefon = Console.ReadLine();

            Console.WriteLine("Unesite grad: ");
            string grad = Console.ReadLine();
            Console.WriteLine("Unesite ulicu: ");
            string ulica = Console.ReadLine();
            Console.WriteLine("Unesite grad: ");
            string Broj = Console.ReadLine();
            int.TryParse(Broj, out int broj);

            Adresa adresa = new Adresa
            {
                Ulica = ulica,
                Broj = broj,
                Grad = grad
            };


            Console.WriteLine("Unesite broj platne kartice: ");
            string BrPlatneKartice = Console.ReadLine();
            int.TryParse(BrPlatneKartice, out int brPlatneKartice);

            Console.WriteLine("Unesite maternji jezik: ");
            string jezik = Console.ReadLine();

            Console.WriteLine("Unesite zeljenu lozinku: ");
            string lozinka = Console.ReadLine();

            // id, ime, prezime, email, kontakt telefonn, brplatnekartice, jezik,
            // lozinka, tip korisnika, aktivan, adresa

            Korisnik korisnik = new Korisnik
            {
                //   Id = id
                Ime = ime,
                Prezime = prezime,
                Email = email,
                KontaktTelefon = kontaktTelefon,
                BrPlatneKartice = brPlatneKartice,
                Jezik = jezik,
                Lozinka = lozinka,
                TipKorisnika = ETipKorisnika.Klijent,
                Aktivan = true,
                Adresa = adresa,
            };

            Data.Instance.Korisnici.Add(korisnik);
            Console.WriteLine("Uspesno ste kreirali novog korisnika!");
        }



        //
        //
        //
        //
        //
        //
        //Admin prikaz
        //Prikazuju se podaci trenera, jedanog po jedanog pojedinacno;
        //ponudjene su opcije na kraju ispisa: [1]Odobren [2]Nije odobren
        //U slucaju da je nalog odobren vrsi se upis u fajl sa Odobren->true i treneru se omogucava da pristupi svom nalogu
        //Nije odobren -> brise se



        //
        //
        //
        //
        //
        //
        //
        //
        //
        //Logovanje
        // Mejl i lozinka provera


        //Trener sekcija
        //
        //U slucaju da je nalog odobren, treneru se prikazuje profil;
        //ako nije odobren, ispis "Nalog nije odobren"
        //
        //Opcije na profilu trenera: 
        //1.Lista slobodnih termina za mesec dana unapred
        //2.Osmisljavanje zakazanih treninga na osnovu podataka o treningu i klijentu
        //3.Pracenje treninga zapocetog u trenutku logovanja(provera datuma i vremena)
        //3./b Ocenjivanje klijenta nakon zavrsenog treninga
        //4.Prikaz podataka o klijentima sa kojima je radio i njihovom napredovanju


        //Klijent sekcija
        //Prikazuju se podaci o korisniku
        //Ispod podataka ponudjene su opcije:
        //[1]Zakazi trening
        //Pre pocetka zakazivanja, klijent unosi visinu, tezinu, bira opciju iz liste ciljeva(enum), i navodi (listu) rekvizita(proizvoljno)
        //U slucaju odabira ove opcije o korisnika se trazi da unese datum kada zeli da zaze trening
        //Nakon toga mu se 
        //[2]Zakazani treninzi(pregled)

        public static void PrijavaNaSistem()
        {
            string Opcija = "";
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Sekcija sa prijavu postojecih korisnika na sistem"); /// implementirati prijavu na sistem
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("[1] Klijent");
                Console.WriteLine("[2] Trener");
                Console.WriteLine("[3] Administrator");
                Console.WriteLine("[x] Povratak na glavni meni");   // implementirati
                Console.WriteLine("\n");
                Console.WriteLine("Izaberite tip korisnickog naloga:");
                Opcija = Console.ReadLine();
                switch (Opcija)
                {
                    case "1":
                        
                        break;
                    case "2":
                  
                        break;
                    case "3":
                      
                        break;
                    case "x":
                        //// Povratak
                        break;
                    default:
                        Console.WriteLine("Pogresan unos!");
                        break;
                }
            }
            while (!Opcija.Equals("x"));

        }

 
   
        public static void ProfilKlijenta()
        {
            string Opcija = "";
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Vas privatan profil");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("[1] Pregledajte sve dostupne trenere");
                Console.WriteLine("[2] Zakazite trening");
                Console.WriteLine("[3] Otkazite trening");
                Console.WriteLine("[x] Povratak na glavni meni");   // implementirati
                Console.WriteLine("\n");
                Console.WriteLine("Izaberite tip korisnickog naloga:");
                Opcija = Console.ReadLine();
                switch (Opcija)
                {
                    case "1":
                        SviDostupniTreneri();
                        break;
                    case "2":
                        ZakazivanjeTreninga();
                        break;
                    case "3":
                        OtkazivanjeTreninga();
                        break;
                    case "x":
                        //// Povratak
                        break;
                    default:
                        Console.WriteLine("Pogresan unos!");
                        break;
                }
            }
            while (!Opcija.Equals("x"));
        }

        public static void SviDostupniTreneri()
        {
            foreach (Trener trener in Data.Instance.Treneri)
            {
                if (trener.Korisnik.Aktivan)
                    Console.WriteLine(trener.ToString());
            }
        }

        public static void ZakazivanjeTreninga()
        {

        }
    
        public static void OtkazivanjeTreninga()
        {

        }


        public static void ProfilTrenera()
        {
            string Opcija = "";
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Vas privatan profil");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("[1] Pregledajte sve zakazane treninge"); // implementirati
                Console.WriteLine("[2] Pregled liste slobodnih termina"); // implementirati
                Console.WriteLine("[3] Prikaz svih dosadasnjih klijenata"); // implementirati
                Console.WriteLine("[x] Povratak na glavni meni");   // implementirati
                Console.WriteLine("\n");
                Console.WriteLine("Izaberite tip korisnickog naloga:");
                Opcija = Console.ReadLine();
                switch (Opcija)
                {
                    case "1":
                      //  PregledZakazanihTreninga();
                        break;
                    case "2":
                    //    PregledListeSlobodnihTermina();
                        break;
                    case "3":
                     //   PrikazDosadasnjihKlijenata();
                        break;
                    case "x":
                        //// Povratak
                        break;
                    default:
                        Console.WriteLine("Pogresan unos!");
                        break;
                }
            }
            while (!Opcija.Equals("x"));
        }

        public static void ProfilAdministratora()
        {
            string Opcija = "";
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Profil administratora");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("[1] Pregledajte svih zahteva trenera"); // implementirati
                Console.WriteLine("[x] Povratak na glavni meni");   // implementirati
                Console.WriteLine("\n");
                Console.WriteLine("Izaberite tip korisnickog naloga:");
                Opcija = Console.ReadLine();
                switch (Opcija)
                {
                    case "1":
                   //     PregledSvihNeodobrenihTrenera();
                        break;
                    case "x":
                        //// Povratak
                        break;
                    default:
                        Console.WriteLine("Pogresan unos!");
                        break;
                }
            }
            while (!Opcija.Equals("x"));
        }


        //
        //
        //
        //
        //
        //
        //
        //Vlasnik sekcija(izvestaj platforme)
        //Prilikom izbora ove selekcije traze se kredencijali  vlasnika(nalog i sifra)
        //1.Zarada za zadati interval(dani, nedelje, meseci)
        //2.Lista najbolje rangiranih trenera(rang po zvezdicama/zaradi)

        public static void VlasnickaSekcija()
        {
            string Opcija = "";
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Vlasnicka sekcija");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("[1] Prikaz zarada");
                Console.WriteLine("[2] Lista najboljih trenera");
                Console.WriteLine("[x] Povratak na glavni meni");   // implementirati
                Console.WriteLine("\n");
                Console.WriteLine("Izaberite tip korisnickog naloga:");
                Opcija = Console.ReadLine();
                switch (Opcija)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "x":
                        //// Povratak
                        break;
                    default:
                        Console.WriteLine("Pogresan unos!");
                        break;
                }
            }
            while (!Opcija.Equals("x"));

        }







        public static void Main(string[] args)
        {
      
            Data.Instance.Initialize();

            //Data.Instance.CitajEntitete("korisnici.txt");
            //Data.Instance.CitajEntitete("treneri.txt");

            string Opcija = "";
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("********Online fitnes platforma********");
                Console.WriteLine("\n");
                Console.WriteLine("[1] Registracija novih korisnika(trener/klijent)");
                Console.WriteLine("[2] Prijava postojecih korisnika na sistem");
                Console.WriteLine("[3] Vlascnicka sekcija");
                Console.WriteLine("[x] Kraj");
                Console.WriteLine("\n");
                Console.WriteLine("Izaberite akciju: ");

                Opcija = Console.ReadLine();
                switch (Opcija)
                {
                    case "1":
                        DodajNovogKorisnika();
                        break;
                    case "2":
                        PrijavaNaSistem();
                        break;
                    case "3":
                        VlasnickaSekcija();
                        break;
                    case "x":
                       ///// kraj
                        break;
                    default:
                        Console.WriteLine("Pogresan unos!");
                        break;
                }

            }
            while (!Opcija.Equals("x"));

        }



    }
    
}

using ProjekatSSS.Izuzeci;
using ProjekatSSS.Modeli;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSSS.Servisi
{
    public class KorisnikServis : IKorisnikServis
    {
        public void CuvajKorisnike(string imeFajla)
        {
            using (StreamWriter file = new StreamWriter(@"../../Resursi/" + imeFajla))
            {
                foreach (Korisnik korisnik in Data.Instance.Korisnici)
                {
                    file.WriteLine(korisnik.UpisKorisnikaUFajl());
                }
            }
        }

        public void CitajKorisnike(string imeFajla)
        {
            Data.Instance.Korisnici = new List<Korisnik>();
            using (StreamReader file = new StreamReader(@"../../Resursi/" + imeFajla))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {

                    // ime, prezime, email, kontakt telefon, adresa, brplatnekartice, jezik,
                    // lozinka, tip korisnika, izbrisan

                    string[] KorisnikIzFajla = line.Split('|');
                    Enum.TryParse(KorisnikIzFajla[7], out ETipKorisnika tipKorisnika);
                    Boolean.TryParse(KorisnikIzFajla[8], out Boolean aktivan);
                    int.TryParse(KorisnikIzFajla[4], out int brPlatneKartice);

                    Korisnik korisnik = new Korisnik
                    {
                        Id = KorisnikIzFajla[0],
                        Ime = KorisnikIzFajla[1],
                        Prezime = KorisnikIzFajla[2],
                        Email = KorisnikIzFajla[3],
                        KontaktTelefon = KorisnikIzFajla[4],

                        BrPlatneKartice = brPlatneKartice,
                        Jezik = KorisnikIzFajla[6],
                        Lozinka = KorisnikIzFajla[7],
                        TipKorisnika = tipKorisnika,
                        Aktivan = aktivan
                        //Adresa = KorisnikIzFajla[10]
                    };

                    Data.Instance.Korisnici.Add(korisnik);
                }
            }
        }

        public void BrisiKorisnika(string id)
        {
            Korisnik korisnik = Data.Instance.Korisnici.ToList().Find(k => k.Id.Contains(id));
            if (korisnik == null)
            {
                //Console.WriteLine($"Ne postoji taj korisnik sa email adresom {email}" );
                //Ako ne pronadjem korisnika bacam izuzetak
                throw new UserNotFoundException($"Ne postoji taj korisnik sa ID-em {id}");
            }
            korisnik.Aktivan = false;
        }
    }
}

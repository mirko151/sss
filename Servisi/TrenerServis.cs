using ProjekatSSS.Modeli;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSSS.Servisi
{
    public class TrenerServis : ITrenerServis
    {
        public void CitajKorisnike(string imeFajla)
        {
            Data.Instance.Treneri = new List<Trener>();
            using (StreamReader file = new StreamReader(@"../../Resursi/" + imeFajla))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] TrenerIzFajla = line.Split('|');
                    Boolean.TryParse(TrenerIzFajla[2], out Boolean odobren);

                    //pronalazenje korisnika
                    Korisnik korisnik = Data.Instance.Korisnici.Find(u => u.Id.Equals(TrenerIzFajla[0]));

                    Trener trener = new Trener
                    {
                        Korisnik = korisnik,
                        Licenca = TrenerIzFajla[1],
                        Odobren = odobren
                    };

                    Data.Instance.Treneri.Add(trener);
                }
            }
        }

        public void CuvajKorisnike(string fileName)
        {
            using (StreamWriter file = new StreamWriter(@"../../Resursi/" + fileName))
            {
                foreach (Trener trener in Data.Instance.Treneri)
                {
                    file.WriteLine(trener.UpisTreneraUFajl());
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSSS.Servisi
{
    public interface IKorisnikServis
    {
        void CuvajKorisnike(string imeFajla);
        void CitajKorisnike(string imeFajla);
        void BrisiKorisnika(string email);



    }
}

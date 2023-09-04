using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatSSS.Modeli
{
    public class Adresa
    {
        //public string _id;

        //public string Id
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}

        private string _ulica;

        public string Ulica
        {
            get { return _ulica; }
            set { _ulica = value; }
        }

        private int _broj;

        public int Broj
        {
            get { return _broj; }
            set { _broj = value; }
        }

        private string _grad;

        public string Grad
        {
            get { return _grad; }
            set { _grad = value; }
        }

        public Adresa()
        {

        }

        // ulica, broj, grad
        public override string ToString()
        {
            return "\n" +
                //  " ID: " + Id + "\n" + 
                " Ulica: " + Ulica + "\n" + " Broj: " + Broj + "\n" + " Grad: " + Grad;
        }

    }
}
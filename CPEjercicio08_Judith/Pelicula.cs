using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio08_Judith
{
    internal class Pelicula
    {
        string n;
        int annio;

        public Pelicula(string n, int annio)
        {
            this.n = n;
            this.annio = annio;
        }

        public string N { get => n; set => n = value; }
        public int Annio { get => annio; set => annio = value; }
    }
}

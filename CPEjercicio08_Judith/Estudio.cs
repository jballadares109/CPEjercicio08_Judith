using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio08_Judith
{
    internal class Estudio
    {
        string nomb;
        string dirrec;

        public Estudio(string nomb, string dirrec)
        {
            this.nomb = nomb;
            this.dirrec = dirrec;
        }

        public string Nomb { get => nomb; set => nomb = value; }
        public string Dirrec { get => dirrec; set => dirrec = value; }

        public void Produce()
        {
            Console.WriteLine(" ");
        }
    }
}

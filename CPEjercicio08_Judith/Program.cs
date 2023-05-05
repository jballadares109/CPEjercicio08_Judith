using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio08_Judith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelicula p = new Pelicula("Lost", 2017);
            Actor a = new Actor("Robert", "Jr");
            Estudio e = new Estudio("Century 21", "RJ Joey");

            a.Actua();
            e.Produce();

            Console.ReadKey();
        }
    }
}

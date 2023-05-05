using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio08_Judith
{
    internal class Actor
    {
        string nom;
        string ape;

        public Actor(string nom, string ape)
        {
            this.nom = nom;
            this.ape = ape;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Ape { get => ape; set => ape = value; }

        public void Actua()
        {
            Console.WriteLine(" ");
        }
    }
}

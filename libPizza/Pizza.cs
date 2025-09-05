using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPizza
{
    public class Pizza
    {
        private string nom;
        public string Nom
        {
            get {  return nom; }
            set { nom = value; }
        }

        public Pizza() { this.Nom = ""; }
        public Pizza(string nom) { this.Nom = nom; }
        public string GetNomPizza() { return this.Nom; }

    }
}

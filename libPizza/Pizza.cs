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
        private double prix;

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public string Nom
        {
            get {  return nom; }
            set { nom = value; }
        }

        public Pizza() { this.Nom = ""; this.Prix = 0; }
        public Pizza(string nom) { this.Nom = nom; this.Prix = 0; }
        public string GetNomPizza() { return this.Nom; }
        public Pizza(string nom, double prix) { this.Nom = nom; this.Prix = prix; }
    }
}

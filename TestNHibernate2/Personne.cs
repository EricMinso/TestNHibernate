using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNHibernate2
{
    public class Personne
    {
        public long   Identifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }

        public Personne( string nom, string prénom, string adresse, string téléphone )
        {
            this.Nom = nom;
            this.Prenom = prénom;
            this.Adresse = adresse;
            this.Telephone = téléphone;
        }
    }
}

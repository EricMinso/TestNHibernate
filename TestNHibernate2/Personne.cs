using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNHibernate2
{
    public class Personne
    {
        public virtual long   Identifiant { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Prenom { get; set; }
        public virtual string Adresse { get; set; }
        public virtual string Telephone { get; set; }

        public Personne()
        { 
            this.Identifiant = -1;
            this.Nom = "";
            this.Prenom = "";
            this.Adresse = "";
            this.Telephone = "";
        }

        public Personne( string nom, string prénom, string adresse, string téléphone )
        {
            this.Identifiant = -1;
            this.Nom = nom;
            this.Prenom = prénom;
            this.Adresse = adresse;
            this.Telephone = téléphone;
        }

        public override string ToString()
        {
            return this.Prenom + " " + this.Nom;
        }
    }
}

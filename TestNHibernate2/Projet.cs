using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNHibernate2
{
    public class Projet
    {
        public virtual long     Identifiant { get; set; }
        public virtual string   Nom { get; set; }
        //public DateTime DateDébut { get; set; }

        public Projet()
        {
            this.Identifiant = -1;
            this.Nom = "";
        }

        public Projet( string nom )
        {
            this.Identifiant = -1;
            this.Nom = nom;
        }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNHibernate2
{
    public class Projet
    {
        public long     Identifiant { get; set; }
        public string   Nom { get; set; }
        //public DateTime DateDébut { get; set; }

        public Projet( string nom )
        {
            this.Identifiant = 0;
            this.Nom = nom;
        }
    }
}

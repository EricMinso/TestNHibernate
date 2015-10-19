using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTestProject //DataModel
{
    public class Personne
    {
#region Properties

        public virtual long   Identifiant { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Prenom { get; set; }
        public virtual string Adresse { get; set; }
        public virtual string Telephone { get; set; }

#endregion
#region Constructors

        /// <summary>
        /// Create a new empty person
        /// </summary>
        public Personne()
        { 
            this.Identifiant = -1;
            this.Nom = "";
            this.Prenom = "";
            this.Adresse = "";
            this.Telephone = "";
        }

        /// <summary>
        /// Create a person with all properties filled
        /// </summary>
        public Personne( string nom, string prénom, string adresse, string téléphone )
        {
            this.Identifiant = -1;
            this.Nom = nom;
            this.Prenom = prénom;
            this.Adresse = adresse;
            this.Telephone = téléphone;
        }

#endregion
#region Methods

        /// <summary>
        /// Returns this object on its string form
        /// </summary>
        /// <returns>A string that represents this object</returns>
        public override string ToString()
        {
            return this.Prenom + " " + this.Nom;
        }

#endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTestProject //DataModel
{
    public class Projet
    {
#region Properties

        public virtual long   Identifiant { get; set; }
        public virtual string Nom { get; set; }

#endregion
#region Constructors

        /// <summary>
        /// Create a new empty project
        /// </summary>
        public Projet()
        {
            this.Identifiant = -1;
            this.Nom = "";
        }

        /// <summary>
        /// Create a project with a specified name
        /// </summary>
        public Projet( string nom )
        {
            this.Identifiant = -1;
            this.Nom = nom;
        }

#endregion
#region Methods

        /// <summary>
        /// Returns this object on its string form
        /// </summary>
        /// <returns>A string that represents this object</returns>
        public override string ToString()
        {
            return this.Nom;
        }

#endregion
    }
}

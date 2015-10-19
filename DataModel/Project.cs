using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Project
    {
#region Properties

        public virtual long   Id { get; set; }
        public virtual string Name { get; set; }

#endregion
#region Constructors

        /// <summary>
        /// Create a new empty project
        /// </summary>
        public Project()
        {
            this.Id = -1;
            this.Name = "";
        }

        /// <summary>
        /// Create a project with a specified name
        /// </summary>
        public Project( string name )
        {
            this.Id = -1;
            this.Name = name;
        }

#endregion
#region Methods

        /// <summary>
        /// Returns this object on its string form
        /// </summary>
        /// <returns>A string that represents this object</returns>
        public override string ToString()
        {
            return this.Name;
        }

#endregion
    }
}

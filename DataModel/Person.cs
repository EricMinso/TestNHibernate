using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Person
    {
#region Properties

        public virtual long   Id { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Address { get; set; }
        public virtual string Phone { get; set; }

#endregion
#region Constructors

        /// <summary>
        /// Create a new empty person
        /// </summary>
        public Person()
        { 
            this.Id = -1;
            this.LastName = "";
            this.FirstName = "";
            this.Address = "";
            this.Phone = "";
        }

        /// <summary>
        /// Create a person with all properties filled
        /// </summary>
        public Person( string newLastName, string newFirstName, string newAddress, string newPhone )
        {
            this.Id = -1;
            this.LastName = newLastName;
            this.FirstName = newFirstName;
            this.Address = newAddress;
            this.Phone = newPhone;
        }

#endregion
#region Methods

        /// <summary>
        /// Returns this object on its string form
        /// </summary>
        /// <returns>A string that represents this object</returns>
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

#endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Contact
    {
        private int _contactId;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _telephone;

        public virtual int ContactId
        {
            get { return _contactId; }
            set { _contactId = value; }
        }

        public virtual string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public virtual string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public virtual string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public virtual string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public Contact()
        {

        }
    }
}

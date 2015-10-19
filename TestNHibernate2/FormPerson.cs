using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Internal References
using DataModel;


namespace TestNHibernate2
{
    public partial class FormPerson : Form
    {
        private Person _personneSaisie = null;

        public Person PersonneSaisie
        {
            get
            {
                return this._personneSaisie;
            }
        }

        public FormPerson()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click( object sender, EventArgs e )
        {
            this._personneSaisie = null;
            this.Close();
        }

        private void btnValider_Click( object sender, EventArgs e )
        {
            this._personneSaisie = new Person(
                this.tbxLastName.Text,
                this.tbxFirstName.Text,
                this.tbxAddress.Text,
                this.tbxPhone.Text );
            this.Close();
        }
    }
}

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
//using DataModel;


namespace NHibernateTestProject // TestNHibernate2
{
    public partial class FormPersonne : Form
    {
        private Personne _personneSaisie = null;

        public Personne PersonneSaisie
        {
            get
            {
                return this._personneSaisie;
            }
        }

        public FormPersonne()
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
            this._personneSaisie = new Personne(
                this.tbxNom.Text,
                this.tbxPrénom.Text,
                this.tbxAdresse.Text,
                this.tbxTéléphone.Text );
            this.Close();
        }
    }
}

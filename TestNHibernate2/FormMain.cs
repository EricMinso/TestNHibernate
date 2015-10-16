

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNHibernate2
{
    public partial class FormMain : Form
    {
        // Configuration NHibernate 
        NHibernate.Cfg.Configuration config;

        // factory NHibernate 
        private NHibernate.ISessionFactory sessionFactory;


        // Constructeur par défaut
        public FormMain()
        {
            InitializeComponent();

            // Configuration NHibernate 
            this.config = new NHibernate.Cfg.Configuration();

            // Ajout assembly
            this.config.AddAssembly("TestNHibernate");

            // Initialisation factory NHibernate 
            sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory(); 
        }

        ~FormMain()
        { 
            // Fermeture Factory
            if( this.sessionFactory != null && ! this.sessionFactory.IsClosed )
                sessionFactory.Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLire_Click(object sender, EventArgs e)
        {
            try
            {
                // Ouverture session
                NHibernate.ISession session = this.sessionFactory.OpenSession();

                // Démarrage Transaction
                NHibernate.ITransaction transaction = session.BeginTransaction();

                // Lire toute la table 'Persons'
                var listeProjets = session.CreateCriteria<Projet>().List<Projet>();

                // Tell NHibernate that this object should be saved
                //session.Save(contact);

                // Commit de la transaction
                transaction.Commit();

                // Fermeture session
                session.Close();

            }
            catch( Exception ex )
            {
                Program.DisplayException(ex);
            }
        }
    }
}

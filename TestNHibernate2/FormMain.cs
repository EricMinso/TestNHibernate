

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Microsoft.VisualBasic;


namespace TestNHibernate2
{
    public partial class FormMain : Form
    {
        // Configuration NHibernate 
        NHibernate.Cfg.Configuration config;

        // Factory NHibernate 
        private NHibernate.ISessionFactory sessionFactory;


        // Constructeur par défaut
        public FormMain()
        {
            InitializeComponent();

            // Configuration NHibernate 
            this.config = new NHibernate.Cfg.Configuration();

            // Ajout assembly
            this.config.AddAssembly("TestNHibernate2");

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

        private void btnLirePersonnes_Click(object sender, EventArgs e)
        {
            try
            {
                // Nettoyage 
                this.lbxPersonnes.Items.Clear();

                // Ouverture session
                NHibernate.ISession session = this.sessionFactory.OpenSession();

                // Démarrage Transaction
                NHibernate.ITransaction transaction = session.BeginTransaction();

                // Lire toute la table 'Persons'
                var listePersonnes = session.CreateCriteria<Personne>().List<Personne>();

                // Tell NHibernate that this object should be saved
                //session.Save(contact);

                // Commit de la transaction
                transaction.Commit();

                // Fermeture session
                session.Close();

                // Ajout interface graphique
                //this.lbxProjets.Items.AddRange(listeProjets);
                foreach( Personne pers in listePersonnes )
                {
                    this.lbxPersonnes.Items.Add( pers );
                }
            }
            catch( Exception ex )
            {
                Program.DisplayException(ex);
            }
        }


        private void btnLireProjets_Click(object sender, EventArgs e)
        {
            try
            {
                // Nettoyage 
                this.lbxProjets.Items.Clear();

                // Ouverture session
                NHibernate.ISession session = this.sessionFactory.OpenSession();

                // Démarrage Transaction
                NHibernate.ITransaction transaction = session.BeginTransaction();

                // Lire toute la table 'Projets'
                var listeProjets = session.CreateCriteria<Projet>().List<Projet>();

                // Tell NHibernate that this object should be saved
                //session.Save(contact);

                // Commit de la transaction
                transaction.Commit();

                // Fermeture session
                session.Close();

                // Ajout interface graphique
                //this.lbxProjets.Items.AddRange(listeProjets);
                foreach( Projet proj in listeProjets )
                {
                    this.lbxProjets.Items.Add( proj );
                }
            }
            catch (Exception ex)
            {
                Program.DisplayException(ex);
            }
        }

        private void btnSaisirProjet_Click( object sender, EventArgs e )
        {
            try
            {
                // Saisie utilisateur
                string nomProjet = Interaction.InputBox( "Quel est le nom du projet ?" );

                // Création objet
                Projet projet = new Projet( nomProjet );

                // Ouverture session
                NHibernate.ISession session = this.sessionFactory.OpenSession();

                // Démarrage Transaction
                NHibernate.ITransaction transaction = session.BeginTransaction();

                // Tell NHibernate that this object should be saved
                session.Save( projet );

                // Commit de la transaction
                transaction.Commit();

                // Fermeture session
                session.Close();
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }

        private void btnSaisirPersonne_Click( object sender, EventArgs e )
        {

        }
    }
}



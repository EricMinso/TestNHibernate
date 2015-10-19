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

// Internal References
//using DataModel;
//using NHibernateDataAccess;


namespace NHibernateTestProject //TestNHibernate2
{
    public partial class FormMain : Form
    {
#region Instance Variables

        private DataManager _dataManager;

#endregion
#region Constructor, Destructor

        public FormMain()
        {
            InitializeComponent();
            _dataManager = DataManager.getInstance();
        }

        ~FormMain()
        { 
        }

#endregion
#region GUI event handlers

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLirePersonnes_Click(object sender, EventArgs e)
        {
            try
            {
                this.lbxPersonnes.Items.Clear();

                // Get data
                IList<Personne> personList = this._dataManager.getAllPersons();

                // Fill listbox with data from the database
                foreach( Personne pers in personList )
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
                this.lbxProjets.Items.Clear();

                // Get data
                IList<Projet> projectList = this._dataManager.getAllProjects();
                

                // Ajout interface graphique
                //this.lbxProjets.Items.AddRange(listeProjets);
                foreach( Projet proj in projectList )
                {
                    this.lbxProjets.Items.Add( proj );
                }
            }
            catch (Exception ex)
            {
                Program.DisplayException(ex);
            }//*/
        }

        private void btnSaisirProjet_Click( object sender, EventArgs e )
        {
            try
            {
                // Saisie utilisateur
                string nomProjet = Interaction.InputBox( "Quel est le nom du projet ?" );

                // Création objet
                Projet projet = new Projet( nomProjet );

                this._dataManager.saveProject( projet );
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }

        private void btnSaisirPersonne_Click( object sender, EventArgs e )
        {
            FormPersonne form = new FormPersonne();
            form.ShowDialog();

            if( form.PersonneSaisie != null )
            {
                try
                {
                    this._dataManager.savePerson( form.PersonneSaisie );
                }
                catch( Exception ex )
                {
                    Program.DisplayException( ex );
                }
            }//*/
        }
#endregion 
    }
}



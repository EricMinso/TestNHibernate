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
using DataModel;
using NHibernateDataAccess;


namespace TestNHibernate2
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLirePersonnes_Click(object sender, EventArgs e)
        {
            try
            {
                this.lbxPersons.Items.Clear();

                // Get data
                IList<Person> personList = this._dataManager.getAllPersons();

                // Fill listbox with data from the database
                foreach( Person pers in personList )
                {
                    this.lbxPersons.Items.Add( pers );
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
                this.lbxProjects.Items.Clear();

                // Get data
                IList<Project> projectList = this._dataManager.getAllProjects();
                

                // Ajout interface graphique
                //this.lbxProjets.Items.AddRange(listeProjets);
                foreach( Project proj in projectList )
                {
                    this.lbxProjects.Items.Add( proj );
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
                Project projet = new Project( nomProjet );

                this._dataManager.saveProject( projet );
            }
            catch( Exception ex )
            {
                Program.DisplayException( ex );
            }
        }

        private void btnSaisirPersonne_Click( object sender, EventArgs e )
        {
            FormPerson form = new FormPerson();
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



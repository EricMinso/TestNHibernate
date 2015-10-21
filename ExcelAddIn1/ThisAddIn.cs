using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

using System.Windows.Forms;

// Our internal references
using DataModel;
using NHibernateDataAccess;


namespace ExcelAddInNHibernate
{
    public partial class ThisAddIn
    {
#region Initialisation

        // Link to the database
        private DataManager _dataManager;


        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            try
            {
                this._dataManager = DataManager.getInstance();
            }
            catch( Exception ex )
            {
                this._dataManager = null;
                DisplayException( ex );
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

#endregion
#region Plugin Common Methods

        public IList<Person> getAllPersons()
        {
            if( this._dataManager != null )
                return this._dataManager.getAllPersons();
            else
                throw new ThisAddinException( ThisAddinException.DATA_MANAGER_UNAVAILABLE );
        }

        public IList<Project> getAllProjects()
        {
            if( this._dataManager != null )
                return this._dataManager.getAllProjects();
            else
                throw new ThisAddinException( ThisAddinException.DATA_MANAGER_UNAVAILABLE );
        }

        /// <summary>
        /// Displays all exceptions the same way
        /// </summary>
        /// <param name="ex">The exception to display</param>
        public static void DisplayException( Exception ex )
        {
            MessageBox.Show(
                ex.GetType() + " : " + ex.Message + "\n" + ex.StackTrace,
                "Error : " + ex.Source,
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1
            );

            if( ex.InnerException != null &&
              DialogResult.Yes == MessageBox.Show( "More details are available. Would you like to read it ?", "InnerException has been found", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ) )
                DisplayException( ex.InnerException );
        }

#endregion
#region Code généré par VSTO

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
#endregion
    }
}

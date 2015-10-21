using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;


// Our internal references
using DataModel;
using NHibernateDataAccess;


namespace ExcelAddInNHibernate
{
    public partial class RibbonNHibernate
    {
        private void Ribbon1_Load( object sender, RibbonUIEventArgs e )
        {

        }

        /// <summary>
        /// Show or hide our user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tglActivatePane_Click( object sender, RibbonControlEventArgs e )
        {
            // Get my Excel references
            Microsoft.Office.Interop.Excel.Application myApplication = Globals.ThisAddIn.Application; //if (myApplication.Workbooks.Count == 0) return;
            Microsoft.Office.Interop.Excel.Window currentWindow = myApplication.ActiveWindow;
            Microsoft.Office.Tools.CustomTaskPane customPane = Globals.ThisAddIn.CustomTaskPanes.Where( pane => pane.Window == currentWindow ).FirstOrDefault();
            
            if( customPane == null )
            {
                // System.Windows.Forms.MessageBox.Show( "Create new control" );
                UserControlNHibernate container = new UserControlNHibernate();
                customPane = Globals.ThisAddIn.CustomTaskPanes.Add( container, "Action Pane", currentWindow );
                customPane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionLeft;
            }

            customPane.Visible = this.tglActivatePane.Checked;
        }

        /// <summary>
        /// Action done when pressing button "Read All Persons"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadAllPersons_Click( object sender, RibbonControlEventArgs e )
        {
            try
            {
                IList<Person> personList = Globals.ThisAddIn.getAllPersons();
            }
            catch( Exception ex )
            {
                ThisAddIn.DisplayException( ex );
            }
        }

        /// <summary>
        /// Action done when pressing button "Read All Projects"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadAllProjects_Click( object sender, RibbonControlEventArgs e )
        {
            try
            {
                IList<Project> projectList = Globals.ThisAddIn.getAllProjects();
            }
            catch( Exception ex )
            {
                ThisAddIn.DisplayException( ex );
            }
        }
    }
}

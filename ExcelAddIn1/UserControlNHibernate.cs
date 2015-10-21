using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Our internal references
using DataModel;
using NHibernateDataAccess;


namespace ExcelAddInNHibernate
{
    public partial class UserControlNHibernate : UserControl
    {
        public UserControlNHibernate()
        {
            InitializeComponent();
        }

        private void btnReadAllPersons_Click( object sender, EventArgs e )
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

        private void btnReadAllProjects_Click( object sender, EventArgs e )
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

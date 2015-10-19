using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNHibernate2
{
    public static class Program
    {
        /// <summary>
        /// The Entry point
        /// </summary>
        [STAThread]
        public static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
            catch( Exception ex )
            {
                DisplayException(ex);
            }
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
              DialogResult.Yes == MessageBox.Show("More details are available. Would you like to read it ?", "InnerException has been found", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ))
                DisplayException( ex.InnerException );
        }
    }
}

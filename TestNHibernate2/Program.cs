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
        /// Point d'entrée principal de l'application.
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

        public static void DisplayException( Exception ex )
        {
            MessageBox.Show(
                ex.GetType() + " : " + ex.Message + "\n" + ex.StackTrace, 
                "Erreur : " + ex.Source, 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation, 
                MessageBoxDefaultButton.Button1
            );

            if( ex.InnerException != null &&
              DialogResult.Yes == MessageBox.Show("Une exception plus précise est à l'origine de cette erreur. Voulez-vous la consulter ?", "InnerException trouvée", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ))
                DisplayException( ex.InnerException );
        }
    }
}

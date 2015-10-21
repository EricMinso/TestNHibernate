namespace ExcelAddInNHibernate
{
    partial class RibbonNHibernate : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonNHibernate()
            : base( Globals.Factory.GetRibbonFactory() )
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tabNHibernate = this.Factory.CreateRibbonTab();
            this.groupPane = this.Factory.CreateRibbonGroup();
            this.tglActivatePane = this.Factory.CreateRibbonToggleButton();
            this.groupPersons = this.Factory.CreateRibbonGroup();
            this.groupProjects = this.Factory.CreateRibbonGroup();
            this.btnReadAllPersons = this.Factory.CreateRibbonButton();
            this.btnReadAllProjects = this.Factory.CreateRibbonButton();
            this.tabNHibernate.SuspendLayout();
            this.groupPane.SuspendLayout();
            this.groupPersons.SuspendLayout();
            this.groupProjects.SuspendLayout();
            // 
            // tabNHibernate
            // 
            this.tabNHibernate.Groups.Add(this.groupPane);
            this.tabNHibernate.Groups.Add(this.groupPersons);
            this.tabNHibernate.Groups.Add(this.groupProjects);
            this.tabNHibernate.Label = "AddIn NHibernate";
            this.tabNHibernate.Name = "tabNHibernate";
            // 
            // groupPane
            // 
            this.groupPane.DialogLauncher = ribbonDialogLauncherImpl1;
            this.groupPane.Items.Add(this.tglActivatePane);
            this.groupPane.Label = "Pane";
            this.groupPane.Name = "groupPane";
            // 
            // tglActivatePane
            // 
            this.tglActivatePane.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.tglActivatePane.Label = "Activate pane";
            this.tglActivatePane.Name = "tglActivatePane";
            this.tglActivatePane.OfficeImageId = "AppointmentColorDialog";
            this.tglActivatePane.ShowImage = true;
            this.tglActivatePane.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tglActivatePane_Click);
            // 
            // groupPersons
            // 
            this.groupPersons.Items.Add(this.btnReadAllPersons);
            this.groupPersons.Label = "Persons";
            this.groupPersons.Name = "groupPersons";
            // 
            // groupProjects
            // 
            this.groupProjects.Items.Add(this.btnReadAllProjects);
            this.groupProjects.Label = "Projects";
            this.groupProjects.Name = "groupProjects";
            // 
            // btnReadAllPersons
            // 
            this.btnReadAllPersons.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnReadAllPersons.Label = "Read all persons";
            this.btnReadAllPersons.Name = "btnReadAllPersons";
            this.btnReadAllPersons.OfficeImageId = "CreateTableTemplatesGallery";
            this.btnReadAllPersons.ShowImage = true;
            this.btnReadAllPersons.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnReadAllPersons_Click);
            // 
            // btnReadAllProjects
            // 
            this.btnReadAllProjects.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnReadAllProjects.Label = "Read all projects";
            this.btnReadAllProjects.Name = "btnReadAllProjects";
            this.btnReadAllProjects.OfficeImageId = "FileManageMenu";
            this.btnReadAllProjects.ShowImage = true;
            this.btnReadAllProjects.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnReadAllProjects_Click);
            // 
            // RibbonNHibernate
            // 
            this.Name = "RibbonNHibernate";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabNHibernate);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tabNHibernate.ResumeLayout(false);
            this.tabNHibernate.PerformLayout();
            this.groupPane.ResumeLayout(false);
            this.groupPane.PerformLayout();
            this.groupPersons.ResumeLayout(false);
            this.groupPersons.PerformLayout();
            this.groupProjects.ResumeLayout(false);
            this.groupProjects.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabNHibernate;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupPersons;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupProjects;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupPane;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton tglActivatePane;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnReadAllPersons;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnReadAllProjects;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonNHibernate Ribbon1
        {
            get { return this.GetRibbon<RibbonNHibernate>(); }
        }
    }
}

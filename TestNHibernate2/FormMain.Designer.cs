namespace TestNHibernate2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPersons = new System.Windows.Forms.Label();
            this.lbxPersons = new System.Windows.Forms.ListBox();
            this.lbxProjects = new System.Windows.Forms.ListBox();
            this.lblProjects = new System.Windows.Forms.Label();
            this.flpPerson = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReadPersons = new System.Windows.Forms.Button();
            this.btnInputPerson = new System.Windows.Forms.Button();
            this.flpProject = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnInputProject = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.flpPerson.SuspendLayout();
            this.flpProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.flpButtons, 1, 3);
            this.tlpMain.Controls.Add(this.lblPersons, 0, 0);
            this.tlpMain.Controls.Add(this.lbxPersons, 0, 1);
            this.tlpMain.Controls.Add(this.lbxProjects, 1, 1);
            this.tlpMain.Controls.Add(this.lblProjects, 1, 0);
            this.tlpMain.Controls.Add(this.flpPerson, 0, 2);
            this.tlpMain.Controls.Add(this.flpProject, 1, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(20, 20);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(5);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(5);
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(681, 344);
            this.tlpMain.TabIndex = 0;
            // 
            // flpButtons
            // 
            this.flpButtons.AutoSize = true;
            this.flpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpButtons.Controls.Add(this.btnClose);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButtons.Location = new System.Drawing.Point(343, 307);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(330, 29);
            this.flpButtons.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(252, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPersons
            // 
            this.lblPersons.AutoSize = true;
            this.lblPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersons.Location = new System.Drawing.Point(8, 5);
            this.lblPersons.Name = "lblPersons";
            this.lblPersons.Size = new System.Drawing.Size(66, 13);
            this.lblPersons.TabIndex = 2;
            this.lblPersons.Text = "Persons";
            // 
            // lbxPersons
            // 
            this.lbxPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxPersons.FormattingEnabled = true;
            this.lbxPersons.Location = new System.Drawing.Point(8, 21);
            this.lbxPersons.Name = "lbxPersons";
            this.lbxPersons.Size = new System.Drawing.Size(329, 245);
            this.lbxPersons.TabIndex = 3;
            // 
            // lbxProjects
            // 
            this.lbxProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxProjects.FormattingEnabled = true;
            this.lbxProjects.Location = new System.Drawing.Point(343, 21);
            this.lbxProjects.Name = "lbxProjects";
            this.lbxProjects.Size = new System.Drawing.Size(330, 245);
            this.lbxProjects.TabIndex = 3;
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjects.Location = new System.Drawing.Point(343, 5);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(46, 13);
            this.lblProjects.TabIndex = 2;
            this.lblProjects.Text = "Projects";
            // 
            // flpPerson
            // 
            this.flpPerson.AutoSize = true;
            this.flpPerson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpPerson.Controls.Add(this.btnReadPersons);
            this.flpPerson.Controls.Add(this.btnInputPerson);
            this.flpPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPerson.Location = new System.Drawing.Point(8, 272);
            this.flpPerson.Name = "flpPerson";
            this.flpPerson.Size = new System.Drawing.Size(329, 29);
            this.flpPerson.TabIndex = 4;
            // 
            // btnReadPersons
            // 
            this.btnReadPersons.Location = new System.Drawing.Point(3, 3);
            this.btnReadPersons.Name = "btnReadPersons";
            this.btnReadPersons.Size = new System.Drawing.Size(112, 23);
            this.btnReadPersons.TabIndex = 1;
            this.btnReadPersons.Text = "Read Persons";
            this.btnReadPersons.UseVisualStyleBackColor = true;
            this.btnReadPersons.Click += new System.EventHandler(this.btnLirePersonnes_Click);
            // 
            // btnInputPerson
            // 
            this.btnInputPerson.Location = new System.Drawing.Point(121, 3);
            this.btnInputPerson.Name = "btnInputPerson";
            this.btnInputPerson.Size = new System.Drawing.Size(112, 23);
            this.btnInputPerson.TabIndex = 1;
            this.btnInputPerson.Text = "Input Personne";
            this.btnInputPerson.UseVisualStyleBackColor = true;
            this.btnInputPerson.Click += new System.EventHandler(this.btnSaisirPersonne_Click);
            // 
            // flpProject
            // 
            this.flpProject.AutoSize = true;
            this.flpProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpProject.Controls.Add(this.btnProjects);
            this.flpProject.Controls.Add(this.btnInputProject);
            this.flpProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProject.Location = new System.Drawing.Point(343, 272);
            this.flpProject.Name = "flpProject";
            this.flpProject.Size = new System.Drawing.Size(330, 29);
            this.flpProject.TabIndex = 5;
            // 
            // btnProjects
            // 
            this.btnProjects.Location = new System.Drawing.Point(3, 3);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(112, 23);
            this.btnProjects.TabIndex = 1;
            this.btnProjects.Text = "Read Projects";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnLireProjets_Click);
            // 
            // btnInputProject
            // 
            this.btnInputProject.Location = new System.Drawing.Point(121, 3);
            this.btnInputProject.Name = "btnInputProject";
            this.btnInputProject.Size = new System.Drawing.Size(112, 23);
            this.btnInputProject.TabIndex = 1;
            this.btnInputProject.Text = "Input Project";
            this.btnInputProject.UseVisualStyleBackColor = true;
            this.btnInputProject.Click += new System.EventHandler(this.btnSaisirProjet_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(721, 384);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FormMain";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.flpPerson.ResumeLayout(false);
            this.flpProject.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReadPersons;
        private System.Windows.Forms.Label lblPersons;
        private System.Windows.Forms.ListBox lbxPersons;
        private System.Windows.Forms.ListBox lbxProjects;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.FlowLayoutPanel flpPerson;
        private System.Windows.Forms.Button btnInputPerson;
        private System.Windows.Forms.FlowLayoutPanel flpProject;
        private System.Windows.Forms.Button btnInputProject;
    }
}
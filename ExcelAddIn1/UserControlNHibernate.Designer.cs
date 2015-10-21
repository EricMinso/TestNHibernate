namespace ExcelAddInNHibernate
{
    partial class UserControlNHibernate
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.gbPersons = new System.Windows.Forms.GroupBox();
            this.gbProjects = new System.Windows.Forms.GroupBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPersons = new System.Windows.Forms.TableLayoutPanel();
            this.btnReadAllPersons = new System.Windows.Forms.Button();
            this.tlpProjects = new System.Windows.Forms.TableLayoutPanel();
            this.btnReadAllProjects = new System.Windows.Forms.Button();
            this.gbPersons.SuspendLayout();
            this.gbProjects.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpPersons.SuspendLayout();
            this.tlpProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersons
            // 
            this.gbPersons.AutoSize = true;
            this.gbPersons.Controls.Add(this.tlpPersons);
            this.gbPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPersons.Location = new System.Drawing.Point(10, 10);
            this.gbPersons.Margin = new System.Windows.Forms.Padding(10);
            this.gbPersons.Name = "gbPersons";
            this.gbPersons.Size = new System.Drawing.Size(112, 77);
            this.gbPersons.TabIndex = 0;
            this.gbPersons.TabStop = false;
            this.gbPersons.Text = "Persons";
            // 
            // gbProjects
            // 
            this.gbProjects.AutoSize = true;
            this.gbProjects.Controls.Add(this.tlpProjects);
            this.gbProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProjects.Location = new System.Drawing.Point(10, 107);
            this.gbProjects.Margin = new System.Windows.Forms.Padding(10);
            this.gbProjects.Name = "gbProjects";
            this.gbProjects.Size = new System.Drawing.Size(112, 77);
            this.gbProjects.TabIndex = 1;
            this.gbProjects.TabStop = false;
            this.gbProjects.Text = "Projects";
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.gbProjects, 0, 1);
            this.tlpMain.Controls.Add(this.gbPersons, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(20, 20);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(132, 214);
            this.tlpMain.TabIndex = 2;
            // 
            // tlpPersons
            // 
            this.tlpPersons.AutoSize = true;
            this.tlpPersons.ColumnCount = 1;
            this.tlpPersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPersons.Controls.Add(this.btnReadAllPersons, 0, 0);
            this.tlpPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPersons.Location = new System.Drawing.Point(3, 16);
            this.tlpPersons.Name = "tlpPersons";
            this.tlpPersons.RowCount = 2;
            this.tlpPersons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPersons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPersons.Size = new System.Drawing.Size(106, 58);
            this.tlpPersons.TabIndex = 0;
            // 
            // btnReadAllPersons
            // 
            this.btnReadAllPersons.Location = new System.Drawing.Point(3, 3);
            this.btnReadAllPersons.Name = "btnReadAllPersons";
            this.btnReadAllPersons.Size = new System.Drawing.Size(100, 23);
            this.btnReadAllPersons.TabIndex = 0;
            this.btnReadAllPersons.Text = "Read Persons";
            this.btnReadAllPersons.UseVisualStyleBackColor = true;
            this.btnReadAllPersons.Click += new System.EventHandler(this.btnReadAllPersons_Click);
            // 
            // tlpProjects
            // 
            this.tlpProjects.AutoSize = true;
            this.tlpProjects.ColumnCount = 1;
            this.tlpProjects.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProjects.Controls.Add(this.btnReadAllProjects, 0, 0);
            this.tlpProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProjects.Location = new System.Drawing.Point(3, 16);
            this.tlpProjects.Name = "tlpProjects";
            this.tlpProjects.RowCount = 2;
            this.tlpProjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProjects.Size = new System.Drawing.Size(106, 58);
            this.tlpProjects.TabIndex = 0;
            // 
            // btnReadAllProjects
            // 
            this.btnReadAllProjects.Location = new System.Drawing.Point(3, 3);
            this.btnReadAllProjects.Name = "btnReadAllProjects";
            this.btnReadAllProjects.Size = new System.Drawing.Size(100, 23);
            this.btnReadAllProjects.TabIndex = 0;
            this.btnReadAllProjects.Text = "Read Projects";
            this.btnReadAllProjects.UseVisualStyleBackColor = true;
            this.btnReadAllProjects.Click += new System.EventHandler(this.btnReadAllProjects_Click);
            // 
            // UserControlNHibernate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlpMain);
            this.Name = "UserControlNHibernate";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(172, 254);
            this.gbPersons.ResumeLayout(false);
            this.gbPersons.PerformLayout();
            this.gbProjects.ResumeLayout(false);
            this.gbProjects.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpPersons.ResumeLayout(false);
            this.tlpProjects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersons;
        private System.Windows.Forms.GroupBox gbProjects;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpPersons;
        private System.Windows.Forms.Button btnReadAllPersons;
        private System.Windows.Forms.TableLayoutPanel tlpProjects;
        private System.Windows.Forms.Button btnReadAllProjects;
    }
}

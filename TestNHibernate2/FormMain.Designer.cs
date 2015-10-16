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
            this.flpBoutons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnLirePersonnes = new System.Windows.Forms.Button();
            this.lblPersonnes = new System.Windows.Forms.Label();
            this.lbxPersonnes = new System.Windows.Forms.ListBox();
            this.lbxProjets = new System.Windows.Forms.ListBox();
            this.lblProjets = new System.Windows.Forms.Label();
            this.btnProjets = new System.Windows.Forms.Button();
            this.flpPersonne = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaisirPersonne = new System.Windows.Forms.Button();
            this.flpProjet = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaisirProjet = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.flpBoutons.SuspendLayout();
            this.flpPersonne.SuspendLayout();
            this.flpProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.flpBoutons, 1, 3);
            this.tlpMain.Controls.Add(this.lblPersonnes, 0, 0);
            this.tlpMain.Controls.Add(this.lbxPersonnes, 0, 1);
            this.tlpMain.Controls.Add(this.lbxProjets, 1, 1);
            this.tlpMain.Controls.Add(this.lblProjets, 1, 0);
            this.tlpMain.Controls.Add(this.flpPersonne, 0, 2);
            this.tlpMain.Controls.Add(this.flpProjet, 1, 2);
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
            // flpBoutons
            // 
            this.flpBoutons.AutoSize = true;
            this.flpBoutons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBoutons.Controls.Add(this.btnFermer);
            this.flpBoutons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBoutons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBoutons.Location = new System.Drawing.Point(343, 307);
            this.flpBoutons.Name = "flpBoutons";
            this.flpBoutons.Size = new System.Drawing.Size(330, 29);
            this.flpBoutons.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(252, 3);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 0;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnLirePersonnes
            // 
            this.btnLirePersonnes.Location = new System.Drawing.Point(3, 3);
            this.btnLirePersonnes.Name = "btnLirePersonnes";
            this.btnLirePersonnes.Size = new System.Drawing.Size(112, 23);
            this.btnLirePersonnes.TabIndex = 1;
            this.btnLirePersonnes.Text = "Lire Personnes";
            this.btnLirePersonnes.UseVisualStyleBackColor = true;
            this.btnLirePersonnes.Click += new System.EventHandler(this.btnLirePersonnes_Click);
            // 
            // lblPersonnes
            // 
            this.lblPersonnes.AutoSize = true;
            this.lblPersonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnes.Location = new System.Drawing.Point(8, 5);
            this.lblPersonnes.Name = "lblPersonnes";
            this.lblPersonnes.Size = new System.Drawing.Size(66, 13);
            this.lblPersonnes.TabIndex = 2;
            this.lblPersonnes.Text = "Personnes";
            // 
            // lbxPersonnes
            // 
            this.lbxPersonnes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxPersonnes.FormattingEnabled = true;
            this.lbxPersonnes.Location = new System.Drawing.Point(8, 21);
            this.lbxPersonnes.Name = "lbxPersonnes";
            this.lbxPersonnes.Size = new System.Drawing.Size(329, 245);
            this.lbxPersonnes.TabIndex = 3;
            // 
            // lbxProjets
            // 
            this.lbxProjets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxProjets.FormattingEnabled = true;
            this.lbxProjets.Location = new System.Drawing.Point(343, 21);
            this.lbxProjets.Name = "lbxProjets";
            this.lbxProjets.Size = new System.Drawing.Size(330, 245);
            this.lbxProjets.TabIndex = 3;
            // 
            // lblProjets
            // 
            this.lblProjets.AutoSize = true;
            this.lblProjets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjets.Location = new System.Drawing.Point(343, 5);
            this.lblProjets.Name = "lblProjets";
            this.lblProjets.Size = new System.Drawing.Size(46, 13);
            this.lblProjets.TabIndex = 2;
            this.lblProjets.Text = "Projets";
            // 
            // btnProjets
            // 
            this.btnProjets.Location = new System.Drawing.Point(3, 3);
            this.btnProjets.Name = "btnProjets";
            this.btnProjets.Size = new System.Drawing.Size(112, 23);
            this.btnProjets.TabIndex = 1;
            this.btnProjets.Text = "Lire Projets";
            this.btnProjets.UseVisualStyleBackColor = true;
            this.btnProjets.Click += new System.EventHandler(this.btnLireProjets_Click);
            // 
            // flpPersonne
            // 
            this.flpPersonne.AutoSize = true;
            this.flpPersonne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpPersonne.Controls.Add(this.btnLirePersonnes);
            this.flpPersonne.Controls.Add(this.btnSaisirPersonne);
            this.flpPersonne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPersonne.Location = new System.Drawing.Point(8, 272);
            this.flpPersonne.Name = "flpPersonne";
            this.flpPersonne.Size = new System.Drawing.Size(329, 29);
            this.flpPersonne.TabIndex = 4;
            // 
            // btnSaisirPersonne
            // 
            this.btnSaisirPersonne.Location = new System.Drawing.Point(121, 3);
            this.btnSaisirPersonne.Name = "btnSaisirPersonne";
            this.btnSaisirPersonne.Size = new System.Drawing.Size(112, 23);
            this.btnSaisirPersonne.TabIndex = 1;
            this.btnSaisirPersonne.Text = "Saisir Personne";
            this.btnSaisirPersonne.UseVisualStyleBackColor = true;
            this.btnSaisirPersonne.Click += new System.EventHandler(this.btnSaisirPersonne_Click);
            // 
            // flpProjet
            // 
            this.flpProjet.AutoSize = true;
            this.flpProjet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpProjet.Controls.Add(this.btnProjets);
            this.flpProjet.Controls.Add(this.btnSaisirProjet);
            this.flpProjet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProjet.Location = new System.Drawing.Point(343, 272);
            this.flpProjet.Name = "flpProjet";
            this.flpProjet.Size = new System.Drawing.Size(330, 29);
            this.flpProjet.TabIndex = 5;
            // 
            // btnSaisirProjet
            // 
            this.btnSaisirProjet.Location = new System.Drawing.Point(121, 3);
            this.btnSaisirProjet.Name = "btnSaisirProjet";
            this.btnSaisirProjet.Size = new System.Drawing.Size(112, 23);
            this.btnSaisirProjet.TabIndex = 1;
            this.btnSaisirProjet.Text = "Saisir Projet";
            this.btnSaisirProjet.UseVisualStyleBackColor = true;
            this.btnSaisirProjet.Click += new System.EventHandler(this.btnSaisirProjet_Click);
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
            this.flpBoutons.ResumeLayout(false);
            this.flpPersonne.ResumeLayout(false);
            this.flpProjet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpBoutons;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnLirePersonnes;
        private System.Windows.Forms.Label lblPersonnes;
        private System.Windows.Forms.ListBox lbxPersonnes;
        private System.Windows.Forms.ListBox lbxProjets;
        private System.Windows.Forms.Label lblProjets;
        private System.Windows.Forms.Button btnProjets;
        private System.Windows.Forms.FlowLayoutPanel flpPersonne;
        private System.Windows.Forms.Button btnSaisirPersonne;
        private System.Windows.Forms.FlowLayoutPanel flpProjet;
        private System.Windows.Forms.Button btnSaisirProjet;
    }
}
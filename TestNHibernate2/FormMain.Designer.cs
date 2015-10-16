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
            this.btnLire = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.flpBoutons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.flpBoutons, 0, 2);
            this.tlpMain.Controls.Add(this.btnLire, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(457, 334);
            this.tlpMain.TabIndex = 0;
            // 
            // flpBoutons
            // 
            this.flpBoutons.AutoSize = true;
            this.flpBoutons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBoutons.Controls.Add(this.btnFermer);
            this.flpBoutons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBoutons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBoutons.Location = new System.Drawing.Point(3, 301);
            this.flpBoutons.Name = "flpBoutons";
            this.flpBoutons.Size = new System.Drawing.Size(451, 30);
            this.flpBoutons.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(373, 3);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 0;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnLire
            // 
            this.btnLire.Location = new System.Drawing.Point(3, 3);
            this.btnLire.Name = "btnLire";
            this.btnLire.Size = new System.Drawing.Size(75, 23);
            this.btnLire.TabIndex = 1;
            this.btnLire.Text = "Lire";
            this.btnLire.UseVisualStyleBackColor = true;
            this.btnLire.Click += new System.EventHandler(this.btnLire_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 334);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.flpBoutons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpBoutons;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnLire;
    }
}
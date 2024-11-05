namespace Suites_Numériques
{
    partial class Interface_Acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip_Entrainement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Arithmetiques = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Geometrique = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Quelconques = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Jouer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_SansContrainte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_AvecContrainte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Meilleurs_temps = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Acceuil = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Entrainement,
            this.menuStrip_Jouer,
            this.menuStrip_Meilleurs_temps});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip2";
            // 
            // menuStrip_Entrainement
            // 
            this.menuStrip_Entrainement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Arithmetiques,
            this.toolStrip_Geometrique,
            this.toolStrip_Quelconques});
            this.menuStrip_Entrainement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip_Entrainement.Name = "menuStrip_Entrainement";
            this.menuStrip_Entrainement.Size = new System.Drawing.Size(169, 20);
            this.menuStrip_Entrainement.Text = "Entrainement sur les Suites...";
            // 
            // toolStrip_Arithmetiques
            // 
            this.toolStrip_Arithmetiques.Name = "toolStrip_Arithmetiques";
            this.toolStrip_Arithmetiques.Size = new System.Drawing.Size(202, 22);
            this.toolStrip_Arithmetiques.Text = "Arithmétiques";
            this.toolStrip_Arithmetiques.Click += new System.EventHandler(this.toolStrip_Arithmetiques_Click);
            // 
            // toolStrip_Geometrique
            // 
            this.toolStrip_Geometrique.Name = "toolStrip_Geometrique";
            this.toolStrip_Geometrique.Size = new System.Drawing.Size(202, 22);
            this.toolStrip_Geometrique.Text = "Géométrique";
            this.toolStrip_Geometrique.Click += new System.EventHandler(this.toolStrip_Geometrique_Click);
            // 
            // toolStrip_Quelconques
            // 
            this.toolStrip_Quelconques.Name = "toolStrip_Quelconques";
            this.toolStrip_Quelconques.Size = new System.Drawing.Size(202, 22);
            this.toolStrip_Quelconques.Text = "Quelconques (en projet)";
            // 
            // menuStrip_Jouer
            // 
            this.menuStrip_Jouer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_SansContrainte,
            this.toolStrip_AvecContrainte});
            this.menuStrip_Jouer.Name = "menuStrip_Jouer";
            this.menuStrip_Jouer.Size = new System.Drawing.Size(56, 20);
            this.menuStrip_Jouer.Text = "Jouer...";
            // 
            // toolStrip_SansContrainte
            // 
            this.toolStrip_SansContrainte.Name = "toolStrip_SansContrainte";
            this.toolStrip_SansContrainte.Size = new System.Drawing.Size(209, 22);
            this.toolStrip_SansContrainte.Text = "Sans Contrainte";
            // 
            // toolStrip_AvecContrainte
            // 
            this.toolStrip_AvecContrainte.Name = "toolStrip_AvecContrainte";
            this.toolStrip_AvecContrainte.Size = new System.Drawing.Size(209, 22);
            this.toolStrip_AvecContrainte.Text = "Avec contrainte de temps";
            // 
            // menuStrip_Meilleurs_temps
            // 
            this.menuStrip_Meilleurs_temps.Name = "menuStrip_Meilleurs_temps";
            this.menuStrip_Meilleurs_temps.Size = new System.Drawing.Size(103, 20);
            this.menuStrip_Meilleurs_temps.Text = "Meilleurs temps";
            // 
            // label_Acceuil
            // 
            this.label_Acceuil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Acceuil.BackColor = System.Drawing.Color.Khaki;
            this.label_Acceuil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Acceuil.Font = new System.Drawing.Font("French Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Acceuil.Location = new System.Drawing.Point(12, 56);
            this.label_Acceuil.Name = "label_Acceuil";
            this.label_Acceuil.Size = new System.Drawing.Size(860, 57);
            this.label_Acceuil.TabIndex = 2;
            this.label_Acceuil.Text = "Fondamentaux sur les suites numériques";
            this.label_Acceuil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Interface_Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label_Acceuil);
            this.Controls.Add(this.menuStrip);
            this.Name = "Interface_Acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etude des suites numérique en mathématique";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Entrainement;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Geometrique;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Quelconques;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Jouer;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Meilleurs_temps;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Arithmetiques;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_SansContrainte;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_AvecContrainte;
        private System.Windows.Forms.Label label_Acceuil;
    }
}


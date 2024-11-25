namespace Suites_Numériques
{
    partial class Interface_Scores
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
            this.label_vainqueur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_joueur1 = new System.Windows.Forms.Label();
            this.label_joueur2 = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_nouvelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_vainqueur
            // 
            this.label_vainqueur.BackColor = System.Drawing.SystemColors.Info;
            this.label_vainqueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vainqueur.ForeColor = System.Drawing.Color.Red;
            this.label_vainqueur.Location = new System.Drawing.Point(48, 21);
            this.label_vainqueur.Name = "label_vainqueur";
            this.label_vainqueur.Size = new System.Drawing.Size(460, 93);
            this.label_vainqueur.TabIndex = 0;
            this.label_vainqueur.Text = "VAINQUEUR : Joueur 1";
            this.label_vainqueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCORES";
            // 
            // label_joueur1
            // 
            this.label_joueur1.AutoSize = true;
            this.label_joueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_joueur1.Location = new System.Drawing.Point(217, 184);
            this.label_joueur1.Name = "label_joueur1";
            this.label_joueur1.Size = new System.Drawing.Size(104, 20);
            this.label_joueur1.TabIndex = 2;
            this.label_joueur1.Text = "label_joueur1";
            // 
            // label_joueur2
            // 
            this.label_joueur2.AutoSize = true;
            this.label_joueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_joueur2.Location = new System.Drawing.Point(217, 221);
            this.label_joueur2.Name = "label_joueur2";
            this.label_joueur2.Size = new System.Drawing.Size(104, 20);
            this.label_joueur2.TabIndex = 3;
            this.label_joueur2.Text = "label_joueur2";
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(12, 292);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(82, 31);
            this.btn_menu.TabIndex = 4;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_nouvelle
            // 
            this.btn_nouvelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nouvelle.Location = new System.Drawing.Point(395, 292);
            this.btn_nouvelle.Name = "btn_nouvelle";
            this.btn_nouvelle.Size = new System.Drawing.Size(145, 31);
            this.btn_nouvelle.TabIndex = 5;
            this.btn_nouvelle.Text = "Nouvelle partie";
            this.btn_nouvelle.UseVisualStyleBackColor = true;
            this.btn_nouvelle.Click += new System.EventHandler(this.btn_nouvelle_Click);
            // 
            // Interface_Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 335);
            this.Controls.Add(this.btn_nouvelle);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.label_joueur2);
            this.Controls.Add(this.label_joueur1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_vainqueur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Interface_Scores";
            this.ShowInTaskbar = false;
            this.Text = "Jeu : Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_vainqueur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_joueur1;
        private System.Windows.Forms.Label label_joueur2;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_nouvelle;
    }
}
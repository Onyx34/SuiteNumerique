namespace Suites_Numériques
{
    partial class Interface_Jeu
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
            this.label_joueur = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_points = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.groupBox_monotonie = new System.Windows.Forms.GroupBox();
            this.radioBtn_Décroissante = new System.Windows.Forms.RadioButton();
            this.radioBtn_Constante = new System.Windows.Forms.RadioButton();
            this.radioBtn_Croissante = new System.Windows.Forms.RadioButton();
            this.radioBtn_NonMonotone = new System.Windows.Forms.RadioButton();
            this.textBox_reponse2 = new System.Windows.Forms.TextBox();
            this.label_reponse2 = new System.Windows.Forms.Label();
            this.textBox_reponse1 = new System.Windows.Forms.TextBox();
            this.label_reponse1 = new System.Windows.Forms.Label();
            this.label_question = new System.Windows.Forms.Label();
            this.label_enonce = new System.Windows.Forms.Label();
            this.label_enonce2 = new System.Windows.Forms.Label();
            this.label_enonce1 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.button_passer = new System.Windows.Forms.Button();
            this.button_scores = new System.Windows.Forms.Button();
            this.button_regles = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.groupBox_monotonie.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_joueur
            // 
            this.label_joueur.AutoSize = true;
            this.label_joueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_joueur.Location = new System.Drawing.Point(12, 9);
            this.label_joueur.Name = "label_joueur";
            this.label_joueur.Size = new System.Drawing.Size(107, 20);
            this.label_joueur.TabIndex = 0;
            this.label_joueur.Text = "label_joueur";
            // 
            // label_nom
            // 
            this.label_nom.BackColor = System.Drawing.SystemColors.Info;
            this.label_nom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(135, 5);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(204, 29);
            this.label_nom.TabIndex = 1;
            this.label_nom.Text = "label_nom";
            this.label_nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_score
            // 
            this.label_score.BackColor = System.Drawing.SystemColors.Info;
            this.label_score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(609, 5);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(122, 29);
            this.label_score.TabIndex = 2;
            this.label_score.Text = "label_score";
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_points
            // 
            this.label_points.AutoSize = true;
            this.label_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_points.Location = new System.Drawing.Point(534, 9);
            this.label_points.Name = "label_points";
            this.label_points.Size = new System.Drawing.Size(69, 20);
            this.label_points.TabIndex = 3;
            this.label_points.Text = "Points :";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 53);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(766, 330);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.textBox_reponse2);
            this.tabPage.Controls.Add(this.label_reponse2);
            this.tabPage.Controls.Add(this.textBox_reponse1);
            this.tabPage.Controls.Add(this.label_reponse1);
            this.tabPage.Controls.Add(this.label_question);
            this.tabPage.Controls.Add(this.label_enonce);
            this.tabPage.Controls.Add(this.label_enonce2);
            this.tabPage.Controls.Add(this.label_enonce1);
            this.tabPage.Controls.Add(this.groupBox_monotonie);
            this.tabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage.Location = new System.Drawing.Point(4, 29);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(758, 297);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Question N° 1/6";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox_monotonie
            // 
            this.groupBox_monotonie.Controls.Add(this.radioBtn_Décroissante);
            this.groupBox_monotonie.Controls.Add(this.radioBtn_Constante);
            this.groupBox_monotonie.Controls.Add(this.radioBtn_Croissante);
            this.groupBox_monotonie.Controls.Add(this.radioBtn_NonMonotone);
            this.groupBox_monotonie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_monotonie.Location = new System.Drawing.Point(17, 186);
            this.groupBox_monotonie.Name = "groupBox_monotonie";
            this.groupBox_monotonie.Size = new System.Drawing.Size(393, 69);
            this.groupBox_monotonie.TabIndex = 41;
            this.groupBox_monotonie.TabStop = false;
            // 
            // radioBtn_Décroissante
            // 
            this.radioBtn_Décroissante.AutoSize = true;
            this.radioBtn_Décroissante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Décroissante.Location = new System.Drawing.Point(187, 39);
            this.radioBtn_Décroissante.Name = "radioBtn_Décroissante";
            this.radioBtn_Décroissante.Size = new System.Drawing.Size(194, 24);
            this.radioBtn_Décroissante.TabIndex = 3;
            this.radioBtn_Décroissante.TabStop = true;
            this.radioBtn_Décroissante.Text = "Monotone décroissante";
            this.radioBtn_Décroissante.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Constante
            // 
            this.radioBtn_Constante.AutoSize = true;
            this.radioBtn_Constante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Constante.Location = new System.Drawing.Point(187, 14);
            this.radioBtn_Constante.Name = "radioBtn_Constante";
            this.radioBtn_Constante.Size = new System.Drawing.Size(174, 24);
            this.radioBtn_Constante.TabIndex = 2;
            this.radioBtn_Constante.Text = "Monotone constante";
            this.radioBtn_Constante.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Croissante
            // 
            this.radioBtn_Croissante.AutoSize = true;
            this.radioBtn_Croissante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Croissante.Location = new System.Drawing.Point(6, 39);
            this.radioBtn_Croissante.Name = "radioBtn_Croissante";
            this.radioBtn_Croissante.Size = new System.Drawing.Size(176, 24);
            this.radioBtn_Croissante.TabIndex = 1;
            this.radioBtn_Croissante.TabStop = true;
            this.radioBtn_Croissante.Text = "Monotone croissante";
            this.radioBtn_Croissante.UseVisualStyleBackColor = true;
            // 
            // radioBtn_NonMonotone
            // 
            this.radioBtn_NonMonotone.AutoSize = true;
            this.radioBtn_NonMonotone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_NonMonotone.Location = new System.Drawing.Point(6, 14);
            this.radioBtn_NonMonotone.Name = "radioBtn_NonMonotone";
            this.radioBtn_NonMonotone.Size = new System.Drawing.Size(132, 24);
            this.radioBtn_NonMonotone.TabIndex = 0;
            this.radioBtn_NonMonotone.TabStop = true;
            this.radioBtn_NonMonotone.Text = "Non monotone";
            this.radioBtn_NonMonotone.UseVisualStyleBackColor = true;
            // 
            // textBox_reponse2
            // 
            this.textBox_reponse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reponse2.Location = new System.Drawing.Point(101, 222);
            this.textBox_reponse2.Name = "textBox_reponse2";
            this.textBox_reponse2.Size = new System.Drawing.Size(236, 26);
            this.textBox_reponse2.TabIndex = 39;
            // 
            // label_reponse2
            // 
            this.label_reponse2.AutoSize = true;
            this.label_reponse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reponse2.Location = new System.Drawing.Point(13, 225);
            this.label_reponse2.Name = "label_reponse2";
            this.label_reponse2.Size = new System.Drawing.Size(118, 20);
            this.label_reponse2.TabIndex = 40;
            this.label_reponse2.Text = "label_reponse2";
            // 
            // textBox_reponse1
            // 
            this.textBox_reponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reponse1.Location = new System.Drawing.Point(101, 190);
            this.textBox_reponse1.Name = "textBox_reponse1";
            this.textBox_reponse1.Size = new System.Drawing.Size(236, 26);
            this.textBox_reponse1.TabIndex = 15;
            // 
            // label_reponse1
            // 
            this.label_reponse1.AutoSize = true;
            this.label_reponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reponse1.Location = new System.Drawing.Point(13, 193);
            this.label_reponse1.Name = "label_reponse1";
            this.label_reponse1.Size = new System.Drawing.Size(118, 20);
            this.label_reponse1.TabIndex = 20;
            this.label_reponse1.Text = "label_reponse1";
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question.Location = new System.Drawing.Point(6, 163);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(112, 20);
            this.label_question.TabIndex = 19;
            this.label_question.Text = "label_question";
            // 
            // label_enonce
            // 
            this.label_enonce.AutoSize = true;
            this.label_enonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enonce.Location = new System.Drawing.Point(6, 35);
            this.label_enonce.Name = "label_enonce";
            this.label_enonce.Size = new System.Drawing.Size(104, 20);
            this.label_enonce.TabIndex = 18;
            this.label_enonce.Text = "label_enonce";
            // 
            // label_enonce2
            // 
            this.label_enonce2.AutoSize = true;
            this.label_enonce2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enonce2.Location = new System.Drawing.Point(31, 92);
            this.label_enonce2.Name = "label_enonce2";
            this.label_enonce2.Size = new System.Drawing.Size(113, 20);
            this.label_enonce2.TabIndex = 17;
            this.label_enonce2.Text = "label_enonce2";
            // 
            // label_enonce1
            // 
            this.label_enonce1.AutoSize = true;
            this.label_enonce1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enonce1.Location = new System.Drawing.Point(31, 63);
            this.label_enonce1.Name = "label_enonce1";
            this.label_enonce1.Size = new System.Drawing.Size(113, 20);
            this.label_enonce1.TabIndex = 16;
            this.label_enonce1.Text = "label_enonce1";
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.Location = new System.Drawing.Point(16, 403);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(95, 25);
            this.btn_valider.TabIndex = 24;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // button_passer
            // 
            this.button_passer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_passer.Location = new System.Drawing.Point(135, 403);
            this.button_passer.Name = "button_passer";
            this.button_passer.Size = new System.Drawing.Size(204, 25);
            this.button_passer.TabIndex = 25;
            this.button_passer.Text = "Passer la question...";
            this.button_passer.UseVisualStyleBackColor = true;
            // 
            // button_scores
            // 
            this.button_scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scores.Location = new System.Drawing.Point(564, 403);
            this.button_scores.Name = "button_scores";
            this.button_scores.Size = new System.Drawing.Size(95, 25);
            this.button_scores.TabIndex = 26;
            this.button_scores.Text = "Scores";
            this.button_scores.UseVisualStyleBackColor = true;
            // 
            // button_regles
            // 
            this.button_regles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_regles.Location = new System.Drawing.Point(679, 403);
            this.button_regles.Name = "button_regles";
            this.button_regles.Size = new System.Drawing.Size(95, 25);
            this.button_regles.TabIndex = 27;
            this.button_regles.Text = "Règles";
            this.button_regles.UseVisualStyleBackColor = true;
            // 
            // Interface_Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_regles);
            this.Controls.Add(this.button_scores);
            this.Controls.Add(this.button_passer);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label_points);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_joueur);
            this.Name = "Interface_Jeu";
            this.Text = "Interface_Jeu";
            this.tabControl.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.groupBox_monotonie.ResumeLayout(false);
            this.groupBox_monotonie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_joueur;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_points;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TextBox textBox_reponse1;
        private System.Windows.Forms.Label label_reponse1;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Label label_enonce;
        private System.Windows.Forms.Label label_enonce2;
        private System.Windows.Forms.Label label_enonce1;
        private System.Windows.Forms.TextBox textBox_reponse2;
        private System.Windows.Forms.Label label_reponse2;
        private System.Windows.Forms.GroupBox groupBox_monotonie;
        private System.Windows.Forms.RadioButton radioBtn_Décroissante;
        private System.Windows.Forms.RadioButton radioBtn_Constante;
        private System.Windows.Forms.RadioButton radioBtn_Croissante;
        private System.Windows.Forms.RadioButton radioBtn_NonMonotone;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button button_passer;
        private System.Windows.Forms.Button button_scores;
        private System.Windows.Forms.Button button_regles;
    }
}
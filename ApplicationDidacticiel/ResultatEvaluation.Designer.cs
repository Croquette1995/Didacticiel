namespace ApplicationDidacticiel
{
    partial class ResultatEvaluation
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
            this.lstReponseCorrect = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lblReponseCorrecte = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReponseIncorrecte = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lstReponseIncorrecte = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxResultatEtudiant = new System.Windows.Forms.PictureBox();
            this.lblResultatEtudiant = new System.Windows.Forms.Label();
            this.lblQuestion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReponse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtQuestion = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtReponse = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtInfosDuree = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblInfosDuree = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultatEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // lstReponseCorrect
            // 
            this.lstReponseCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstReponseCorrect.Location = new System.Drawing.Point(12, 185);
            this.lstReponseCorrect.Name = "lstReponseCorrect";
            this.lstReponseCorrect.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.lstReponseCorrect.Size = new System.Drawing.Size(368, 135);
            this.lstReponseCorrect.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lstReponseCorrect.StateCommon.Border.Rounding = 10;
            this.lstReponseCorrect.StateCommon.Item.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.lstReponseCorrect.TabIndex = 0;
            this.lstReponseCorrect.SelectedIndexChanged += new System.EventHandler(this.lstReponseCorrect_SelectedIndexChanged);
            // 
            // lblReponseCorrecte
            // 
            this.lblReponseCorrecte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReponseCorrecte.Location = new System.Drawing.Point(12, 160);
            this.lblReponseCorrecte.Name = "lblReponseCorrecte";
            this.lblReponseCorrecte.Size = new System.Drawing.Size(134, 19);
            this.lblReponseCorrecte.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReponseCorrecte.TabIndex = 1;
            this.lblReponseCorrecte.Values.Text = "Réponses correctes";
            // 
            // lblReponseIncorrecte
            // 
            this.lblReponseIncorrecte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReponseIncorrecte.Location = new System.Drawing.Point(12, 347);
            this.lblReponseIncorrecte.Name = "lblReponseIncorrecte";
            this.lblReponseIncorrecte.Size = new System.Drawing.Size(145, 19);
            this.lblReponseIncorrecte.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReponseIncorrecte.TabIndex = 2;
            this.lblReponseIncorrecte.Values.Text = "Réponses incorrectes";
            // 
            // lstReponseIncorrecte
            // 
            this.lstReponseIncorrecte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstReponseIncorrecte.Location = new System.Drawing.Point(12, 372);
            this.lstReponseIncorrecte.Name = "lstReponseIncorrecte";
            this.lstReponseIncorrecte.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.lstReponseIncorrecte.Size = new System.Drawing.Size(368, 135);
            this.lstReponseIncorrecte.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lstReponseIncorrecte.StateCommon.Border.Rounding = 10;
            this.lstReponseIncorrecte.StateCommon.Item.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.lstReponseIncorrecte.TabIndex = 3;
            this.lstReponseIncorrecte.SelectedIndexChanged += new System.EventHandler(this.lstReponseIncorrecte_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::ApplicationDidacticiel.Properties.Resources.checkbox_yes;
            this.label1.Location = new System.Drawing.Point(608, -31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 197);
            this.label1.TabIndex = 4;
            this.label1.Text = "Réussi !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Visible = false;
            // 
            // pictureBoxResultatEtudiant
            // 
            this.pictureBoxResultatEtudiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxResultatEtudiant.Location = new System.Drawing.Point(21, 12);
            this.pictureBoxResultatEtudiant.Name = "pictureBoxResultatEtudiant";
            this.pictureBoxResultatEtudiant.Size = new System.Drawing.Size(180, 142);
            this.pictureBoxResultatEtudiant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResultatEtudiant.TabIndex = 5;
            this.pictureBoxResultatEtudiant.TabStop = false;
            // 
            // lblResultatEtudiant
            // 
            this.lblResultatEtudiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultatEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultatEtudiant.Location = new System.Drawing.Point(224, 12);
            this.lblResultatEtudiant.Name = "lblResultatEtudiant";
            this.lblResultatEtudiant.Size = new System.Drawing.Size(406, 142);
            this.lblResultatEtudiant.TabIndex = 6;
            this.lblResultatEtudiant.Text = "lblResultatEtudiant";
            this.lblResultatEtudiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblQuestion.Location = new System.Drawing.Point(440, 288);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(77, 24);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Values.Text = "Question";
            // 
            // lblReponse
            // 
            this.lblReponse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReponse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblReponse.Location = new System.Drawing.Point(440, 409);
            this.lblReponse.Name = "lblReponse";
            this.lblReponse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.lblReponse.Size = new System.Drawing.Size(120, 24);
            this.lblReponse.TabIndex = 8;
            this.lblReponse.Values.Text = "Bonne réponse";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuestion.Location = new System.Drawing.Point(440, 318);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(316, 85);
            this.txtQuestion.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQuestion.StateCommon.Border.Rounding = 10;
            this.txtQuestion.TabIndex = 10;
            this.txtQuestion.Text = "Question";
            // 
            // txtReponse
            // 
            this.txtReponse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReponse.Location = new System.Drawing.Point(440, 439);
            this.txtReponse.Multiline = true;
            this.txtReponse.Name = "txtReponse";
            this.txtReponse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtReponse.ReadOnly = true;
            this.txtReponse.Size = new System.Drawing.Size(316, 68);
            this.txtReponse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReponse.StateCommon.Border.Rounding = 10;
            this.txtReponse.TabIndex = 11;
            this.txtReponse.Text = "Bonne réponse";
            // 
            // txtInfosDuree
            // 
            this.txtInfosDuree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInfosDuree.Location = new System.Drawing.Point(440, 185);
            this.txtInfosDuree.Multiline = true;
            this.txtInfosDuree.Name = "txtInfosDuree";
            this.txtInfosDuree.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtInfosDuree.ReadOnly = true;
            this.txtInfosDuree.Size = new System.Drawing.Size(316, 97);
            this.txtInfosDuree.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtInfosDuree.StateCommon.Border.Rounding = 10;
            this.txtInfosDuree.TabIndex = 12;
            this.txtInfosDuree.Text = "Durée";
            // 
            // lblInfosDuree
            // 
            this.lblInfosDuree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfosDuree.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblInfosDuree.Location = new System.Drawing.Point(440, 155);
            this.lblInfosDuree.Name = "lblInfosDuree";
            this.lblInfosDuree.Size = new System.Drawing.Size(55, 24);
            this.lblInfosDuree.TabIndex = 13;
            this.lblInfosDuree.Values.Text = "Durée";
            // 
            // ResultatEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(837, 560);
            this.Controls.Add(this.lblInfosDuree);
            this.Controls.Add(this.txtInfosDuree);
            this.Controls.Add(this.txtReponse);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblReponse);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblResultatEtudiant);
            this.Controls.Add(this.pictureBoxResultatEtudiant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstReponseIncorrecte);
            this.Controls.Add(this.lblReponseIncorrecte);
            this.Controls.Add(this.lblReponseCorrecte);
            this.Controls.Add(this.lstReponseCorrect);
            this.Name = "ResultatEvaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultat Evaluation";
            this.Load += new System.EventHandler(this.ResultatEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultatEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonListBox lstReponseCorrect;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReponseCorrecte;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReponseIncorrecte;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lstReponseIncorrecte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxResultatEtudiant;
        private System.Windows.Forms.Label lblResultatEtudiant;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblQuestion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReponse;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQuestion;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReponse;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtInfosDuree;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblInfosDuree;
    }
}
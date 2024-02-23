namespace ApplicationDidacticiel
{
    partial class AdministrationFormulaire
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
            this.listBoxAffichageQuestionImage = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.txtQuestion = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblQuestion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAjouter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSupprimer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSeDeconnecter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openBoiteDialogue = new System.Windows.Forms.OpenFileDialog();
            this.lblReponse1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReponse3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReponse4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReponse2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblBonneReponse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtReponse1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtReponse3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtReponse4 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtReponse2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBonneReponse = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSelectionnerImage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblmage = new System.Windows.Forms.Label();
            this.lblValidationReponse1 = new System.Windows.Forms.Label();
            this.lblValidationQuestion = new System.Windows.Forms.Label();
            this.lblValidationReponse4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblValidationReponse3 = new System.Windows.Forms.Label();
            this.lblValidationReponse2 = new System.Windows.Forms.Label();
            this.lblValidationBonneReponse = new System.Windows.Forms.Label();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAffichageQuestionImage
            // 
            this.listBoxAffichageQuestionImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxAffichageQuestionImage.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.listBoxAffichageQuestionImage.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.TabLowProfile;
            this.listBoxAffichageQuestionImage.Location = new System.Drawing.Point(17, 509);
            this.listBoxAffichageQuestionImage.Name = "listBoxAffichageQuestionImage";
            this.listBoxAffichageQuestionImage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.listBoxAffichageQuestionImage.Size = new System.Drawing.Size(382, 177);
            this.listBoxAffichageQuestionImage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.listBoxAffichageQuestionImage.StateCommon.Border.Rounding = 20;
            this.listBoxAffichageQuestionImage.TabIndex = 2;
            this.listBoxAffichageQuestionImage.SelectedIndexChanged += new System.EventHandler(this.listBoxAffichageQuestionImage_SelectedIndexChanged);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuestion.Location = new System.Drawing.Point(12, 215);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtQuestion.Size = new System.Drawing.Size(385, 156);
            this.txtQuestion.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQuestion.StateCommon.Border.Rounding = 10;
            this.txtQuestion.TabIndex = 3;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblQuestion.Location = new System.Drawing.Point(12, 185);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(85, 24);
            this.lblQuestion.TabIndex = 8;
            this.lblQuestion.Values.Text = "Question : ";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouter.Location = new System.Drawing.Point(809, 427);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btnAjouter.Size = new System.Drawing.Size(198, 50);
            this.btnAjouter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAjouter.StateCommon.Border.Rounding = 20;
            this.btnAjouter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Values.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSupprimer.Location = new System.Drawing.Point(809, 532);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btnSupprimer.Size = new System.Drawing.Size(198, 50);
            this.btnSupprimer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSupprimer.StateCommon.Border.Rounding = 20;
            this.btnSupprimer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Values.Text = "Supprimer ";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSeDeconnecter
            // 
            this.btnSeDeconnecter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeDeconnecter.Location = new System.Drawing.Point(809, 637);
            this.btnSeDeconnecter.Name = "btnSeDeconnecter";
            this.btnSeDeconnecter.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnSeDeconnecter.Size = new System.Drawing.Size(198, 50);
            this.btnSeDeconnecter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSeDeconnecter.StateCommon.Border.Rounding = 20;
            this.btnSeDeconnecter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeDeconnecter.TabIndex = 18;
            this.btnSeDeconnecter.Values.Text = "Se déconnecter";
            this.btnSeDeconnecter.Click += new System.EventHandler(this.btnSeDeconnecter_Click);
            // 
            // openBoiteDialogue
            // 
            this.openBoiteDialogue.Filter = "Jpeg, Png, Jpg| *.jpeg; *.png; *.jpg";
            this.openBoiteDialogue.InitialDirectory = "C:\\";
            // 
            // lblReponse1
            // 
            this.lblReponse1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReponse1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblReponse1.Location = new System.Drawing.Point(447, 185);
            this.lblReponse1.Name = "lblReponse1";
            this.lblReponse1.Size = new System.Drawing.Size(87, 24);
            this.lblReponse1.TabIndex = 9;
            this.lblReponse1.Values.Text = "Réponse 1";
            // 
            // lblReponse3
            // 
            this.lblReponse3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReponse3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblReponse3.Location = new System.Drawing.Point(447, 398);
            this.lblReponse3.Name = "lblReponse3";
            this.lblReponse3.Size = new System.Drawing.Size(87, 24);
            this.lblReponse3.TabIndex = 11;
            this.lblReponse3.Values.Text = "Réponse 3";
            // 
            // lblReponse4
            // 
            this.lblReponse4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReponse4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblReponse4.Location = new System.Drawing.Point(447, 503);
            this.lblReponse4.Name = "lblReponse4";
            this.lblReponse4.Size = new System.Drawing.Size(87, 24);
            this.lblReponse4.TabIndex = 12;
            this.lblReponse4.Values.Text = "Réponse 4";
            // 
            // lblReponse2
            // 
            this.lblReponse2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReponse2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblReponse2.Location = new System.Drawing.Point(447, 292);
            this.lblReponse2.Name = "lblReponse2";
            this.lblReponse2.Size = new System.Drawing.Size(87, 24);
            this.lblReponse2.TabIndex = 10;
            this.lblReponse2.Values.Text = "Réponse 2 ";
            // 
            // lblBonneReponse
            // 
            this.lblBonneReponse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBonneReponse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblBonneReponse.Location = new System.Drawing.Point(447, 607);
            this.lblBonneReponse.Name = "lblBonneReponse";
            this.lblBonneReponse.Size = new System.Drawing.Size(120, 24);
            this.lblBonneReponse.TabIndex = 14;
            this.lblBonneReponse.Values.Text = "Bonne réponse";
            // 
            // txtReponse1
            // 
            this.txtReponse1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReponse1.Location = new System.Drawing.Point(447, 215);
            this.txtReponse1.Multiline = true;
            this.txtReponse1.Name = "txtReponse1";
            this.txtReponse1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtReponse1.Size = new System.Drawing.Size(298, 49);
            this.txtReponse1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReponse1.StateCommon.Border.Rounding = 10;
            this.txtReponse1.TabIndex = 4;
            this.txtReponse1.TextChanged += new System.EventHandler(this.txtReponse1_TextChanged);
            // 
            // txtReponse3
            // 
            this.txtReponse3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReponse3.Location = new System.Drawing.Point(447, 428);
            this.txtReponse3.Multiline = true;
            this.txtReponse3.Name = "txtReponse3";
            this.txtReponse3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtReponse3.Size = new System.Drawing.Size(298, 49);
            this.txtReponse3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReponse3.StateCommon.Border.Rounding = 10;
            this.txtReponse3.TabIndex = 6;
            this.txtReponse3.TextChanged += new System.EventHandler(this.txtReponse3_TextChanged);
            // 
            // txtReponse4
            // 
            this.txtReponse4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReponse4.Location = new System.Drawing.Point(447, 533);
            this.txtReponse4.Multiline = true;
            this.txtReponse4.Name = "txtReponse4";
            this.txtReponse4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtReponse4.Size = new System.Drawing.Size(298, 49);
            this.txtReponse4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReponse4.StateCommon.Border.Rounding = 10;
            this.txtReponse4.TabIndex = 7;
            this.txtReponse4.TextChanged += new System.EventHandler(this.txtReponse4_TextChanged);
            // 
            // txtReponse2
            // 
            this.txtReponse2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReponse2.Location = new System.Drawing.Point(447, 322);
            this.txtReponse2.Multiline = true;
            this.txtReponse2.Name = "txtReponse2";
            this.txtReponse2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtReponse2.Size = new System.Drawing.Size(298, 49);
            this.txtReponse2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReponse2.StateCommon.Border.Rounding = 10;
            this.txtReponse2.TabIndex = 5;
            this.txtReponse2.TextChanged += new System.EventHandler(this.txtReponse2_TextChanged);
            // 
            // txtBonneReponse
            // 
            this.txtBonneReponse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBonneReponse.Location = new System.Drawing.Point(447, 637);
            this.txtBonneReponse.Multiline = true;
            this.txtBonneReponse.Name = "txtBonneReponse";
            this.txtBonneReponse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtBonneReponse.Size = new System.Drawing.Size(298, 49);
            this.txtBonneReponse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBonneReponse.StateCommon.Border.Rounding = 10;
            this.txtBonneReponse.TabIndex = 15;
            this.txtBonneReponse.TextChanged += new System.EventHandler(this.txtBonneReponse_TextChanged);
            // 
            // btnSelectionnerImage
            // 
            this.btnSelectionnerImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectionnerImage.Location = new System.Drawing.Point(17, 428);
            this.btnSelectionnerImage.Name = "btnSelectionnerImage";
            this.btnSelectionnerImage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.btnSelectionnerImage.Size = new System.Drawing.Size(184, 49);
            this.btnSelectionnerImage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSelectionnerImage.StateCommon.Border.Rounding = 10;
            this.btnSelectionnerImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionnerImage.StateCommon.Content.ShortText.Image = global::ApplicationDidacticiel.Properties.Resources.image;
            this.btnSelectionnerImage.TabIndex = 32;
            this.btnSelectionnerImage.Values.Image = global::ApplicationDidacticiel.Properties.Resources.image;
            this.btnSelectionnerImage.Values.Text = "Image";
            this.btnSelectionnerImage.Click += new System.EventHandler(this.btnSelectionnerImage_Click);
            // 
            // lblmage
            // 
            this.lblmage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblmage.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblmage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblmage.Location = new System.Drawing.Point(9, 480);
            this.lblmage.Name = "lblmage";
            this.lblmage.Size = new System.Drawing.Size(197, 21);
            this.lblmage.TabIndex = 33;
            this.lblmage.Text = "Sélectionnez une image.";
            this.lblmage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblmage.Click += new System.EventHandler(this.lblmage_Click);
            // 
            // lblValidationReponse1
            // 
            this.lblValidationReponse1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationReponse1.BackColor = System.Drawing.Color.Transparent;
            this.lblValidationReponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationReponse1.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationReponse1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationReponse1.Location = new System.Drawing.Point(444, 267);
            this.lblValidationReponse1.Name = "lblValidationReponse1";
            this.lblValidationReponse1.Size = new System.Drawing.Size(192, 17);
            this.lblValidationReponse1.TabIndex = 22;
            this.lblValidationReponse1.Text = "Indiquez votre réponse.";
            this.lblValidationReponse1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidationReponse1.Click += new System.EventHandler(this.lblValidationReponse1_Click);
            // 
            // lblValidationQuestion
            // 
            this.lblValidationQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationQuestion.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationQuestion.Location = new System.Drawing.Point(9, 375);
            this.lblValidationQuestion.Name = "lblValidationQuestion";
            this.lblValidationQuestion.Size = new System.Drawing.Size(192, 26);
            this.lblValidationQuestion.TabIndex = 27;
            this.lblValidationQuestion.Text = "Indiquez votre question.";
            this.lblValidationQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidationQuestion.Click += new System.EventHandler(this.lblValidationQuestion_Click);
            // 
            // lblValidationReponse4
            // 
            this.lblValidationReponse4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationReponse4.BackColor = System.Drawing.Color.Transparent;
            this.lblValidationReponse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationReponse4.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationReponse4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationReponse4.Location = new System.Drawing.Point(444, 585);
            this.lblValidationReponse4.Name = "lblValidationReponse4";
            this.lblValidationReponse4.Size = new System.Drawing.Size(192, 19);
            this.lblValidationReponse4.TabIndex = 25;
            this.lblValidationReponse4.Text = "Indiquez votre réponse.";
            this.lblValidationReponse4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidationReponse4.Click += new System.EventHandler(this.lblValidationReponse4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ApplicationDidacticiel.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(809, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblValidationReponse3
            // 
            this.lblValidationReponse3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationReponse3.BackColor = System.Drawing.Color.Transparent;
            this.lblValidationReponse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationReponse3.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationReponse3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationReponse3.Location = new System.Drawing.Point(444, 480);
            this.lblValidationReponse3.Name = "lblValidationReponse3";
            this.lblValidationReponse3.Size = new System.Drawing.Size(192, 20);
            this.lblValidationReponse3.TabIndex = 24;
            this.lblValidationReponse3.Text = "Indiquez votre réponse.";
            this.lblValidationReponse3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidationReponse3.Click += new System.EventHandler(this.lblValidationReponse3_Click);
            // 
            // lblValidationReponse2
            // 
            this.lblValidationReponse2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationReponse2.BackColor = System.Drawing.Color.Transparent;
            this.lblValidationReponse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationReponse2.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationReponse2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationReponse2.Location = new System.Drawing.Point(444, 375);
            this.lblValidationReponse2.Name = "lblValidationReponse2";
            this.lblValidationReponse2.Size = new System.Drawing.Size(192, 20);
            this.lblValidationReponse2.TabIndex = 23;
            this.lblValidationReponse2.Text = "Indiquez votre réponse.";
            this.lblValidationReponse2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidationReponse2.Click += new System.EventHandler(this.lblValidationReponse2_Click);
            // 
            // lblValidationBonneReponse
            // 
            this.lblValidationBonneReponse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationBonneReponse.BackColor = System.Drawing.Color.Transparent;
            this.lblValidationBonneReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationBonneReponse.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationBonneReponse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationBonneReponse.Location = new System.Drawing.Point(444, 689);
            this.lblValidationBonneReponse.Name = "lblValidationBonneReponse";
            this.lblValidationBonneReponse.Size = new System.Drawing.Size(365, 24);
            this.lblValidationBonneReponse.TabIndex = 34;
            this.lblValidationBonneReponse.Text = "      Doit correspondre à une seule réponse.";
            this.lblValidationBonneReponse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationBonneReponse.Click += new System.EventHandler(this.lblValidationBonneReponse_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(17, 35);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(728, 106);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 35;
            this.kryptonLabel2.Values.Image = global::ApplicationDidacticiel.Properties.Resources.question1;
            this.kryptonLabel2.Values.Text = "Création du questionnaire";
            // 
            // AdministrationFormulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1032, 743);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.lblValidationBonneReponse);
            this.Controls.Add(this.lblmage);
            this.Controls.Add(this.btnSelectionnerImage);
            this.Controls.Add(this.txtBonneReponse);
            this.Controls.Add(this.lblValidationReponse1);
            this.Controls.Add(this.lblValidationQuestion);
            this.Controls.Add(this.lblValidationReponse4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBonneReponse);
            this.Controls.Add(this.btnSeDeconnecter);
            this.Controls.Add(this.lblReponse2);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.lblValidationReponse3);
            this.Controls.Add(this.txtReponse2);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtReponse4);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblReponse4);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblValidationReponse2);
            this.Controls.Add(this.listBoxAffichageQuestionImage);
            this.Controls.Add(this.lblReponse3);
            this.Controls.Add(this.txtReponse1);
            this.Controls.Add(this.txtReponse3);
            this.Controls.Add(this.lblReponse1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministrationFormulaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration questionnaire";
            this.Load += new System.EventHandler(this.AdministrationFormulaire_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonListBox listBoxAffichageQuestionImage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQuestion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblQuestion;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAjouter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSupprimer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSeDeconnecter;
        private System.Windows.Forms.OpenFileDialog openBoiteDialogue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblValidationQuestion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReponse1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReponse3;
        private System.Windows.Forms.Label lblValidationReponse2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReponse4;
        private System.Windows.Forms.Label lblValidationReponse3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReponse2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBonneReponse;
        private System.Windows.Forms.Label lblValidationReponse4;
        private System.Windows.Forms.Label lblValidationReponse1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReponse1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReponse3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReponse4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReponse2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBonneReponse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSelectionnerImage;
        private System.Windows.Forms.Label lblmage;
        private System.Windows.Forms.Label lblValidationBonneReponse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}
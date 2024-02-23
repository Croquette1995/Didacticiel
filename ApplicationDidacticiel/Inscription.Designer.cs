namespace ApplicationDidacticiel
{
    partial class Inscription
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
            this.lblNom = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPrenom = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblLogin = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblMotDePasse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblConfirmerMotDePasse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtNom = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPrenom = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMotDePasse = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtLogin = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtConfirmerMotDePasse = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnInscription = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblMeConnecter = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lblInscrit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblChampsObligatoire = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.checkBoxAfficherMotDePasse = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxAfficherConfirmerMotDePasse = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cmbBoxStatut = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblValidationNom = new System.Windows.Forms.Label();
            this.lblValidationPrenom = new System.Windows.Forms.Label();
            this.lblValidationLogin = new System.Windows.Forms.Label();
            this.lblValidationMotDePasse = new System.Windows.Forms.Label();
            this.lblValidationConfirmerMotDePasse = new System.Windows.Forms.Label();
            this.lblValidationStatut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxStatut)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNom.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblNom.Location = new System.Drawing.Point(35, 71);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(72, 24);
            this.lblNom.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.TabIndex = 0;
            this.lblNom.Values.Text = "Nom : *";
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrenom.Location = new System.Drawing.Point(35, 162);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(97, 24);
            this.lblPrenom.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Values.Text = "Prénom : *";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.Location = new System.Drawing.Point(35, 252);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(79, 24);
            this.lblLogin.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Values.Text = "Login : *";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMotDePasse.Location = new System.Drawing.Point(35, 344);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(142, 24);
            this.lblMotDePasse.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotDePasse.TabIndex = 3;
            this.lblMotDePasse.Values.Text = "Mot de passe : *";
            // 
            // lblConfirmerMotDePasse
            // 
            this.lblConfirmerMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmerMotDePasse.Location = new System.Drawing.Point(35, 459);
            this.lblConfirmerMotDePasse.Name = "lblConfirmerMotDePasse";
            this.lblConfirmerMotDePasse.Size = new System.Drawing.Size(275, 24);
            this.lblConfirmerMotDePasse.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmerMotDePasse.TabIndex = 4;
            this.lblConfirmerMotDePasse.Values.Text = "Confirmation du mot de passe : *";
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNom.Location = new System.Drawing.Point(35, 101);
            this.txtNom.Name = "txtNom";
            this.txtNom.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtNom.Size = new System.Drawing.Size(275, 31);
            this.txtNom.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNom.StateCommon.Border.Rounding = 5;
            this.txtNom.TabIndex = 5;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrenom.Location = new System.Drawing.Point(35, 192);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtPrenom.Size = new System.Drawing.Size(275, 31);
            this.txtPrenom.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrenom.StateCommon.Border.Rounding = 5;
            this.txtPrenom.TabIndex = 6;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrenom_KeyPress);
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMotDePasse.Location = new System.Drawing.Point(35, 374);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtMotDePasse.Size = new System.Drawing.Size(275, 31);
            this.txtMotDePasse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMotDePasse.StateCommon.Border.Rounding = 5;
            this.txtMotDePasse.TabIndex = 7;
            this.txtMotDePasse.TextChanged += new System.EventHandler(this.txtMotDePasse_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Location = new System.Drawing.Point(35, 282);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtLogin.Size = new System.Drawing.Size(275, 31);
            this.txtLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLogin.StateCommon.Border.Rounding = 5;
            this.txtLogin.TabIndex = 8;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // txtConfirmerMotDePasse
            // 
            this.txtConfirmerMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmerMotDePasse.Location = new System.Drawing.Point(35, 489);
            this.txtConfirmerMotDePasse.Name = "txtConfirmerMotDePasse";
            this.txtConfirmerMotDePasse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtConfirmerMotDePasse.Size = new System.Drawing.Size(275, 31);
            this.txtConfirmerMotDePasse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtConfirmerMotDePasse.StateCommon.Border.Rounding = 5;
            this.txtConfirmerMotDePasse.TabIndex = 9;
            this.txtConfirmerMotDePasse.TextChanged += new System.EventHandler(this.txtConfirmerMotDePasse_TextChanged);
            // 
            // btnInscription
            // 
            this.btnInscription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInscription.Location = new System.Drawing.Point(451, 440);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btnInscription.Size = new System.Drawing.Size(294, 50);
            this.btnInscription.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnInscription.StateCommon.Border.Rounding = 20;
            this.btnInscription.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscription.TabIndex = 16;
            this.btnInscription.Values.Text = "Je m\'inscris";
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // lblMeConnecter
            // 
            this.lblMeConnecter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMeConnecter.Location = new System.Drawing.Point(598, 496);
            this.lblMeConnecter.Name = "lblMeConnecter";
            this.lblMeConnecter.Size = new System.Drawing.Size(105, 24);
            this.lblMeConnecter.TabIndex = 17;
            this.lblMeConnecter.Values.Text = "Me connecter";
            this.lblMeConnecter.LinkClicked += new System.EventHandler(this.lblMeConnecter_LinkClicked);
            // 
            // lblInscrit
            // 
            this.lblInscrit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInscrit.Location = new System.Drawing.Point(494, 496);
            this.lblInscrit.Name = "lblInscrit";
            this.lblInscrit.Size = new System.Drawing.Size(98, 24);
            this.lblInscrit.TabIndex = 18;
            this.lblInscrit.Values.Text = "Déjà inscrit ? ";
            // 
            // lblChampsObligatoire
            // 
            this.lblChampsObligatoire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChampsObligatoire.Location = new System.Drawing.Point(35, 41);
            this.lblChampsObligatoire.Name = "lblChampsObligatoire";
            this.lblChampsObligatoire.Size = new System.Drawing.Size(162, 24);
            this.lblChampsObligatoire.TabIndex = 19;
            this.lblChampsObligatoire.Values.Text = "* Champs obligatoires";
            // 
            // checkBoxAfficherMotDePasse
            // 
            this.checkBoxAfficherMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxAfficherMotDePasse.AutoSize = false;
            this.checkBoxAfficherMotDePasse.Checked = true;
            this.checkBoxAfficherMotDePasse.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top;
            this.checkBoxAfficherMotDePasse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAfficherMotDePasse.Images.CheckedNormal = global::ApplicationDidacticiel.Properties.Resources.eye_;
            this.checkBoxAfficherMotDePasse.Images.CheckedPressed = global::ApplicationDidacticiel.Properties.Resources.eye_;
            this.checkBoxAfficherMotDePasse.Images.CheckedTracking = global::ApplicationDidacticiel.Properties.Resources.eye_;
            this.checkBoxAfficherMotDePasse.Images.UncheckedNormal = global::ApplicationDidacticiel.Properties.Resources.eye_off;
            this.checkBoxAfficherMotDePasse.Images.UncheckedPressed = global::ApplicationDidacticiel.Properties.Resources.eye_off;
            this.checkBoxAfficherMotDePasse.Images.UncheckedTracking = global::ApplicationDidacticiel.Properties.Resources.eye_off;
            this.checkBoxAfficherMotDePasse.Location = new System.Drawing.Point(280, 380);
            this.checkBoxAfficherMotDePasse.Name = "checkBoxAfficherMotDePasse";
            this.checkBoxAfficherMotDePasse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.checkBoxAfficherMotDePasse.Size = new System.Drawing.Size(20, 20);
            this.checkBoxAfficherMotDePasse.TabIndex = 25;
            this.checkBoxAfficherMotDePasse.Values.Text = "";
            this.checkBoxAfficherMotDePasse.CheckedChanged += new System.EventHandler(this.checkBoxAfficherMotDePasse_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ApplicationDidacticiel.Properties.Resources.formulaire_d_inscription;
            this.pictureBox1.Location = new System.Drawing.Point(451, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxAfficherConfirmerMotDePasse
            // 
            this.checkBoxAfficherConfirmerMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxAfficherConfirmerMotDePasse.AutoSize = false;
            this.checkBoxAfficherConfirmerMotDePasse.Checked = true;
            this.checkBoxAfficherConfirmerMotDePasse.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top;
            this.checkBoxAfficherConfirmerMotDePasse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAfficherConfirmerMotDePasse.Images.CheckedNormal = global::ApplicationDidacticiel.Properties.Resources.eye_;
            this.checkBoxAfficherConfirmerMotDePasse.Images.CheckedPressed = global::ApplicationDidacticiel.Properties.Resources.eye_;
            this.checkBoxAfficherConfirmerMotDePasse.Images.CheckedTracking = global::ApplicationDidacticiel.Properties.Resources.eye_;
            this.checkBoxAfficherConfirmerMotDePasse.Images.UncheckedNormal = global::ApplicationDidacticiel.Properties.Resources.eye_off;
            this.checkBoxAfficherConfirmerMotDePasse.Images.UncheckedPressed = global::ApplicationDidacticiel.Properties.Resources.eye_off;
            this.checkBoxAfficherConfirmerMotDePasse.Images.UncheckedTracking = global::ApplicationDidacticiel.Properties.Resources.eye_off;
            this.checkBoxAfficherConfirmerMotDePasse.Location = new System.Drawing.Point(280, 495);
            this.checkBoxAfficherConfirmerMotDePasse.Name = "checkBoxAfficherConfirmerMotDePasse";
            this.checkBoxAfficherConfirmerMotDePasse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.checkBoxAfficherConfirmerMotDePasse.Size = new System.Drawing.Size(20, 20);
            this.checkBoxAfficherConfirmerMotDePasse.TabIndex = 26;
            this.checkBoxAfficherConfirmerMotDePasse.Values.Text = "";
            this.checkBoxAfficherConfirmerMotDePasse.CheckedChanged += new System.EventHandler(this.checkBoxAfficherConfirmerMotDePasse_CheckedChanged);
            // 
            // cmbBoxStatut
            // 
            this.cmbBoxStatut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxStatut.DropDownWidth = 121;
            this.cmbBoxStatut.Items.AddRange(new object[] {
            "Etudiant",
            "Professeur"});
            this.cmbBoxStatut.Location = new System.Drawing.Point(461, 380);
            this.cmbBoxStatut.Name = "cmbBoxStatut";
            this.cmbBoxStatut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.cmbBoxStatut.Size = new System.Drawing.Size(149, 25);
            this.cmbBoxStatut.TabIndex = 31;
            this.cmbBoxStatut.SelectedIndexChanged += new System.EventHandler(this.cmbBoxStatut_SelectedIndexChanged);
            // 
            // lblValidationNom
            // 
            this.lblValidationNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationNom.AutoSize = true;
            this.lblValidationNom.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationNom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationNom.Location = new System.Drawing.Point(32, 135);
            this.lblValidationNom.Name = "lblValidationNom";
            this.lblValidationNom.Size = new System.Drawing.Size(140, 16);
            this.lblValidationNom.TabIndex = 32;
            this.lblValidationNom.Text = "      Indiquez votre nom.";
            this.lblValidationNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidationNom.Click += new System.EventHandler(this.lblValidationNom_Click);
            // 
            // lblValidationPrenom
            // 
            this.lblValidationPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationPrenom.AutoSize = true;
            this.lblValidationPrenom.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationPrenom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationPrenom.Location = new System.Drawing.Point(32, 225);
            this.lblValidationPrenom.Name = "lblValidationPrenom";
            this.lblValidationPrenom.Size = new System.Drawing.Size(160, 16);
            this.lblValidationPrenom.TabIndex = 33;
            this.lblValidationPrenom.Text = "      Indiquez votre prénom.";
            this.lblValidationPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidationPrenom.Click += new System.EventHandler(this.lblValidationPrenom_Click);
            // 
            // lblValidationLogin
            // 
            this.lblValidationLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationLogin.AutoSize = true;
            this.lblValidationLogin.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationLogin.Location = new System.Drawing.Point(32, 316);
            this.lblValidationLogin.Name = "lblValidationLogin";
            this.lblValidationLogin.Size = new System.Drawing.Size(142, 16);
            this.lblValidationLogin.TabIndex = 34;
            this.lblValidationLogin.Text = "      Choisissez un login.";
            this.lblValidationLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidationLogin.Click += new System.EventHandler(this.lblValidationLogin_Click);
            // 
            // lblValidationMotDePasse
            // 
            this.lblValidationMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationMotDePasse.AutoSize = true;
            this.lblValidationMotDePasse.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationMotDePasse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationMotDePasse.Location = new System.Drawing.Point(32, 408);
            this.lblValidationMotDePasse.Name = "lblValidationMotDePasse";
            this.lblValidationMotDePasse.Size = new System.Drawing.Size(195, 16);
            this.lblValidationMotDePasse.TabIndex = 35;
            this.lblValidationMotDePasse.Text = "      Choisissez un mot de passe.";
            this.lblValidationMotDePasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationMotDePasse.Click += new System.EventHandler(this.lblValidationMotDePasse_Click);
            // 
            // lblValidationConfirmerMotDePasse
            // 
            this.lblValidationConfirmerMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationConfirmerMotDePasse.AutoSize = true;
            this.lblValidationConfirmerMotDePasse.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationConfirmerMotDePasse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationConfirmerMotDePasse.Location = new System.Drawing.Point(30, 523);
            this.lblValidationConfirmerMotDePasse.Name = "lblValidationConfirmerMotDePasse";
            this.lblValidationConfirmerMotDePasse.Size = new System.Drawing.Size(273, 16);
            this.lblValidationConfirmerMotDePasse.TabIndex = 36;
            this.lblValidationConfirmerMotDePasse.Text = "      Les mots de passe doivent correspondre.";
            this.lblValidationConfirmerMotDePasse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidationConfirmerMotDePasse.Click += new System.EventHandler(this.lblValidationConfirmerMotDePasse_Click);
            // 
            // lblValidationStatut
            // 
            this.lblValidationStatut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidationStatut.AutoSize = true;
            this.lblValidationStatut.Image = global::ApplicationDidacticiel.Properties.Resources.warning_circle_light;
            this.lblValidationStatut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidationStatut.Location = new System.Drawing.Point(458, 408);
            this.lblValidationStatut.Name = "lblValidationStatut";
            this.lblValidationStatut.Size = new System.Drawing.Size(144, 16);
            this.lblValidationStatut.TabIndex = 37;
            this.lblValidationStatut.Text = "      Choisissez un statut.";
            this.lblValidationStatut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValidationStatut.Click += new System.EventHandler(this.lblValidationStatut_Click);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.lblValidationStatut);
            this.Controls.Add(this.lblValidationConfirmerMotDePasse);
            this.Controls.Add(this.lblValidationMotDePasse);
            this.Controls.Add(this.lblValidationLogin);
            this.Controls.Add(this.lblValidationPrenom);
            this.Controls.Add(this.lblValidationNom);
            this.Controls.Add(this.cmbBoxStatut);
            this.Controls.Add(this.checkBoxAfficherConfirmerMotDePasse);
            this.Controls.Add(this.checkBoxAfficherMotDePasse);
            this.Controls.Add(this.lblChampsObligatoire);
            this.Controls.Add(this.lblInscrit);
            this.Controls.Add(this.lblMeConnecter);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtConfirmerMotDePasse);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblConfirmerMotDePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "Inscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxStatut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNom;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPrenom;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMotDePasse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblConfirmerMotDePasse;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNom;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrenom;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMotDePasse;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtConfirmerMotDePasse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInscription;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lblMeConnecter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblInscrit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblChampsObligatoire;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox checkBoxAfficherMotDePasse;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox checkBoxAfficherConfirmerMotDePasse;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbBoxStatut;
        private System.Windows.Forms.Label lblValidationNom;
        private System.Windows.Forms.Label lblValidationPrenom;
        private System.Windows.Forms.Label lblValidationLogin;
        private System.Windows.Forms.Label lblValidationMotDePasse;
        private System.Windows.Forms.Label lblValidationConfirmerMotDePasse;
        private System.Windows.Forms.Label lblValidationStatut;
    }
}
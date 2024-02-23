namespace ApplicationDidacticiel
{
    partial class Accueil
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
            this.txtLogin = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMotDePasse = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblLogin = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblMotDePasse = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSeConnecter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInscrire = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.checkBoxAfficherMotDePasse = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.lblBienvenue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSeConnecter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Location = new System.Drawing.Point(95, 264);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtLogin.Size = new System.Drawing.Size(200, 33);
            this.txtLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLogin.StateCommon.Border.Rounding = 10;
            this.txtLogin.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLogin.StateNormal.Border.Rounding = 10;
            this.txtLogin.TabIndex = 0;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMotDePasse.Location = new System.Drawing.Point(95, 333);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txtMotDePasse.Size = new System.Drawing.Size(200, 33);
            this.txtMotDePasse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMotDePasse.StateCommon.Border.Rounding = 10;
            this.txtMotDePasse.TabIndex = 5;
            this.txtMotDePasse.TextChanged += new System.EventHandler(this.txtMotDePasse_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblLogin.Location = new System.Drawing.Point(95, 237);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(52, 24);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Values.Text = "Login";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMotDePasse.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblMotDePasse.Location = new System.Drawing.Point(95, 303);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(108, 24);
            this.lblMotDePasse.TabIndex = 7;
            this.lblMotDePasse.Values.Text = "Mot de passe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ApplicationDidacticiel.Properties.Resources.bienvenue;
            this.pictureBox1.Location = new System.Drawing.Point(133, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 118);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeConnecter.Location = new System.Drawing.Point(95, 403);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btnSeConnecter.Size = new System.Drawing.Size(200, 41);
            this.btnSeConnecter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSeConnecter.StateCommon.Border.Rounding = 20;
            this.btnSeConnecter.TabIndex = 13;
            this.btnSeConnecter.Values.Text = "Se connecter";
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // btnInscrire
            // 
            this.btnInscrire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInscrire.Location = new System.Drawing.Point(95, 465);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnInscrire.Size = new System.Drawing.Size(200, 41);
            this.btnInscrire.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnInscrire.StateCommon.Border.Rounding = 20;
            this.btnInscrire.TabIndex = 14;
            this.btnInscrire.Values.Text = "S\'inscrire";
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // checkBoxAfficherMotDePasse
            // 
            this.checkBoxAfficherMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxAfficherMotDePasse.AutoSize = false;
            this.checkBoxAfficherMotDePasse.Checked = true;
            this.checkBoxAfficherMotDePasse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAfficherMotDePasse.Images.CheckedNormal = global::ApplicationDidacticiel.Properties.Resources.eye_;
            this.checkBoxAfficherMotDePasse.Images.CheckedPressed = global::ApplicationDidacticiel.Properties.Resources.eye_;
            this.checkBoxAfficherMotDePasse.Images.CheckedTracking = global::ApplicationDidacticiel.Properties.Resources.eye_;
            this.checkBoxAfficherMotDePasse.Images.UncheckedNormal = global::ApplicationDidacticiel.Properties.Resources.eye_off;
            this.checkBoxAfficherMotDePasse.Images.UncheckedPressed = global::ApplicationDidacticiel.Properties.Resources.eye_off;
            this.checkBoxAfficherMotDePasse.Images.UncheckedTracking = global::ApplicationDidacticiel.Properties.Resources.eye_off;
            this.checkBoxAfficherMotDePasse.Location = new System.Drawing.Point(269, 337);
            this.checkBoxAfficherMotDePasse.Name = "checkBoxAfficherMotDePasse";
            this.checkBoxAfficherMotDePasse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.checkBoxAfficherMotDePasse.Size = new System.Drawing.Size(15, 19);
            this.checkBoxAfficherMotDePasse.TabIndex = 15;
            this.checkBoxAfficherMotDePasse.Values.Text = "";
            this.checkBoxAfficherMotDePasse.CheckedChanged += new System.EventHandler(this.checkBoxAfficherMotDePasse_CheckedChanged);
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenue.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBienvenue.Location = new System.Drawing.Point(133, 164);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.lblBienvenue.Size = new System.Drawing.Size(161, 54);
            this.lblBienvenue.StateNormal.ShortText.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.TabIndex = 16;
            this.lblBienvenue.Values.Text = "Bienvenue !";
            // 
            // lblSeConnecter
            // 
            this.lblSeConnecter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeConnecter.Location = new System.Drawing.Point(95, 364);
            this.lblSeConnecter.Name = "lblSeConnecter";
            this.lblSeConnecter.Size = new System.Drawing.Size(6, 2);
            this.lblSeConnecter.TabIndex = 18;
            this.lblSeConnecter.Values.Text = "";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.lblSeConnecter);
            this.Controls.Add(this.lblBienvenue);
            this.Controls.Add(this.checkBoxAfficherMotDePasse);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtMotDePasse);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Accueil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMotDePasse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMotDePasse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSeConnecter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInscrire;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox checkBoxAfficherMotDePasse;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBienvenue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSeConnecter;
    }
}


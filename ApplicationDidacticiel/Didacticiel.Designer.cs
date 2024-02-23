namespace ApplicationDidacticiel
{
    partial class Didacticiel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Didacticiel));
            this.btnValider = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tsDidactiel = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.groupBoxQuestionReponse = new System.Windows.Forms.GroupBox();
            this.radbtnReponse4 = new System.Windows.Forms.RadioButton();
            this.radbtnReponse3 = new System.Windows.Forms.RadioButton();
            this.radbtnReponse2 = new System.Windows.Forms.RadioButton();
            this.radbtnReponse1 = new System.Windows.Forms.RadioButton();
            this.btnFirstQuestion = new System.Windows.Forms.ToolStripButton();
            this.btnPreviousQuestion = new System.Windows.Forms.ToolStripButton();
            this.btnNextQuestion = new System.Windows.Forms.ToolStripButton();
            this.btnLastQuestion = new System.Windows.Forms.ToolStripButton();
            this.btnPlayDidacticiel = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnResult = new System.Windows.Forms.ToolStripButton();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxImageDidacticiel = new System.Windows.Forms.PictureBox();
            this.tsDidactiel.SuspendLayout();
            this.groupBoxQuestionReponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageDidacticiel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnValider.Location = new System.Drawing.Point(52, 517);
            this.btnValider.Name = "btnValider";
            this.btnValider.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnValider.Size = new System.Drawing.Size(221, 55);
            this.btnValider.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnValider.StateCommon.Border.Rounding = 10;
            this.btnValider.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.TabIndex = 2;
            this.btnValider.Values.Text = "Valider";
            this.btnValider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // tsDidactiel
            // 
            this.tsDidactiel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsDidactiel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsDidactiel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirstQuestion,
            this.btnPreviousQuestion,
            this.btnNextQuestion,
            this.btnLastQuestion,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.btnPlayDidacticiel,
            this.btnReload,
            this.btnResult,
            this.btnLogout});
            this.tsDidactiel.Location = new System.Drawing.Point(0, 0);
            this.tsDidactiel.Name = "tsDidactiel";
            this.tsDidactiel.Size = new System.Drawing.Size(1026, 31);
            this.tsDidactiel.TabIndex = 4;
            this.tsDidactiel.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(52, 85);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(179, 66);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Image = global::ApplicationDidacticiel.Properties.Resources.information;
            this.kryptonLabel1.Values.Text = "Consignes";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(355, 57);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(659, 223);
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = resources.GetString("kryptonLabel2.Values.Text");
            // 
            // groupBoxQuestionReponse
            // 
            this.groupBoxQuestionReponse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxQuestionReponse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxQuestionReponse.Controls.Add(this.radbtnReponse4);
            this.groupBoxQuestionReponse.Controls.Add(this.radbtnReponse3);
            this.groupBoxQuestionReponse.Controls.Add(this.radbtnReponse2);
            this.groupBoxQuestionReponse.Controls.Add(this.radbtnReponse1);
            this.groupBoxQuestionReponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxQuestionReponse.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQuestionReponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxQuestionReponse.Location = new System.Drawing.Point(355, 286);
            this.groupBoxQuestionReponse.Name = "groupBoxQuestionReponse";
            this.groupBoxQuestionReponse.Size = new System.Drawing.Size(621, 286);
            this.groupBoxQuestionReponse.TabIndex = 8;
            this.groupBoxQuestionReponse.TabStop = false;
            this.groupBoxQuestionReponse.Text = "Question";
            // 
            // radbtnReponse4
            // 
            this.radbtnReponse4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radbtnReponse4.AutoSize = true;
            this.radbtnReponse4.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnReponse4.Location = new System.Drawing.Point(36, 184);
            this.radbtnReponse4.Name = "radbtnReponse4";
            this.radbtnReponse4.Size = new System.Drawing.Size(129, 26);
            this.radbtnReponse4.TabIndex = 3;
            this.radbtnReponse4.TabStop = true;
            this.radbtnReponse4.Text = "radioButton4";
            this.radbtnReponse4.UseVisualStyleBackColor = true;
            // 
            // radbtnReponse3
            // 
            this.radbtnReponse3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radbtnReponse3.AutoSize = true;
            this.radbtnReponse3.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnReponse3.Location = new System.Drawing.Point(36, 235);
            this.radbtnReponse3.Name = "radbtnReponse3";
            this.radbtnReponse3.Size = new System.Drawing.Size(129, 26);
            this.radbtnReponse3.TabIndex = 2;
            this.radbtnReponse3.TabStop = true;
            this.radbtnReponse3.Text = "radioButton3";
            this.radbtnReponse3.UseVisualStyleBackColor = true;
            // 
            // radbtnReponse2
            // 
            this.radbtnReponse2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radbtnReponse2.AutoSize = true;
            this.radbtnReponse2.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnReponse2.Location = new System.Drawing.Point(36, 133);
            this.radbtnReponse2.Name = "radbtnReponse2";
            this.radbtnReponse2.Size = new System.Drawing.Size(129, 26);
            this.radbtnReponse2.TabIndex = 1;
            this.radbtnReponse2.TabStop = true;
            this.radbtnReponse2.Text = "radioButton2";
            this.radbtnReponse2.UseVisualStyleBackColor = true;
            // 
            // radbtnReponse1
            // 
            this.radbtnReponse1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radbtnReponse1.AutoSize = true;
            this.radbtnReponse1.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnReponse1.Location = new System.Drawing.Point(36, 81);
            this.radbtnReponse1.Name = "radbtnReponse1";
            this.radbtnReponse1.Size = new System.Drawing.Size(129, 26);
            this.radbtnReponse1.TabIndex = 0;
            this.radbtnReponse1.TabStop = true;
            this.radbtnReponse1.Text = "radioButton1";
            this.radbtnReponse1.UseVisualStyleBackColor = true;
            // 
            // btnFirstQuestion
            // 
            this.btnFirstQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirstQuestion.Image = global::ApplicationDidacticiel.Properties.Resources.first;
            this.btnFirstQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirstQuestion.Name = "btnFirstQuestion";
            this.btnFirstQuestion.Size = new System.Drawing.Size(29, 28);
            this.btnFirstQuestion.Text = "toolStripButton2";
            this.btnFirstQuestion.Click += new System.EventHandler(this.btnFirstQuestion_Click);
            // 
            // btnPreviousQuestion
            // 
            this.btnPreviousQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviousQuestion.Image = global::ApplicationDidacticiel.Properties.Resources.left;
            this.btnPreviousQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviousQuestion.Name = "btnPreviousQuestion";
            this.btnPreviousQuestion.Size = new System.Drawing.Size(29, 28);
            this.btnPreviousQuestion.Text = "toolStripButton2";
            this.btnPreviousQuestion.Click += new System.EventHandler(this.btnPreviousQuestion_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextQuestion.Image = global::ApplicationDidacticiel.Properties.Resources.right;
            this.btnNextQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(29, 28);
            this.btnNextQuestion.Text = "toolStripButton3";
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnLastQuestion
            // 
            this.btnLastQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLastQuestion.Image = global::ApplicationDidacticiel.Properties.Resources.last;
            this.btnLastQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLastQuestion.Name = "btnLastQuestion";
            this.btnLastQuestion.Size = new System.Drawing.Size(29, 28);
            this.btnLastQuestion.Text = "toolStripButton3";
            this.btnLastQuestion.Click += new System.EventHandler(this.btnLastQuestion_Click);
            // 
            // btnPlayDidacticiel
            // 
            this.btnPlayDidacticiel.Image = global::ApplicationDidacticiel.Properties.Resources.play;
            this.btnPlayDidacticiel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlayDidacticiel.Name = "btnPlayDidacticiel";
            this.btnPlayDidacticiel.Size = new System.Drawing.Size(60, 28);
            this.btnPlayDidacticiel.Text = "Play";
            this.btnPlayDidacticiel.Click += new System.EventHandler(this.btnPlayDidacticiel_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = global::ApplicationDidacticiel.Properties.Resources.reload;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(80, 28);
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnResult
            // 
            this.btnResult.Image = global::ApplicationDidacticiel.Properties.Resources.fichierResultat;
            this.btnResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(73, 28);
            this.btnResult.Text = "Result";
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::ApplicationDidacticiel.Properties.Resources.logout;
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 28);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBoxImageDidacticiel
            // 
            this.pictureBoxImageDidacticiel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxImageDidacticiel.Location = new System.Drawing.Point(52, 286);
            this.pictureBoxImageDidacticiel.Name = "pictureBoxImageDidacticiel";
            this.pictureBoxImageDidacticiel.Size = new System.Drawing.Size(221, 186);
            this.pictureBoxImageDidacticiel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageDidacticiel.TabIndex = 3;
            this.pictureBoxImageDidacticiel.TabStop = false;
            this.pictureBoxImageDidacticiel.Click += new System.EventHandler(this.pictureBoxImageDidacticiel_Click);
            // 
            // Didacticiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1026, 606);
            this.Controls.Add(this.groupBoxQuestionReponse);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tsDidactiel);
            this.Controls.Add(this.pictureBoxImageDidacticiel);
            this.Name = "Didacticiel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Didacticiel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Didacticiel_FormClosing);
            this.Load += new System.EventHandler(this.Didacticiel_Load);
            this.tsDidactiel.ResumeLayout(false);
            this.tsDidactiel.PerformLayout();
            this.groupBoxQuestionReponse.ResumeLayout(false);
            this.groupBoxQuestionReponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageDidacticiel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnValider;
        private System.Windows.Forms.PictureBox pictureBoxImageDidacticiel;
        private System.Windows.Forms.ToolStrip tsDidactiel;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStripButton btnFirstQuestion;
        private System.Windows.Forms.ToolStripButton btnLastQuestion;
        private System.Windows.Forms.ToolStripButton btnPreviousQuestion;
        private System.Windows.Forms.ToolStripButton btnNextQuestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPlayDidacticiel;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnResult;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.GroupBox groupBoxQuestionReponse;
        private System.Windows.Forms.RadioButton radbtnReponse4;
        private System.Windows.Forms.RadioButton radbtnReponse3;
        private System.Windows.Forms.RadioButton radbtnReponse2;
        private System.Windows.Forms.RadioButton radbtnReponse1;
    }
}
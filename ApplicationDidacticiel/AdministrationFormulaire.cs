using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace ApplicationDidacticiel
{
    public partial class AdministrationFormulaire : Form
    {
        public AdministrationFormulaire()
        {
            InitializeComponent();
        }


        //-----------------Lorsque l'on lance le formulaire----------------------------------

        private void AdministrationFormulaire_Load_1(object sender, EventArgs e)
        {
            GestionDidacticiel.chemin = string.Empty;
            GestionDidacticiel.chemin = Environment.CurrentDirectory;
            GestionDidacticiel.chemin = Directory.GetParent(GestionDidacticiel.chemin).ToString();
            GestionDidacticiel.chemin = Directory.GetParent(GestionDidacticiel.chemin).ToString();

            if (File.Exists(GestionDidacticiel.fichier))
            {
                listBoxAffichageQuestionImage.Items.Clear();
                GestionDidacticiel.listeQuestionReponse.Clear();
                GestionDidacticiel.LectureQuestionReponsesDansFichier(GestionDidacticiel.fichier);
                GestionDidacticiel.AffichageQuestionReponses(listBoxAffichageQuestionImage);
            }
        }


        //-----------------Validation Question------------------------------------------------

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            lblValidationQuestion_Click(sender, e);
        }

        private void lblValidationQuestion_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text != string.Empty)
            {
                for(int i = 0; i < GestionDidacticiel.listeQuestionReponse.Count; i++)
                {
                    if (txtQuestion.Text == GestionDidacticiel.listeQuestionReponse[i].Question)
                    {
                        lblValidationQuestion.Visible = true;
                        lblValidationQuestion.Text = "La question existe déjà.";
                        break;
                    }
                    else
                    {
                        lblValidationQuestion.Visible = false;
                    }
                }
            }
            
            else
            { 
                lblValidationQuestion.Visible = true;
                lblValidationQuestion.Text = "Indiquez votre question.";
            }
        }

        //--------------------Valider Image------------------------------------


        private void btnSelectionnerImage_Click(object sender, EventArgs e)
        {
            GestionDidacticiel.SelectionImage(openBoiteDialogue, pictureBox1, listBoxAffichageQuestionImage);
            lblmage_Click(sender, e);
        }

        private void lblmage_Click(object sender, EventArgs e)
        {
            if (openBoiteDialogue.FileName != "")
            {
                lblmage.Visible = false;
            }
            else
            {
                lblmage.Visible = true;
                lblmage.Text = "Sélectionnez une image";
            }
        }

        //--------------------------Valider Réponse 1-----------------------------------------

        private void txtReponse1_TextChanged(object sender, EventArgs e)
        {
            lblValidationReponse1_Click(sender, e);
            lblValidationBonneReponse_Click(sender, e);

        }

        private void lblValidationReponse1_Click(object sender, EventArgs e)
        {
            if (txtReponse1.Text != string.Empty)
            {
                lblValidationReponse1.Visible = false;
            }
            else
            { lblValidationReponse1.Visible = true; }
        }

        //--------------------------Valider Réponse 2-----------------------------------------

        private void txtReponse2_TextChanged(object sender, EventArgs e)
        {
            lblValidationReponse2_Click(sender, e);
            lblValidationBonneReponse_Click(sender, e);
        }

        private void lblValidationReponse2_Click(object sender, EventArgs e)
        {
            if (txtReponse2.Text != string.Empty)
            {
                lblValidationReponse2.Visible = false;
            }
            else
            { lblValidationReponse2.Visible = true; }
        }

        //--------------------------Valider Réponse 3-----------------------------------------

        private void txtReponse3_TextChanged(object sender, EventArgs e)
        {
            lblValidationReponse3_Click(sender, e);         
            lblValidationBonneReponse_Click(sender, e);
        }

        private void lblValidationReponse3_Click(object sender, EventArgs e)
        {
            if (txtReponse3.Text != string.Empty)
            {
                lblValidationReponse3.Visible = false;
            }
            else
            { lblValidationReponse3.Visible = true; }
        }

        //--------------------------Valider Réponse 4-----------------------------------------

        private void txtReponse4_TextChanged(object sender, EventArgs e)
        {
            lblValidationReponse4_Click(sender, e);
            lblValidationBonneReponse_Click(sender, e);
        }

        private void lblValidationReponse4_Click(object sender, EventArgs e)
        {
            if (txtReponse4.Text != string.Empty)
            {
                lblValidationReponse4.Visible = false;
            }
            else
            { lblValidationReponse4.Visible = true; }
        }

        //-------------------------Valider Bonne Réponse---------------------------------------

        private void txtBonneReponse_TextChanged(object sender, EventArgs e)
        {
            lblValidationBonneReponse_Click(sender, e);
        }


        private void lblValidationBonneReponse_Click(object sender, EventArgs e)
        {
            if (txtBonneReponse.Text == txtReponse1.Text || txtBonneReponse.Text == txtReponse2.Text || txtBonneReponse.Text == txtReponse3.Text || txtBonneReponse.Text == txtReponse4.Text)
            {
                if ((txtBonneReponse.Text == txtReponse1.Text && txtBonneReponse.Text == txtReponse2.Text) || (txtBonneReponse.Text == txtReponse1.Text && txtBonneReponse.Text == txtReponse3.Text)
                    || (txtBonneReponse.Text == txtReponse4.Text && txtBonneReponse.Text == txtReponse1.Text) || (txtBonneReponse.Text == txtReponse2.Text && txtBonneReponse.Text == txtReponse3.Text) || (txtBonneReponse.Text == txtReponse2.Text
                     && txtBonneReponse.Text == txtReponse4.Text) || (txtBonneReponse.Text == txtReponse3.Text && txtBonneReponse.Text == txtReponse4.Text))
                {
                    lblValidationBonneReponse.Visible = true;
                    lblValidationBonneReponse.Text = "      Le champs doit correspondre à UNE réponse.";

                }
                else
                {
                    lblValidationBonneReponse.Visible = false;
                }
            }
            else
            {
                lblValidationBonneReponse.Visible = true;
            }
        }


        //------------------------Affichage Question Réponses dans Listbox-------------------------------------

        private void listBoxAffichageQuestionImage_SelectedIndexChanged(object sender, EventArgs e)
        {

            //txtQuestion.Text = GestionDidacticiel.listeQuestionReponse[listBoxAffichageQuestionImage.SelectedIndex].Question;
            //txtReponse1.Text = GestionDidacticiel.listeQuestionReponse[listBoxAffichageQuestionImage.SelectedIndex].Reponse1;
            //txtReponse2.Text = GestionDidacticiel.listeQuestionReponse[listBoxAffichageQuestionImage.SelectedIndex].Reponse2;
            //txtReponse3.Text = GestionDidacticiel.listeQuestionReponse[listBoxAffichageQuestionImage.SelectedIndex].Reponse3;
            //txtReponse4.Text = GestionDidacticiel.listeQuestionReponse[listBoxAffichageQuestionImage.SelectedIndex].Reponse4;
            //txtBonneReponse.Text = GestionDidacticiel.listeQuestionReponse[listBoxAffichageQuestionImage.SelectedIndex].BonneReponse;


            for (int i = 0; i < GestionDidacticiel.listeQuestionReponse.Count; i++)
            {

                if (listBoxAffichageQuestionImage.SelectedIndex == i)
                {
                    txtQuestion.Text = GestionDidacticiel.listeQuestionReponse[i].Question;
                    txtReponse1.Text = GestionDidacticiel.listeQuestionReponse[i].Reponse1;
                    txtReponse2.Text = GestionDidacticiel.listeQuestionReponse[i].Reponse2;
                    txtReponse3.Text = GestionDidacticiel.listeQuestionReponse[i].Reponse3;
                    txtReponse4.Text = GestionDidacticiel.listeQuestionReponse[i].Reponse4;
                    txtBonneReponse.Text = GestionDidacticiel.listeQuestionReponse[i].BonneReponse;

                    break;
                }

            }


        }

        //-------------------------Ajouter Question + Réponses + Image--------------------------------------

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nomFichierImage = GestionDidacticiel.nomFichier;

            if (lblValidationQuestion.Visible == false && lblValidationReponse1.Visible == false && lblValidationReponse2.Visible == false && lblValidationReponse3.Visible == false &&
                    lblValidationReponse3.Visible == false && lblValidationReponse4.Visible == false && lblValidationBonneReponse.Visible == false && lblmage.Visible == false)
            {

                for (int i = 0; i < GestionDidacticiel.listeQuestionReponse.Count; i++)
                {
                    if (nomFichierImage == GestionDidacticiel.listeQuestionReponse[i].Photo)
                    {
                        nomFichierImage = "1" + nomFichierImage;
                        break;
                    }

                }

                // Ajout dans la liste.
                GestionDidacticiel qr1 = new GestionDidacticiel(txtQuestion.Text, txtReponse1.Text, txtReponse2.Text, txtReponse3.Text, txtReponse4.Text
                    , txtBonneReponse.Text, GestionDidacticiel.nomFichier);
                GestionDidacticiel.AjoutQuestionReponsesDansListe(qr1);

                //Creation d'une copie de l'image vers le dossier "Images".
                File.Copy(openBoiteDialogue.FileName, GestionDidacticiel.chemin + @"/Images/" + nomFichierImage);

                //Ecriture dans le fichier.
                GestionDidacticiel.EcritureFIchier(GestionDidacticiel.fichier);


                //On actualise les questions dans la listBox.
                listBoxAffichageQuestionImage.Items.Clear();
                GestionDidacticiel.AffichageQuestionReponses(listBoxAffichageQuestionImage);

                // Remise à zéro textbox
                txtQuestion.Text = string.Empty;
                txtReponse1.Text = string.Empty;
                txtReponse2.Text = string.Empty;
                txtReponse3.Text = string.Empty;
                txtReponse4.Text = string.Empty;
                txtBonneReponse.Text = string.Empty;
                openBoiteDialogue.FileName = "";
                pictureBox1.Image = System.Drawing.Image.FromFile(GestionDidacticiel.chemin + @"/Resources/logo.png");
                lblmage_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Vérifiez vos champs.");
                return;
            }
        }

        //---------------------------- Supprimer Question + Réponses + Image------------------------------------------

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (File.Exists(GestionDidacticiel.fichier))
            {
                DialogResult result = MessageBox.Show("Voulez-vous supprimer cette question ?", "Suppression", MessageBoxButtons.YesNo);

                // Action à effectuer si l'utilisateur a sélectionné "Oui"

                if (result == DialogResult.Yes)
                {

                    GestionDidacticiel.SuppressionQuestionReponseImage(listBoxAffichageQuestionImage);

                    if (GestionDidacticiel.listeQuestionReponse.Count > 0)
                    {
                        GestionDidacticiel.EcritureFIchier(GestionDidacticiel.fichier);
                        listBoxAffichageQuestionImage.Items.Clear();
                        GestionDidacticiel.AffichageQuestionReponses(listBoxAffichageQuestionImage);
                    }
                    else
                    {
                        File.Delete(GestionDidacticiel.fichier.ToString());
                        listBoxAffichageQuestionImage.Items.Clear();
                    }

                    txtQuestion.Text = string.Empty;
                    txtReponse1.Text = string.Empty;
                    txtReponse2.Text = string.Empty;
                    txtReponse3.Text = string.Empty;
                    txtReponse4.Text = string.Empty;
                    txtBonneReponse.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Suppression annulée.");
                }
            }

            else
            {
                MessageBox.Show("Pas de question. Veuillez ajouter une question.");
            }
        }

        //---------------------------- Se déconnecter ----------------------------------------------------------------

        private void btnSeDeconnecter_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }
     
    }
}
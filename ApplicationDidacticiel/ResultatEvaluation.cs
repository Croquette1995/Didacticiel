using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ApplicationDidacticiel
{
    public partial class ResultatEvaluation : Form
    {
        public ResultatEvaluation()
        {
            InitializeComponent();
        }

        private void ResultatEvaluation_Load(object sender, EventArgs e)
        {
            string chemin = string.Empty;
            chemin = Environment.CurrentDirectory;
            chemin = Directory.GetParent(chemin).ToString();
            chemin = Directory.GetParent(chemin).ToString();
            Evaluation.EcritureResultat(Evaluation.fichier);
            txtInfosDuree.Text = "Début de l'épreuve : " + Evaluation.debutEpreuve.ToString("hh:mm:ss") + Environment.NewLine +
                "Fin de l'épreuve : " + Evaluation.finEpreuve.ToString("hh:mm:ss") + Environment.NewLine +"Durée de l'épreuve : " + Evaluation.duree;



            pictureBoxResultatEtudiant.Image = Image.FromFile(chemin + @"/Resources/ImageResultatEtudiant.png");
            lblResultatEtudiant.Text = "Résultat de l'étudiant(e) " + Evaluation.identifiant; 

            for (int i = 0; i< Evaluation.resultatEvaluation.Count-1; i++)
            {
                if (Evaluation.resultatEvaluation[i].Point == 1) 
                {
                    lstReponseCorrect.Items.Add("Question n° " + (i+1) + "; " + Evaluation.resultatEvaluation[i].Question + ";" +
                        "Réponse ; " + Evaluation.resultatEvaluation[i].BonneReponse);
                }
                else
                {
                    
                    lstReponseIncorrecte.Items.Add("Question n° " + (i+1) + "; " + Evaluation.resultatEvaluation[i].Question + ";" +
                        "Réponse ; " + Evaluation.resultatEvaluation[i].BonneReponse);
                }
            }

            if (Evaluation.totalPoints > (Evaluation.listeAleatoire.Count / (double) 2))
            {
                label1.Text = "Réussi !" + Environment.NewLine + Evaluation.totalPoints + " / " + (Evaluation.listeAleatoire.Count );
                label1.Visible = true;
            }

            else
            {
                if (Evaluation.totalPoints < 0)
                {
                    Evaluation.totalPoints = 0;  // Pas de résultat négatif.

                    label1.Text = "Echec !" + Environment.NewLine + Evaluation.totalPoints + " / " + (Evaluation.listeAleatoire.Count);
                    label1.Image = Image.FromFile(chemin + @"/Resources/Echec.png");
                    label1.Visible = true;
                }
             
                else
                {
                    label1.Text = "Echec !" + Environment.NewLine + Evaluation.totalPoints + " / " + (Evaluation.listeAleatoire.Count);
                    label1.Image = Image.FromFile(chemin + @"/Resources/Echec.png");
                    label1.Visible = true;
                }
            }

        }

        //----------Affichage dans les textbox via event selectedIndex des listes déroulantes -------------------------------------
        private void lstReponseIncorrecte_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstReponseCorrect.SelectedIndex = -1;

            if (lstReponseIncorrecte.SelectedIndex != -1)
            {
                string questionReponse = lstReponseIncorrecte.SelectedItem.ToString();
                string[] tableau = questionReponse.Split(';');

                txtQuestion.Text = tableau[1].Trim();
                txtReponse.Text = tableau[3].Trim();
            }
        }

        private void lstReponseCorrect_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstReponseIncorrecte.SelectedIndex = -1;

            if(lstReponseCorrect.SelectedIndex != -1)
            {
                string questionReponse = lstReponseCorrect.SelectedItem.ToString();
                string[] tableau = questionReponse.Split(';');

                txtQuestion.Text = tableau[1].Trim();
                txtReponse.Text = tableau[3].Trim();
            }                                    
        }
    }
}

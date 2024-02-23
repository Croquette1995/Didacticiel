using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using ComponentFactory.Krypton.Toolkit;

namespace ApplicationDidacticiel
{
    public partial class Didacticiel : Form
    {
        public Didacticiel()
        {
            InitializeComponent();

        }


        // Connu de tout le monde dans le formulaire, mais uniquement dans le formulaire.
        // Déclaration timer
        private System.Windows.Forms.Timer timer;


        //-----------------------Event Load ==> Initialisation du timer + Gestion du chemin + Gestion Toolstrip + Chargement image------------------------------

        private void Didacticiel_Load(object sender, EventArgs e)
        {

            //---------------Initialisation timer--------------------

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 30000; // 30 secondes
            timer.Tick += Timer_Tick;

            GestionDidacticiel.chemin = string.Empty;
            GestionDidacticiel.chemin = Environment.CurrentDirectory;
            GestionDidacticiel.chemin = Directory.GetParent(GestionDidacticiel.chemin).ToString();
            GestionDidacticiel.chemin = Directory.GetParent(GestionDidacticiel.chemin).ToString();
            Evaluation.totalPoints = 0;

            foreach (ToolStripItem toolStripItem in tsDidactiel.Items)
            {
                if (toolStripItem.Name != btnLogout.Name && toolStripItem.Name != btnPlayDidacticiel.Name)
                {
                    toolStripItem.Enabled = false;
                }
                else
                    toolStripItem.Enabled = true;

            }

            btnValider.Enabled = false;


            pictureBoxImageDidacticiel_Click(sender, e);
        }


        //------------------- chemin image ---------------------------------

        private void pictureBoxImageDidacticiel_Click(object sender, EventArgs e)
        {
            pictureBoxImageDidacticiel.Image = Image.FromFile(GestionDidacticiel.chemin + @"/Resources/logo.png");
        }

        //---------- Event se déclenchant lorsque l'intervalle de temps est écoulé ----------------------

        private void Timer_Tick(object sender, EventArgs e)
        {
            Evaluation evaluation = new Evaluation();
            evaluation.Question = Evaluation.listeAleatoire[Evaluation.indice].Question;
            evaluation.BonneReponse = Evaluation.listeAleatoire[Evaluation.indice].BonneReponse;
            Evaluation.totalPoints--;
            evaluation.Point = 0;
            Evaluation.AjoutListe(evaluation);

            Evaluation.indice++;

            if (Evaluation.indice < Evaluation.listeAleatoire.Count)
            {
                Evaluation.Affichage(groupBoxQuestionReponse, radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4, pictureBoxImageDidacticiel);
            }
            else
            {
                foreach (ToolStripItem toolStripItem in tsDidactiel.Items)
                {
                    if (toolStripItem.Name != btnPlayDidacticiel.Name)
                        toolStripItem.Enabled = true;

                    else
                        toolStripItem.Enabled = false;
                }

                btnValider.Enabled = false;
                btnFirstQuestion_Click(sender, e);
                timer.Stop();
                Evaluation.finEpreuve = DateTime.Now;
                Evaluation.DureeEvaluation();
                Evaluation.ResultatEtudiant();
                MessageBox.Show("Evaluation terminée.");

            }
        }

        //---------------------- Valider Réponse ---------------------------------------

        private void Valider_Click(object sender, EventArgs e)
        {
            if (radbtnReponse1.Checked == false && radbtnReponse2.Checked == false && radbtnReponse3.Checked == false && radbtnReponse4.Checked == false)
            {
                MessageBox.Show("Vous devez sélectionner une réponse.");
                return;
            }
            else
            {
                timer.Stop();
                Evaluation.ValiderReponse(radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4, groupBoxQuestionReponse);
            }

            Evaluation.indice++;
            if (Evaluation.indice < Evaluation.listeAleatoire.Count)
            {
                Evaluation.Affichage(groupBoxQuestionReponse, radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4, pictureBoxImageDidacticiel);
                timer.Start();

            }
            else
            {
                foreach (ToolStripItem toolStripItem in tsDidactiel.Items)
                {
                    if (toolStripItem.Name != btnPlayDidacticiel.Name)
                        toolStripItem.Enabled = true;

                    else
                        toolStripItem.Enabled = false;
                }

                btnValider.Enabled = false;
                btnFirstQuestion_Click(sender, e);
                timer.Stop();
                Evaluation.finEpreuve = DateTime.Now;
                Evaluation.DureeEvaluation();
                Evaluation.ResultatEtudiant();
                MessageBox.Show("Evaluation terminée");
            }
        }

        //----------------------------- Boutons ToolStrip ------------------------------------------------

        //------------------------------ Play ------------------------------------------------------------

        private void btnPlayDidacticiel_Click(object sender, EventArgs e)
        {
            Evaluation.resultatEvaluation.Clear();
            GestionDidacticiel.listeQuestionReponse.Clear();
            Evaluation.listeAleatoire.Clear();
            GestionDidacticiel.LectureQuestionReponsesDansFichier(GestionDidacticiel.fichier);
            Evaluation.ListeAleatoire();
            Evaluation.indice = 0;

            Evaluation.Affichage(groupBoxQuestionReponse, radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4, pictureBoxImageDidacticiel);

            foreach (ToolStripItem toolStripItem in tsDidactiel.Items)
            {
                toolStripItem.Enabled = false;
            }

            btnValider.Enabled = true;

            timer.Start();
            Evaluation.debutEpreuve = DateTime.Now;
        }

        //-------------------- Reload ---------------------------------

        private void btnReload_Click(object sender, EventArgs e)
        {
            Evaluation.listeAleatoire.Clear();
            Evaluation.resultatEvaluation.Clear();
            Evaluation.ListeAleatoire();
            Evaluation.indice = 0;
            Evaluation.totalPoints = 0;

            Evaluation.Affichage(groupBoxQuestionReponse, radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4, pictureBoxImageDidacticiel);


            // iteration sur les boutons présents dans la toolstrip.
            foreach (ToolStripItem toolStripItem in tsDidactiel.Items)
            {
                toolStripItem.Enabled = false;
            }

            btnValider.Enabled = true;
            timer.Stop();
            timer.Start();
            Evaluation.debutEpreuve = DateTime.Now;
        }

        //-------------------- Result + Logout -----------------------------


        private void btnResult_Click(object sender, EventArgs e)
        {
            ResultatEvaluation resultatEvaluation = new ResultatEvaluation();
            resultatEvaluation.Show();
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        //------------------------ Boutons pour naviguer -------------------------------

        private void btnFirstQuestion_Click(object sender, EventArgs e)
        {
            btnFirstQuestion.Enabled = false;
            btnPreviousQuestion.Enabled = false;
            btnLastQuestion.Enabled = true;
            btnNextQuestion.Enabled = true;
            Evaluation.indice = 0;

            Evaluation.Affichage(groupBoxQuestionReponse, radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4, pictureBoxImageDidacticiel);
            Evaluation.AffichageRadioButtonBonneReponse(radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4);
        }

        private void btnPreviousQuestion_Click(object sender, EventArgs e)
        {
            btnFirstQuestion.Enabled = true;
            Evaluation.indice--;

            if(Evaluation.indice == 0)
            {
                btnFirstQuestion_Click(sender, e);
                btnPreviousQuestion.Enabled = false;
            }
            else
            {
                Evaluation.Affichage(groupBoxQuestionReponse, radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4, pictureBoxImageDidacticiel);
                Evaluation.AffichageRadioButtonBonneReponse(radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4);
            }

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            btnFirstQuestion.Enabled = true;
            btnPreviousQuestion.Enabled= true;
            Evaluation.indice++;

            if(Evaluation.indice == Evaluation.listeAleatoire.Count - 1) 
            {
                btnLastQuestion_Click(sender, e);
                btnNextQuestion.Enabled = false;
            }
            else
            {
                Evaluation.Affichage(groupBoxQuestionReponse, radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4, pictureBoxImageDidacticiel);
                Evaluation.AffichageRadioButtonBonneReponse(radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4);
            }

        }

        private void btnLastQuestion_Click(object sender, EventArgs e)
        {
           
            btnLastQuestion.Enabled = false;
            btnNextQuestion.Enabled = false;
            btnFirstQuestion.Enabled = true;
            btnPreviousQuestion.Enabled = true;
            Evaluation.indice = Evaluation.listeAleatoire.Count-1;

            Evaluation.Affichage(groupBoxQuestionReponse, radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4, pictureBoxImageDidacticiel);
            Evaluation.AffichageRadioButtonBonneReponse(radbtnReponse1, radbtnReponse2, radbtnReponse3, radbtnReponse4);
        }

        //---------------- Event qui se produit lors de la cloture du formulaire --------------

        private void Didacticiel_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Dispose();
        }
    }
}

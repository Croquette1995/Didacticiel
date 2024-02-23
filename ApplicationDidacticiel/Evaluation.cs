using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDidacticiel
{
    internal class Evaluation
    {
        //------------ Attributs || Champs ----------


        public static List<GestionDidacticiel> listeAleatoire = new List<GestionDidacticiel>();
        public static List<Evaluation> resultatEvaluation = new List<Evaluation>();
        public static int indice;
        public static string fichier = @"ResultatEtudiant";
        public static DateTime debutEpreuve;
        public static DateTime finEpreuve;
        public static string duree;


        private string question;
        private string bonneReponse;
        private string prenom;
        private int point;
        private int resultat;



        public static string identifiant;
        public static int totalPoints;


        public Evaluation (string question, string bonneReponse, int point)
        {
            this.question = question;
            this.bonneReponse = bonneReponse;
            this.point = point;
        }

        public Evaluation (string prenom ,int resultat)
        {
            this.prenom = prenom;
            this.resultat = resultat;
        }

        public Evaluation()
        {

        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string BonneReponse
        {
            get { return bonneReponse; }
            set { bonneReponse = value; }         
        }
        public int Point
        {
            get { return point; }
            set { point = value; }
        }

        public int Resultat
        {
            get { return resultat; }
            set { resultat = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        //---------Méthodes----------------

        public static void AjoutListe (Evaluation evaluation)
        {
            resultatEvaluation.Add (evaluation);
        }

        public static void AffichageQuestionReponses(ListBox listBox)
        {
            foreach (GestionDidacticiel questionReponse in GestionDidacticiel.listeQuestionReponseAleatoire)
            {
                listBox.Items.Add(questionReponse.Question + questionReponse.Reponse1 + questionReponse.Reponse2 +
                    questionReponse.Reponse3 + questionReponse.Reponse4 + questionReponse.BonneReponse +
                    questionReponse.Photo);
            }

        }

        public static void ListeAleatoire()
        {
            Random chiffrealeatoire = new Random();
            int index = 1;

            foreach (GestionDidacticiel element in GestionDidacticiel.listeQuestionReponse)
            {
                listeAleatoire.Insert(chiffrealeatoire.Next(0, index), element);
                index++;
            }

        }

        public static void Affichage(GroupBox question ,RadioButton reponse1, RadioButton reponse2, RadioButton reponse3, RadioButton reponse4, PictureBox image)
        {
            question.Text = "Question "+ (indice + 1).ToString() +" / " + listeAleatoire.Count + " : "  + listeAleatoire[indice].Question;
            reponse1.Text = listeAleatoire[indice].Reponse1;
            reponse1.Checked = false;
            reponse2.Text = listeAleatoire[indice].Reponse2;
            reponse2.Checked = false;
            reponse3.Text = listeAleatoire[indice].Reponse3;
            reponse3.Checked = false;
            reponse4.Text = listeAleatoire[indice].Reponse4;
            reponse4.Checked = false;
            image.Image = Image.FromFile(GestionDidacticiel.chemin + @"/Images/" + listeAleatoire[indice].Photo);
        }


        public static void AffichageRadioButtonBonneReponse(RadioButton reponse1, RadioButton reponse2, RadioButton reponse3, RadioButton reponse4)
        {
            if (reponse1.Text == listeAleatoire[indice].BonneReponse)
                reponse1.Checked = true;

            else if (reponse2.Text == listeAleatoire[indice].BonneReponse)
                reponse2.Checked = true;

            else if (reponse3.Text == listeAleatoire[indice].BonneReponse)
                reponse3.Checked = true;
            else
                reponse4.Checked=true;           
        }



        public static void ValiderReponse(RadioButton radbtnReponse1, RadioButton radbtnReponse2, RadioButton radbtnReponse3, RadioButton radbtnReponse4, GroupBox groupBoxQuestionReponse)
        {
            Evaluation evaluation = new Evaluation();

            evaluation.Question = Evaluation.listeAleatoire[Evaluation.indice].Question;
            evaluation.BonneReponse = Evaluation.listeAleatoire[Evaluation.indice].BonneReponse;

            if (radbtnReponse1.Checked == true)
                radbtnReponse1.Tag = true;

            else if (radbtnReponse2.Checked == true)
                radbtnReponse2.Tag = true;

            else if (radbtnReponse3.Checked == true)
                radbtnReponse3.Tag = true;

            else
                radbtnReponse4.Tag = true;

            foreach (Control control in groupBoxQuestionReponse.Controls)
            {
                if (Convert.ToBoolean(control.Tag) == true)
                {
                    if (control.Text == Evaluation.listeAleatoire[Evaluation.indice].BonneReponse)
                    {
                        Evaluation.totalPoints++;
                        evaluation.Point = 1;
                        control.Tag = false;
                    }
                    else
                    {
                        Evaluation.totalPoints--;
                        evaluation.Point = 0;
                        control.Tag = false;
                    }
                    break;
                }
            }

            Evaluation.AjoutListe(evaluation);
        }

        public static void ResultatEtudiant()
        {
            Evaluation evaluation = new Evaluation();
            evaluation.Prenom = identifiant;
            evaluation.Resultat = totalPoints;
            Evaluation.AjoutListe(evaluation);
        }

        public static void EcritureResultat(string fichier)
        {
            StreamWriter streamWriter= new StreamWriter(fichier);
            for(int i = 0; i< resultatEvaluation.Count; i++)
            {
                if (i == resultatEvaluation.Count - 1)
                {
                    streamWriter.WriteLine(resultatEvaluation[i].Prenom + ";" + resultatEvaluation[i].Resultat);
                }
                else
                    streamWriter.WriteLine(resultatEvaluation[i].Question +";" + resultatEvaluation[i].Point);
            }
            streamWriter.Close();
        }

        public static string DureeEvaluation()
        {
            duree = string.Empty;
            string dureeAFormater = Evaluation.finEpreuve.Subtract(Evaluation.debutEpreuve).ToString();

            for (int i = 0; i < dureeAFormater.Length; i++)
            {
                if (dureeAFormater.Substring(i, 1) == ".")
                    duree = dureeAFormater.Substring(0, dureeAFormater.Length - i);
            }
            return duree;
        }
    }
}

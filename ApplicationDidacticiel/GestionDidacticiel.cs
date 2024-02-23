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
    internal class GestionDidacticiel
    {
        public static string nomFichier = string.Empty;
        public static string chemin = string.Empty;


        //-----------Attributs-----------------
        //-----Attributs sont privés au niveau du client, pas de la classe.
        // Dans un fichier tout est string.
        private string question;
        private string reponse1;
        private string reponse2;
        private string reponse3;
        private string reponse4;
        private string bonneReponse;
        private string photo;

        //-----Constructeurs------------
        //-----Paramétré--------------
        public GestionDidacticiel(string question, string reponse1, string reponse2, string reponse3, string reponse4, string bonneReponse, string photo)
        {
            this.question = question;
            this.reponse1 = reponse1;
            this.reponse2 = reponse2;
            this.reponse3 = reponse3;
            this.reponse4 = reponse4;
            this.bonneReponse = bonneReponse;
            this.photo = photo;
        }

        public GestionDidacticiel(string question, string reponse1, string reponse2, string reponse3, string reponse4, string bonneReponse)
        {
            this.question = question;
            this.reponse1 = reponse1;
            this.reponse2 = reponse2;
            this.reponse3 = reponse3;
            this.reponse4 = reponse4;
            this.bonneReponse = bonneReponse;
        }

        //-----Par défaut--------------
        public GestionDidacticiel()
        {

        }

        //------Listes----------------
        // Va contenir la question, les réponses, la bonne réponse et la photo.
        public static List<GestionDidacticiel> listeQuestionReponse = new List<GestionDidacticiel>();

        // Va contenir la question, les réponses, la bonne réponse et la photo de manière aléatoire
        public static List<GestionDidacticiel> listeQuestionReponseAleatoire = new List<GestionDidacticiel>();

        // Va contenir les nombres aléatoires (ex : 10 questions ----> 1,2,3..... -----> 9,7,5,etc)
        public static List<int> listeNombreAleatoire = new List<int>();

        // Va contenir la liste des questions
        public static string fichier = @"FichierQuestionReponse";

        //-----Déclaration de variables---------

        //On la déclare public par facilité.

        public static int numeroQuestion;
        public static string[] photos;

        //-----Propriétés----------------

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string Reponse1
        {
            get { return reponse1; }
            set { reponse1 = value; }
        }

        public string Reponse2
        {
            get { return reponse2; }
            set { reponse2 = value; }
        }

        public string Reponse3
        {
            get { return reponse3; }
            set { reponse3 = value; }
        }

        public string Reponse4
        {
            get { return reponse4; }
            set { reponse4 = value; }
        }

        public string BonneReponse
        {
            get { return bonneReponse; }
            set { bonneReponse = value; }
        }

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }



        //-------------Méthodes-----------------------

        public static void AjoutQuestionReponsesDansListe(GestionDidacticiel gestionDidacticiel)
        {
            listeQuestionReponse.Add(gestionDidacticiel);


        }


        //--------------------------------------------

        public static void EcritureFIchier(string fichier) // String fichier contient le nom du fichier.
        {
            StreamWriter ecritureFichier = new StreamWriter(fichier);

            for (int i = 0; i < listeQuestionReponse.Count; i++)
            {
                ecritureFichier.WriteLine(listeQuestionReponse[i].Question + ";" + listeQuestionReponse[i].Reponse1 + ";" +
                    listeQuestionReponse[i].Reponse2 + ";" + listeQuestionReponse[i].Reponse3 + ";" + listeQuestionReponse[i].Reponse4
                    + ";" + listeQuestionReponse[i].BonneReponse + ";" + listeQuestionReponse[i].Photo);
            }

            ecritureFichier.Close();
        }
       

        //--------------------------------------------

        public static void LectureQuestionReponsesDansFichier(string fichier)
        {
            //-----> fichier -----> objet ---->  introduit dans liste

            StreamReader lectureFichier = new StreamReader(fichier);

            GestionDidacticiel gestionDidacticiel; // declaration

            string[] champsDeLaLigne;

            string lectureLigneFichier = lectureFichier.ReadLine();

            while (lectureLigneFichier != null)
            {
                champsDeLaLigne = lectureLigneFichier.Split(';');

                gestionDidacticiel = new GestionDidacticiel(champsDeLaLigne[0], champsDeLaLigne[1], champsDeLaLigne[2],
                    champsDeLaLigne[3], champsDeLaLigne[4], champsDeLaLigne[5], champsDeLaLigne[6]);    //Affectation

                GestionDidacticiel.AjoutQuestionReponsesDansListe(gestionDidacticiel);

                lectureLigneFichier = lectureFichier.ReadLine();
            }

            lectureFichier.Close();
        }

        //---------------------------------------------------

        public static void NombreAleatoire()
        {
            // 10 questions ----> 1,2,3 , ..... -------> 9,4,7, etc.

            Random random = new Random();

            int nombreDeQuestion = listeQuestionReponse.Count();

            listeNombreAleatoire.Add(random.Next(0, nombreDeQuestion));

            for (int i = 1; i < nombreDeQuestion; i++)
            {
                listeNombreAleatoire.Add(random.Next(0, nombreDeQuestion));
                for (int j = i - 1; j >= 0; j--)
                {
                    if (listeNombreAleatoire[i] == listeNombreAleatoire[j])
                    {
                        listeNombreAleatoire.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

        }

        public static void AjoutQuestionReponsesDansListeAleatoire()
        {
            for (int i = 0; i < listeQuestionReponse.Count; i++)
            {
                listeQuestionReponseAleatoire.Add(listeQuestionReponse[listeNombreAleatoire[i]]);
            }
        }



        //----------------------------Methodes de tests--------------------

        //public static void AffichageQuestionReponses(ListBox listBox)
        //{
        //    foreach (GestionDidacticiel questionReponse in listeQuestionReponse)
        //    {
        //        listBox.Items.Add(questionReponse.Question + questionReponse.Reponse1 + questionReponse.Reponse2 +
        //            questionReponse.Reponse3 + questionReponse.Reponse4 + questionReponse.BonneReponse +
        //            questionReponse.Photo);
        //    }

        //}

        public static void AffichageNombreAleatoire(ListBox listBox)
        {
            for (int i = 0; i < listeNombreAleatoire.Count; i++)
            {
                listBox.Items.Add(listeNombreAleatoire[i]);
            }
        }

        //-----------Images-----------------------------

        public static string[] ChargerImage()
        {
            string dossierCourant = Environment.CurrentDirectory;
            dossierCourant = Directory.GetParent(dossierCourant).ToString();
            dossierCourant = Directory.GetParent(dossierCourant).ToString();

            photos = Directory.GetFiles(dossierCourant + @"\Images");


            return photos;
        }


        public static void SelectionImage(OpenFileDialog boiteDialogue, PictureBox pictureBox, KryptonListBox listBox)
        {
            nomFichier = string.Empty;
            string chemin = string.Empty;
            string nomFichierMauvaisOrdre = string.Empty;

            DialogResult resultat = boiteDialogue.ShowDialog();

            // Test réussi.
            if (resultat == DialogResult.OK) 
            {
                pictureBox.Image = System.Drawing.Image.FromFile(boiteDialogue.FileName);

                // Decomposer le chemin 
                chemin = boiteDialogue.FileName;

                for (int i = chemin.Length - 1; i >= 0; i--)
                {
                    if (chemin[i] == '\\')
                    {
                        break;
                    }
                    else
                    {
                        nomFichierMauvaisOrdre += chemin[i];
                    }
                }

                // Remettre le nom du fichier dans le bon ordre. 

                for (int i = nomFichierMauvaisOrdre.Length - 1; i >= 0; i--)
                {
                    nomFichier += nomFichierMauvaisOrdre[i];
                }

                // Ajouter un chiffre avant le nom du fichier. 
                nomFichier = listBox.Items.Count + nomFichier;

            }
            else
            {
                return;
            }          
        }

        public static void AffichageQuestionReponses(KryptonListBox listBox)
        {
            foreach (GestionDidacticiel questionReponse in GestionDidacticiel.listeQuestionReponse)
            {
                listBox.Items.Add(questionReponse.Question);
            }
       
        }


        public static void SuppressionQuestionReponseImage(KryptonListBox listBoxAffichageQuestionImage)
        {
            for(int i = 0; i < listeQuestionReponse.Count; i++)
            {
                if (listBoxAffichageQuestionImage.SelectedIndex == i)
                {
                    File.Delete(chemin + @"/Images/" + listeQuestionReponse[i].Photo);
                    listeQuestionReponse.RemoveAt(i);
                    break;
                }
            }

            //File.Delete(chemin + @"/Images/" + listeQuestionReponse[listBoxAffichageQuestionImage.SelectedIndex].Photo);
            //listeQuestionReponse.RemoveAt(listBoxAffichageQuestionImage.SelectedIndex);
        }             
    }
}
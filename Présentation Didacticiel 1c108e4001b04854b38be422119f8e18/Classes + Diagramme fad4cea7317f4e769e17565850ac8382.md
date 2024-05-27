# Classes + Diagramme

# Diagramme de classes + Classes + Code

## Vue d’ensemble

![Untitled](Classes%20+%20Diagramme%20fad4cea7317f4e769e17565850ac8382/Untitled.png)

## Details

![Untitled](Classes%20+%20Diagramme%20fad4cea7317f4e769e17565850ac8382/Untitled%201.png)

- “Settings” et “Program“
    - Bon fonctionnement de l’application
- “Resources”
    - Contient les images
    

## Formulaires

![Untitled](Classes%20+%20Diagramme%20fad4cea7317f4e769e17565850ac8382/Untitled%202.png)

![Untitled](Classes%20+%20Diagramme%20fad4cea7317f4e769e17565850ac8382/Untitled%203.png)

![Untitled](Classes%20+%20Diagramme%20fad4cea7317f4e769e17565850ac8382/Untitled%204.png)

![Untitled](Classes%20+%20Diagramme%20fad4cea7317f4e769e17565850ac8382/Untitled%205.png)

![Untitled](Classes%20+%20Diagramme%20fad4cea7317f4e769e17565850ac8382/Untitled%206.png)

## Classes

![Untitled](Classes%20+%20Diagramme%20fad4cea7317f4e769e17565850ac8382/Untitled%207.png)

![Untitled](Classes%20+%20Diagramme%20fad4cea7317f4e769e17565850ac8382/Untitled%208.png)

![Untitled](Classes%20+%20Diagramme%20fad4cea7317f4e769e17565850ac8382/Untitled%209.png)

- “Classe Personne”
    - Champs
    - Propriétés
    - Méthodes
    - Principe de fonctionnement

- Classe “Evaluation”
- Utilité ?
- Auto-critique
    - La classe “GestionDidacticiel” aurait pu et aurait dû l’englober.
    - Pas ou peu de cohérence entre les méthodes et propriétés.

- Classe “GestionDidacticiel”
- Utilité ?

## Code classe “Evaluation”

```csharp
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
```

## Code classe “Personne”

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDidacticiel
{
    internal class Personne
    {

        //Attributs
        private string nom;
        private string prenom;
        private string login;
        private string motDePasse;
        private string statut;

        //Constructeurs

        public Personne()
        {

        }

        public Personne(string nom, string prenom, string login, string motDePasse, string statut)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.motDePasse = motDePasse;
            this.statut = statut;
        }

        public static string fichier = @"personne";
        public static List<Personne> listeIdentifiantPersonne = new List<Personne>();

        //Propriétés

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string MotDePasse
        {
            get { return motDePasse; }
            set { motDePasse = value; }
        }

        public string Statut
        {
            get { return statut; }
            set { statut = value; }
        }

        //-----Méthodes---------

        public static void AjoutDansListe(Personne nouvellePersonne)
        {
            listeIdentifiantPersonne.Add(nouvellePersonne);
        }

        public static void LectureFichier(string fichier)
        {
            StreamReader streamReader = new StreamReader(fichier);
            string[] informationsPersonne;

            string ligneFichier = streamReader.ReadLine();

            Personne identifiantPersonne;

            while (ligneFichier != null)
            {
                informationsPersonne = ligneFichier.Split(';');
                identifiantPersonne = new Personne(informationsPersonne[0], informationsPersonne[1], informationsPersonne[2], informationsPersonne[3], informationsPersonne[4]);
                Personne.AjoutDansListe(identifiantPersonne);
                ligneFichier = streamReader.ReadLine();
            }
            streamReader.Close();
        }

        public static void EcritureFichier(string fichier)
        {
            StreamWriter streamWriter = new StreamWriter(fichier,true);
            for (int i = 0; i < Personne.listeIdentifiantPersonne.Count; i++)
            {
                streamWriter.WriteLine(Personne.listeIdentifiantPersonne[i].Nom + ";" + Personne.listeIdentifiantPersonne[i].Prenom + ";" + Personne.listeIdentifiantPersonne[i].Login
                   + ";" + Personne.listeIdentifiantPersonne[i].MotDePasse + ";" + Personne.listeIdentifiantPersonne[i].Statut);
            }
            streamWriter.Close();
        }
    }
}
```

## Code classe “GestionDidacticiel”

```csharp
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
```

[Code de l’application](Code%20de%20l%E2%80%99application%20446ee18a653c46238b8562560aebff86.md)

[Présentation : Didacticiel](../Pre%CC%81sentation%20Didacticiel%201c108e4001b04854b38be422119f8e18.md)
# “Principes algorithmiques et programmation” Rapport : Didacticiel

# Contexte

## **Réalisation d’un didacticiel dans le cadre du cours : Principes Algorithmiques Et Programmation**

Ce didacticiel se présente sous la forme d’un logiciel interactif et propose à l’utilisateur un questionnaire à choix multiples.

Pour réaliser le didacticiel, je dispose : 

- De ces outils
    - Microsoft Visual Studio (Edition Professionnelle 2022)
    - Langage C#
    - Krypton UI Component  [https://github.com/Krypton-Suite/Standard-Toolkit](https://github.com/Krypton-Suite/Standard-Toolkit)
    - Microsoft Office (PowerPoint)
    - Notion
        
        [Your wiki, docs & projects. Together.](https://www.notion.so)
        
- De différents supports
    - Cours
    - Internet
        - Documentation officielle de Microsoft  [https://learn.microsoft.com/en-us/dotnet/csharp/](https://learn.microsoft.com/en-us/dotnet/csharp/)
        - [https://www.dotnetperls.com/](https://www.dotnetperls.com/)
        - Pour la recherche d’images [https://pictogrammers.com/libraries/](https://pictogrammers.com/libraries/)
        

[Fonctionnalités](Fonctionnalite%CC%81s%2089f586ef26da41f58f973bb4046ab6a6.md)

[](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75.md) 

# Fonctionnalités

Pour présenter les fonctionnalités de l’application, je vais diviser celle-ci en fonction des formulaires qu’elle contient.  

## Formulaire Accueil

![formulaire accueil.png](Fonctionnalite%CC%81s%2089f586ef26da41f58f973bb4046ab6a6/formulaire_accueil.png)

- Si l’utilisateur est ‘existant’, celui-ci peut se connecter.  En fonction de son statut (professeur ou étudiant), il se verra proposer soit le didacticiel, soit le formulaire pour réaliser les questions du didacticiel.
- Si l’utilisateur n’existe pas, celui-ci doit s’inscrire.

[](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75.md) 

## Formulaire Inscription

![formulaire inscription.png](Fonctionnalite%CC%81s%2089f586ef26da41f58f973bb4046ab6a6/formulaire_inscription.png)

[](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75.md) 

- Une fois sur ce formulaire, 2 options s’offrent à l’utilisateur :
    1. Retourner sur le formulaire précédent en cliquant sur le lien “Me connecter”.
    2. Remplir les champs en respectant les conditions imposées  (Celles-ci sont expliquées dans l’application). 
- Si l’ensemble des champs est rempli correctement, l’utilisateur sera inscrit en cliquant sur le bouton “Je m’inscris”.  Les informations sont stockées dans le fichier “personne”, lequel sera utilisé pour se connecter sur le formulaire Accueil.

## Formulaire ‘AdministrationFormulaire’ (didacticiel)

![formulaire administrationFormulaire.png](Fonctionnalite%CC%81s%2089f586ef26da41f58f973bb4046ab6a6/formulaire_administrationFormulaire.png)

- Sur ce formulaire, l’utilisateur (professeur) pourra écrire les questions et définir les réponses associées à celles-ci.
- L’utilisateur pourra également sélectionner une image qui sera en lien avec la question.
- Le professeur pourra afficher les questions en utilisant la liste déroulante.
- Les questions seront ajoutées ou supprimées, dans un fichier, en cliquant respectivement sur les boutons “ajouter” et “supprimer”.
- Enfin, il sera possible à tout moment de quitter cette interface en cliquant sur le bouton “Se déconnecter”.

<aside>
<img src="https://www.notion.so/icons/asterisk_red.svg" alt="https://www.notion.so/icons/asterisk_red.svg" width="40px" /> N.B. :

- J’ai décidé de ne pas rajouter la fonctionnalité pour modifier une question puisque j’ai jugé qu’une modification, d’une certaine façon, était la même chose qu’une suppression suivie d’un ajout. (Et aussi parce que je suis un peu court au niveau du temps)
- À la base, lorsque l’utilisateur sélectionnait les questions dans la liste déroulante, les images étaient aussi affichées.  Mais j’ai rencontré des problèmes par après pour supprimer l’image pour des raisons de ressources non libérées.  J’ai compris que lorsque je souhaitais supprimer la question, l’image était toujours chargée via le “selectedIndex”.  Néanmoins, je n’ai pas su trouver de solution, j’ai donc décidé de supprimer cette fonctionnalité pour garantir le bon fonctionnement de l’application.
</aside>

[](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75.md) 

## Formulaire ‘Didacticiel’

![formulaire didacticiel.png](Fonctionnalite%CC%81s%2089f586ef26da41f58f973bb4046ab6a6/formulaire_didacticiel.png)

- Lorsque l’utilisateur (étudiant) arrive sur ce formulaire, il découvrira cette interface et lira les consignes.
- Celui-ci disposera de plusieurs options.  Dans un premier temps, il pourra commencer le didacticiel en cliquant sur le bouton “Play”. L’étudiant pourra également se déconnecter en cliquant sur “Logout”.

- Lorsque l’étudiant commence le didacticiel, il devra valider ses réponses en cliquant sur le bouton “Valider”.  S’il ne le fait pas, il ne pourra pas accéder à la question suivante (sauf si le temps est écoulé (30 secondes par question)).
- Une fois l’évaluation terminée, les fonctionnalités de navigation (les 4 premiers boutons en partant de la gauche) et les boutons “Reload” et “Result” deviennent accessibles.  Le bouton “Reload” permet de relancer une nouvelle évaluation.  Quant au bouton “Result”, celui-ci permet d’accéder à un nouveau formulaire qui affiche les résultats de l’évaluation (didacticiel).

## Formulaire ‘ResultatEvaluation”

![formulaire résultatEvaluation.png](Fonctionnalite%CC%81s%2089f586ef26da41f58f973bb4046ab6a6/formulaire_rsultatEvaluation.png)

- Dans ce dernier formulaire, l’étudiant peut enfin voir ses résultats et le temps qu’il a pris pour réaliser le didacticiel.
- Sur cette interface, on retrouve 2 listes déroulantes (questions réussies, questions ratées) qui permettent d’afficher la question et la bonne réponse associée à celle-ci.
- Le label au centre de l’image affiche le prénom de l’étudiant.
- Le label qui indique le score de l’étudiant, change d’image et de message en fonction du résultat.  Si le score de l’étudiant est négatif, son résultat sera de 0.
- L’étudiant quitte ce formulaire en le fermant tout simplement.
- Les résultats de l’évaluation sont stockés dans un fichier (ResultatEtudiant).

# Diagramme de classes

## Vue d’ensemble

L'application est constituée d'un certain nombre de classes. Voici leur représentation dans Visual Studio.

![Diagramme de classes de l’application](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75/Untitled.png)

Diagramme de classes de l’application

## Détails

Voici les 3 premières classes que je souhaite présenter.  Celles-ci sont celles qui vont le moins nous intéresser.  Les classes “Settings” et “Program” n’ont pas été vues en cours.  La classe “Settings” doit probablement contenir des paramètres généraux et la classe “Program” des paramètres essentiels au bon fonctionnement de l’application. 

Quant à la classe “Resources”, celle-ci contient l’ensemble des images que j’ai utilisées pour le design de mon application.  Les images se trouvent dans les propriétés  

![Classes “Resources”, “Settings” et “Program”](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75/Untitled%201.png)

Classes “Resources”, “Settings” et “Program”

## Les formulaires

Chaque classe contenant leurs lots de champs (attributs) et de méthodes (principalement des méthodes_Click puisque mes formulaires contiennent un certain nombre de boutons, mais également des keyPress et des TextChanged)

![Untitled](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75/Untitled%202.png)

![Untitled](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75/Untitled%203.png)

![Untitled](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75/Untitled%204.png)

![Untitled](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75/Untitled%205.png)

![Untitled](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75/Untitled%206.png)

## Les classes

![Untitled](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75/Untitled%207.png)

- La classe “Personne” avec ces champs, propriétés et méthodes.  Les autres classes fonctionneront plus ou moins de la même manière que celle-ci.
- Cette classe est nécessaire pour permettre aux utilisateurs de s’inscrire ou de se connecter (de ce fait, elle permet d’accéder à tous les formulaires).
- Comme son nom l’indique, le rôle de cette classe est de modéliser et de représenter (de manière très basique) un individu à travers ses identifiants.
- À un instant t, un objet de cette classe est créé, l’objet (et ses propriétés) est placé dans une liste.  Celle-ci va ensuite permettre de créer un fichier qui va contenir les identifiants de l’individu.
- Enfin, une méthode (LectureFichier) nous permet d’accéder aux informations de l’individu pour nous rendre sur d’autres formulaires ou bien remplir des propriétés qui appartiennent à d’autres classes.

![Untitled](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75/Untitled%208.png)

- Comme mentionné précédemment, la classe “Evaluation” reprend les principes de la classe “Personne“ (création d’un objet, objet placé dans une liste, écriture et lecture fichier).
- Cette classe va chercher les informations de la liste “GestionDidacticiel” pour afficher les questions de manière aléatoire pendant l’évaluation (formulaire didacticiel).
- La classe permet également de gérer l’état des “radioButton” et de valider chaque réponse.
- De plus, la classe permet, à travers la méthode ‘DureeEvaluation’ de calculer le temps pris par l’étudiant pour terminer le didacticiel.
- Enfin, via un objet, la classe permet de stocker le prénom, la question, la bonne réponse et le résultat obtenu à chaque question dans un fichier (écriture).
- La classe interagit donc avec la classe “GestionDidacticiel” et les formulaires “Didacticiel” et “ResultatEvaluation”.

![Untitled](%E2%80%9CPrincipes%20algorithmiques%20et%20programmation%E2%80%9D%20Rappor%20dc80d601a4794838839c4e8890fb9f75/Untitled%209.png)

- Comme mentionné précédemment, la classe « GestionDidacticiel » reprend les principes de la classe « Personne » et de la classe « Evaluation »(création d’un objet, objet placé dans une liste, écriture et lecture fichier).
- L’objet créé reprend les questions et les réponses fournies dans le formulaire d’administration par le professeur. (C’est ce qui le définit en tant que questionnaire)
- Je n’emploie pas toutes les méthodes. Certaines méthodes sont les vôtres et j’ai souhaité les conserver même si je ne les emploie pas. (Je pense notamment aux méthodes ‘AjoutQuestionReponseDansListeAleatoire’, ‘ChargerImage’, ‘NombreAleatoire’). Je ne les emploie pas car j’ai imaginé mon didacticiel différemment.
- Enfin, la classe « Gestion Didacticiel » va donc être retrouvée dans presque chaque formulaire puisque d’une certaine façon, c’est le cœur de l’application.

## Codes relatifs aux classes “Personne”, “Evaluation”, “GestionDidacticiel”

### Classe “Personne”

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

### Classe “Evaluation”

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

### Classe “GestionDidacticiel”

```csharp

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

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

            for (int i = 0; i < listeQuestionReponse.Count; i++)
            {
                if (listBoxAffichageQuestionImage.SelectedIndex == i)
                {
                    File.Delete(chemin + @"/Images/" + listeQuestionReponse[i].Photo);
                    listeQuestionReponse.RemoveAt(i);
                    break;
                }             
            }
          
        }
             
    }
}
```
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
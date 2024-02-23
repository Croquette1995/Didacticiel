using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ApplicationDidacticiel
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBoxAfficherMotDePasse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAfficherMotDePasse.Checked)
            {
                txtMotDePasse.PasswordChar = '*';
            }
            else
            {
                txtMotDePasse.PasswordChar = (char)0;
            }
        }

        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {
            checkBoxAfficherMotDePasse_CheckedChanged(sender, e);
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string motDePasse = txtMotDePasse.Text;

            if (File.Exists(Personne.fichier))
            {
                Personne.LectureFichier(Personne.fichier);
                for (int i = 0; i < Personne.listeIdentifiantPersonne.Count; i++)
                {
                    if (Personne.listeIdentifiantPersonne[i].Login == login)
                    {
                        if (Personne.listeIdentifiantPersonne[i].MotDePasse == motDePasse)
                        {
                            if (Personne.listeIdentifiantPersonne[i].Statut == "Etudiant")
                            {
                                Evaluation.identifiant = Personne.listeIdentifiantPersonne[i].Prenom;
                                Didacticiel didacticiel = new Didacticiel();
                                didacticiel.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                AdministrationFormulaire administrationFormulaire = new AdministrationFormulaire();
                                administrationFormulaire.Show();
                                this.Hide();
                                break;
                            }                        
                        }
                        else
                        {
                            lblSeConnecter.Text = "Mot de passe incorrect";
                            break;
                        }
                    }

                    else
                    {
                        lblSeConnecter.Text = "Login et/ou Mot de passe incorrect";
                    }
                }
            }
            else
            {
                lblSeConnecter.Text = "Veuillez vous inscrire";
            }
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
            this.Hide();
        }


    
    }
}

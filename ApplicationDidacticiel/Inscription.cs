using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ComponentFactory.Krypton.Toolkit;

namespace ApplicationDidacticiel
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }


        //---------------Validation TextBox Nom + KeyPress Event Nom---------------

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

            lblValidationNom_Click(sender, e);
        }

        private void lblValidationNom_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == string.Empty)
            {
                lblValidationNom.Visible = true;
            }
            else
            {
                lblValidationNom.Visible = false;
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // uniquement des lettres
            string alpha = "azertyuiopqsdfghjklmwxcvbn ïéèàùç" + (char)8;
            if (alpha.IndexOf(char.ToLower(e.KeyChar)) == -1)

            {
                e.KeyChar = (char)0;
            }
        }


        //---------Validation TextBox Prénom + KeyPress Event Prenom---------------------------

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

            lblValidationPrenom_Click(sender, e);
        }

        private void lblValidationPrenom_Click(object sender, EventArgs e)
        {
            if (txtPrenom.Text == string.Empty)
            {
                lblValidationPrenom.Visible = true;
            }
            else
            {
                lblValidationPrenom.Visible = false;
            }
        }


        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // uniquement des lettres
            string alpha = "azertyuiopqsdfghjklmwxcvbn -ïéèàùç" + (char)8;
            if (alpha.IndexOf(char.ToLower(e.KeyChar)) == -1)

            {
                e.KeyChar = (char)0;
            }
        }

        //---------------Validation TextBox Login + KeyPress Event Login---------------------------


        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            lblValidationLogin_Click(sender, e);
        }

        private void lblValidationLogin_Click(object sender, EventArgs e)
        {

            if (File.Exists(Personne.fichier))
            {
                if (txtLogin.Text.Length >= 6)
                {
                    Personne.listeIdentifiantPersonne.Clear();
                    Personne.LectureFichier(Personne.fichier);
                    foreach (Personne personneDansListe in Personne.listeIdentifiantPersonne)
                    {
                        if (txtLogin.Text == personneDansListe.Login)
                        {
                            lblValidationLogin.Text = "      Login existant.";
                            lblValidationLogin.Visible = true;
                            break;
                        }
                        else
                            lblValidationLogin.Visible = false;
                    }
                }
                else
                {
                    lblValidationLogin.Visible = true;
                    lblValidationLogin.Text = "      Le login doit comporter au minimum 6 caractères.";
                }
            }

            else
            {
                if (txtLogin.Text.Length >= 6)
                    lblValidationLogin.Visible = false;

                else
                {
                    lblValidationLogin.Visible = true;
                    lblValidationLogin.Text = "      Le login doit comporter au minimum 6 caractères.";
                }
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.KeyChar = (char)0;
            }
        }


        //------------------------Validation TextBox Mot de Passe + CheckBox Mot de Passe-----------------------------


        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {
            checkBoxAfficherMotDePasse_CheckedChanged(sender, e);
            lblValidationMotDePasse_Click(sender, e);
            lblValidationConfirmerMotDePasse_Click(sender, e);
        }

        private void checkBoxAfficherMotDePasse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAfficherMotDePasse.Checked == true)
                txtMotDePasse.PasswordChar = '*';

            else
                txtMotDePasse.PasswordChar = (char)0;
        }

        private void lblValidationMotDePasse_Click(object sender, EventArgs e)
        {
            string chiffres = "0123456789";
            string caracteresSpeciaux = @"!\#$%&'()*+,-./:;<="">?@[\]^_`{| }~";
            bool verificationChiffre = false;
            bool verificationCaractereSpecial = false;

            if (txtMotDePasse.Text.Length >= 6)
            {
                for (int i = 0; i < txtMotDePasse.Text.Length; i++)
                {
                    if (chiffres.IndexOf(txtMotDePasse.Text[i]) != -1)
                    {
                        verificationChiffre = true;
                        break;
                    }
                    else
                        verificationChiffre = false;
                }

                for (int i = 0; i < txtMotDePasse.Text.Length; i++)
                {
                    if (caracteresSpeciaux.IndexOf(txtMotDePasse.Text[i]) != -1)
                    {
                        verificationCaractereSpecial = true;
                        break;
                    }
                    else
                        verificationCaractereSpecial = false;
                }

                if (verificationCaractereSpecial == true && verificationChiffre == true)
                {
                    lblValidationMotDePasse.Visible = false;
                }
                else
                {
                    lblValidationMotDePasse.Visible = true;
                    lblValidationMotDePasse.Text = "      Le mot de passe doit contenir au" + Environment.NewLine +
                            "      minimum 6 caractères, 1 lettre et 1 caractère spécial.";
                }
            }

            else
            {
                lblValidationMotDePasse.Visible = true;
                lblValidationMotDePasse.Text = "      Le mot de passe doit contenir au" + Environment.NewLine +
                            "      minimum 6 caractères, 1 lettre et 1 caractère spécial.";
            }
        }


        //---------------------Validation TextBox Confirmer Mot de Passe + CheckBox Confirmer ...------------------------------

        private void txtConfirmerMotDePasse_TextChanged(object sender, EventArgs e)
        {
            checkBoxAfficherConfirmerMotDePasse_CheckedChanged(sender, e);
            lblValidationConfirmerMotDePasse_Click(sender, e);
            lblValidationMotDePasse_Click(sender, e);
        }

        private void lblValidationConfirmerMotDePasse_Click(object sender, EventArgs e)
        {
            if (txtConfirmerMotDePasse.Text == txtMotDePasse.Text)
                lblValidationConfirmerMotDePasse.Visible = false;

            else
                lblValidationConfirmerMotDePasse.Visible = true;
        }

        private void checkBoxAfficherConfirmerMotDePasse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAfficherConfirmerMotDePasse.Checked == true)
                txtConfirmerMotDePasse.PasswordChar = '*';

            else
                txtConfirmerMotDePasse.PasswordChar = (char)0;
        }

        //------------------Validation Statut--------------------------------------------------------

        private void cmbBoxStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValidationStatut_Click(sender, e);
        }

        private void lblValidationStatut_Click(object sender, EventArgs e)
        {
            if (cmbBoxStatut.SelectedIndex == 0 || cmbBoxStatut.SelectedIndex == 1)
            {
                lblValidationStatut.Visible = false;
            }
            else
                lblValidationStatut.Visible = true;
        }

        //--------------------Inscription---------------------------------
        private void btnInscription_Click(object sender, EventArgs e)
        {
            Personne personne = new Personne();

            // Test de validation d'ensemble

            if (lblValidationNom.Visible == false && lblValidationPrenom.Visible == false && lblValidationLogin.Visible == false &&
                lblValidationMotDePasse.Visible == false && lblValidationConfirmerMotDePasse.Visible == false && lblValidationStatut.Visible == false)
            {
                Personne.listeIdentifiantPersonne.Clear();

                personne.Nom = txtNom.Text;
                personne.Prenom = txtPrenom.Text;
                personne.Login = txtLogin.Text;
                personne.MotDePasse = txtMotDePasse.Text;
                personne.Statut = cmbBoxStatut.SelectedItem.ToString();

                Personne.AjoutDansListe(personne);
                Personne.EcritureFichier(Personne.fichier);


                Accueil accueil = new Accueil();
                accueil.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Vérifiez vos champs.");

        }

        //--------------------Retour Accueil-------------------------------------
        private void lblMeConnecter_LinkClicked(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Hide();
        }       
    }
}

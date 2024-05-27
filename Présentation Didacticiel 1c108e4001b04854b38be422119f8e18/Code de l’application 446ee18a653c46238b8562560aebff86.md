# Code de l’application

# Application

Le code de l’application sera présenté par formulaire

## Formulaire ‘Accueil’

![Untitled](Code%20de%20l%E2%80%99application%20446ee18a653c46238b8562560aebff86/Untitled.png)

```csharp
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
```

- Vérification
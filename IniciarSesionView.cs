using Firebase.Auth.Providers;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotiseriaDes.View.Login
{
    public partial class IniciarSesionView : Form
    {
        FirebaseAuthClient firebaseAuthClient;
        public bool loginSuccessfull { get; set; } = false;


        public IniciarSesionView()
        {
            InitializeComponent();
            ConfiguracionFirebase();
            txtContraseña.PasswordChar = '*'; // Oculta la contraseña al inicio

        }

        private void ConfiguracionFirebase()
        {

            // Configure...
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyCOqj-gg_eys33eeFYljRo7PMdj71-zZo4",
                AuthDomain = "institutooauth.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    // Add and configure individual providers
                    new EmailProvider()
                    // ...
                },

            };

            // ...and create your FirebaseAuthClient
            firebaseAuthClient = new FirebaseAuthClient(config);
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            firebaseAuthClient.SignInWithEmailAndPasswordAsync(txtEmail.Text, txtContraseña.Text).ContinueWith(task =>
            {
                if (task.IsFaulted)
                {
                    MessageBox.Show("Email o contraseña incorrecto, intentelo nuevamente");
                }
                else
                {
                    loginSuccessfull = true;
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show("Inicio de sesión exitoso"); // Mensaje de éxito
                        this.Close();
                    }));
                }
            });
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkContra_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = checkContra.Checked ? '\0' : '*';

        }
    }
}

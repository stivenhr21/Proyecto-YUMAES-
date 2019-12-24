using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CadenaConexion;

namespace InventarioYumaes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public static string codigo ="";


        private void Button1_Click(object sender, EventArgs e)
        {
          try
            {
                string CMD = string.Format("select * from Usuarios where cuenta='{0}' AND contrasenia='{1}'", txtcuenta.Text.Trim(),txtcontrasenia.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);
                codigo = ds.Tables[0].Rows[0]["Id_usuario"].ToString().Trim();
                string cuenta = ds.Tables[0].Rows[0]["cuenta"].ToString().Trim();
                string contrasenia = ds.Tables[0].Rows[0]["contrasenia"].ToString().Trim();

                if (cuenta==txtcuenta.Text.Trim() && contrasenia==txtcontrasenia.Text.Trim())
                {
                   if (Convert.ToBoolean(ds.Tables[0].Rows[0]["status_Admin"])== true)
                    {
                        Administrador admin = new Administrador();
                        this.Hide();
                        admin.Show();
                    }
                   else
                    {
                        Usuario usua = new Usuario();
                        this.Hide();
                        usua.Show();
                    }
                }
               


            }
            catch(Exception error)
            {
                MessageBox.Show("Usuario o contraseña incorrecta!...");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnsalirL_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea salir?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

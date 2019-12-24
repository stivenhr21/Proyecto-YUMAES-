using System;
using System.Data;
using System.Windows.Forms;
using CadenaConexion;

namespace InventarioYumaes
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            string cmd = "select * from Usuarios where Id_usuario=" + Login.codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);
            lblnomadministrador.Text = DS.Tables[0].Rows[0]["Usuario"].ToString();
            lblusadministrador.Text = DS.Tables[0].Rows[0]["cuenta"].ToString();
            lblcodigoadmin.Text = DS.Tables[0].Rows[0]["Id_usuario"].ToString();
        }

        private void BtnsalirA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal conp = new ContenedorPrincipal();
            this.Hide();
            conp.Show();
        }

        private void Lblnomadministrador_Click(object sender, EventArgs e)
        {

        }
    }
}

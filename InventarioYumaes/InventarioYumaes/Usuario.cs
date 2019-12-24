using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadenaConexion;


namespace InventarioYumaes
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            string cmd = "select * from Usuarios where Id_usuario=" + Login.codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);
            lblnomusuario.Text = DS.Tables[0].Rows[0]["Usuario"].ToString();
            lblusuario.Text = DS.Tables[0].Rows[0]["cuenta"].ToString();
            lblcodigo.Text = DS.Tables[0].Rows[0]["Id_usuario"].ToString();
        }

        private void BtnsalirU_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

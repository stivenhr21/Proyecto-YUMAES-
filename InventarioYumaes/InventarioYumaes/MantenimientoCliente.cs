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
    public partial class MantenimientoCliente : Form
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private void Btnsalirmc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btnguardarmc_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1)==false)
            {
                try
                {
                    string cmd = string.Format("exec ActualizarClientes '{0}','{1}','{2}','{3}'", txtid_cliente.Text.Trim(), txtnombrecli.Text.Trim(), txttelefono.Text.Trim(), txtdireccion.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("se ha guardado correctamente!...");
                    txtid_cliente.Clear();
                    txtnombrecli.Clear();
                    txttelefono.Clear();
                    txtdireccion.Clear();
                }
                catch (Exception error)
                {
                    MessageBox.Show("ha ocurrido un error: " + error.Message);
                }
            }
        }

        private void Btneliminarmc_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("exec EliminarClientes '{0}'", txtid_cliente.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha eliminado correctamente!...");
                txtid_cliente.Clear();

            }
            catch (Exception error)
            {
                MessageBox.Show("ha ocurrido un error: " + error.Message);
            }
        }

        private void Txtid_cliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {

        }

        
    }
}

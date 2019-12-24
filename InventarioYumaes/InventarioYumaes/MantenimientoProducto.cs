using System;
using System.Windows.Forms;
using CadenaConexion;

namespace InventarioYumaes
{
    public partial class MantenimientoProducto : Form
    {
        public MantenimientoProducto()
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

        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {

        }

        private void Btnguardarmc_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("exec ActualizarProductos '{0}','{1}','{2}'", txtcodigo.Text.Trim(), txtnombrepro.Text.Trim(), txtprecio.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("se ha guardado correctamente!...");
                    txtcodigo.Clear();
                    txtnombrepro.Clear();
                    txtprecio.Clear();
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
                string cmd = string.Format("exec EliminarProducto '{0}'", txtcodigo.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha eliminado correctamente!...");
                txtcodigo.Clear();
            }
            catch(Exception error)
            {
                MessageBox.Show("ha ocurrido un error: " + error.Message);
            }
        }

        private void Txtcodigo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}

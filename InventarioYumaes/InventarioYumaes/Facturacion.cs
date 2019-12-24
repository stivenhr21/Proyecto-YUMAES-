using System;
using System.Data;
using System.Windows.Forms;
using CadenaConexion;

namespace InventarioYumaes
{
    public partial class nuevo : Form
    {
        public nuevo()
        {
            InitializeComponent();
        }

        public static int cont_fila = 0;
        public static double Total;
        private void Button1_Click(object sender, EventArgs e)
        {
            if(Utilidades.ValidarFormulario(this,errorProvider1)==false)
            {
                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    dataGridView1.Rows.Add(txtCodigoPro.Text,txtDescripcion.Text,txtPrecio.Text,txtCantidad.Text);
                    double Importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                    dataGridView1.Rows[cont_fila].Cells[4].Value = Importe;
                    cont_fila++;
                }
                else
                {
                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == txtCodigoPro.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }
                    if(existe == true)
                    {
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value)  * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);
                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodigoPro.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                        double Importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                        dataGridView1.Rows[cont_fila].Cells[4].Value = Importe;
                        cont_fila++;
                    }

                }

                Total = 0;
                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    Total += Convert.ToDouble(Fila.Cells[4].Value);
                }
                lblTotal.Text = "RD$" + Total.ToString();

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "select * from Usuarios where Id_usuario =" + Login.codigo;
            DataSet ds;
            ds = Utilidades.Ejecutar(cmd);
            lblAtiende.Text = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCodigoCli.Text.Trim()) == false)
            {
                try
                {
                    string cmd = string.Format("select Nombre from Cliente where id_cliente ='{0}'", txtCodigoCli.Text.Trim());

                    DataSet ds = Utilidades.Ejecutar(cmd);
                    txtCliente.Text = ds.Tables[0].Rows[0]["Nombre"].ToString().Trim();
                    txtCodigoPro.Focus();
                }
                catch (Exception error )
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
              
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                Total = Total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lblTotal.Text = "RD$" + Total.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                cont_fila--;
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ConsultarClientes ConCli = new ConsultarClientes();
            ConCli.ShowDialog();

            if(ConCli.DialogResult == DialogResult.OK)
            {
                txtCodigoCli.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                txtCodigoPro.Focus();
            }
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConPro = new ConsultarProductos();
            ConPro.ShowDialog();

            if (ConPro.DialogResult == DialogResult.OK)
            {
                txtCodigoPro.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcion.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtCantidad.Focus();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if(cont_fila != 0)
            {
                try
                {
                    string cmd = string.Format("Exec ActualizarFacturas '{0}'", txtCodigoCli.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    string NumFac = ds.Tables[0].Rows[0]["NumFac"].ToString().Trim();
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        cmd = string.Format("Exec ActualizaDetalles '{0}','{1}','{2}','{3}'", NumFac, fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString(), fila.Cells[3].Value.ToString());
                        ds = Utilidades.Ejecutar(cmd);
                    }

                    cmd = "Exec DatosFactura " + NumFac;
                    ds = Utilidades.Ejecutar(cmd);

                    //Ventana Reporte 

                    Reporte rp = new Reporte();
                    rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    rp.ShowDialog();

                    Nuevo();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }

            }
        }

        private void Nuevo()
        {
            throw new NotImplementedException();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}

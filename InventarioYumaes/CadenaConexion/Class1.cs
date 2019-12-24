using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadenaConexion
{
    public class Utilidades
    {
     public static DataSet Ejecutar(string cmd)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UNRTF24F\SQLEXPRESS;Initial Catalog=FacturaYumaes;Integrated Security=True");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd,con);

            DP.Fill(DS);

            con.Close();

            return DS;
        }
        public static Boolean ValidarFormulario(Control objeto,ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;

            foreach (Control Item in objeto.Controls)
            {
                if (Item is ErrorTxtBox)
                {
                    ErrorTxtBox obj = (ErrorTxtBox)Item;

                    if(obj.Validar==true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(obj, "No puede estar vacio");
                            HayErrores = true;
                        }

                    }
                if(obj.SoloNumeros == true)
                    {
                        int cont = 0, LetrasEncontradas = 0;

                        foreach (char letra in obj.Text.Trim())
                        {
                            if(char.IsLetter(obj.Text.Trim(),cont))
                            {
                                LetrasEncontradas++;
                            }
                            cont++;
                        }
                        if (LetrasEncontradas !=0)
                        {
                            HayErrores = true;
                            ErrorProvider.SetError(obj, "Solo numeros!...");
                        }
                    }


                }
            }
            return HayErrores;
        }
    }
}

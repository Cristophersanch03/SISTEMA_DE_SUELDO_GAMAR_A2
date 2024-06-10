using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_SUELDO_GAMAR_A2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            txt_500porhijo.ReadOnly = true;
            txt_descuento_afp.ReadOnly = true;
            txt_descuento_sfs.ReadOnly = true;
            txt_descuento_total.ReadOnly = true;
            txt_sueldoneto.ReadOnly = true;
            txt_sueldomas_incentivo.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_nombre_empleado_TextChanged(object sender, EventArgs e)
        {

            string nombre_del_empleado = new string(txt_nombre_empleado.Text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray());

            if (txt_nombre_empleado.Text != nombre_del_empleado)
            {
                MessageBox.Show("Por favor, utilice letras solamente.");
                txt_nombre_empleado.Text = nombre_del_empleado;
                txt_nombre_empleado.SelectionStart = txt_nombre_empleado.Text.Length;
            }
        }

        private void txt_sueldo_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txt_sueldo.Text, "[^0-9,]"))
            {
                MessageBox.Show("Por favor, ingrese solo números y comas (,) si lo desea.");
                txt_sueldo.Text = txt_sueldo.Text.Remove(txt_sueldo.Text.Length - 1);
            }
        }

        private void txt_cantidad_hijos_TextChanged(object sender, EventArgs e)
        {

           
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_cantidad_hijos.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, ingrese solo números.");
                txt_cantidad_hijos.Text = txt_cantidad_hijos.Text.Remove(txt_cantidad_hijos.Text.Length - 1);
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try

            {        
         
                if (string.IsNullOrWhiteSpace(txt_sueldo.Text) || (string.IsNullOrWhiteSpace(txt_nombre_empleado.Text)))
               
                    {
                    MessageBox.Show("Por favor, ingrese todos los datos necesarios.");
                    return;
                }
      
                {      
                    if (string.IsNullOrWhiteSpace(txt_cantidad_hijos.Text))
                    {
                        MessageBox.Show("Por favor, ingrese el número de hijos. Si no tiene hijos, ingrese el número 0.");
                        return;
                    }         
                    double sueldo = double.Parse(txt_sueldo.Text);
                    int cantidadHijos = int.Parse(txt_cantidad_hijos.Text);

                    double incentivo = cantidadHijos * 500;
                    double sueldomas_incentivo = incentivo + sueldo;
                    double descuentoAFP = sueldomas_incentivo * 0.0287;
                    double descuentoSFS = sueldomas_incentivo * 0.0304;
                    double totalDescuentos = descuentoAFP + descuentoSFS;
                    double sueldoNeto = sueldomas_incentivo - totalDescuentos;

                    txt_500porhijo.Text = incentivo.ToString("F2");
                    txt_sueldomas_incentivo.Text = sueldomas_incentivo.ToString("F2");
                    txt_descuento_afp.Text = descuentoAFP.ToString("F2");
                    txt_descuento_sfs.Text = descuentoSFS.ToString("F2");
                    txt_descuento_total.Text = totalDescuentos.ToString("F2");
                    txt_sueldoneto.Text = sueldoNeto.ToString("F2");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message);
            }
        }
        private void txt_500porhijo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descuento_afp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descuento_sfs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descuento_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sueldoneto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sueldomas_incentivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
   
            if (string.IsNullOrWhiteSpace(txt_nombre_empleado.Text) &&
                string.IsNullOrWhiteSpace(txt_sueldo.Text) &&
                string.IsNullOrWhiteSpace(txt_cantidad_hijos.Text) &&
                string.IsNullOrWhiteSpace(txt_500porhijo.Text) &&
                    string.IsNullOrWhiteSpace(txt_sueldomas_incentivo.Text) &&
                string.IsNullOrWhiteSpace(txt_descuento_afp.Text) &&
                string.IsNullOrWhiteSpace(txt_descuento_sfs.Text) &&
                string.IsNullOrWhiteSpace(txt_descuento_total.Text) &&
             
                string.IsNullOrWhiteSpace(txt_sueldoneto.Text))
            {
                MessageBox.Show("No hay datos para limpiar.");
                return;
            }
           
            txt_nombre_empleado.Text = "";
            txt_sueldo.Text = "";
            txt_cantidad_hijos.Text = "";
            txt_500porhijo.Text = "";
            txt_sueldomas_incentivo.Text = "";
            txt_descuento_afp.Text = "";
            txt_descuento_sfs.Text = "";
            txt_descuento_total.Text = "";
            txt_sueldoneto.Text = "";
         
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}

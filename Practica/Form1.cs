
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        double precio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblFecha.Text = DateTime.Now.ToString("D");
            lblPrecio.Text = (0).ToString("c");


        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cbProducto.Text;
            if (producto.Equals("Pan")) precio = 12 ;
            if (producto.Equals("Queso")) precio = 40;
            if (producto.Equals("Leche")) precio = 17;

            lblPrecio.Text = precio.ToString("c");


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(cbtipodepago.SelectedIndex == null)
            
                MessageBox.Show("Porfavor Seleccionar un metodo de pago");
            else if(cbProducto.SelectedIndex == null)
            
                MessageBox.Show("Porfavor Seleccionar un Producto");
            else if (txtCantidad.Text == " ")
            
                MessageBox.Show("Porfavor Ingrese una cantidad");
            else {  

                string productos = cbProducto.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipodepago = cbtipodepago.Text;

                ////////////////////////////////////////////

                double subtotal = cantidad * precio;

                double descuento = 0;
                double recargo = 0;

                if (tipodepago.Equals("Contado"))
                    descuento = 0.05 * subtotal;
                
                else
                
                    recargo = 0.1 * subtotal;
                

                double PrecioFinal = subtotal + descuento + recargo;


                ListViewItem fila = new ListViewItem(productos);


                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipodepago);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(precio.ToString());


                lvVentas.Items.Add(fila);

                button1_Click(sender, e);

            }
    }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

using Prueba_net_2_.Modelo;
using Prueba_net_2_.Vista;
using System;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Prueba_net_2.Vista
{

    /*PizzeriaDbEntities*/
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }


        /* ----- Boton Agregar Pedido ----- */
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            AgregarPedido();
            CalcularPedido();
            
        }

            private void CalcularPedido()
            {
            
            int calcular  = Convert.ToInt32(lblTotalAgregado.Text);

                if ((checkPizzaIndividual.Checked && checkPizzaMediana.Checked)
                    || (checkPizzaIndividual.Checked && checkPizzaFamiliar.Checked)
                    || (checkPizzaMediana.Checked && checkPizzaFamiliar.Checked))

                {
                    MessageBox.Show("Solo debe ingresar 1 pizza");
                }
                else
                {
                    MessageBox.Show("Se ha realizado su solicitud");
                }
                if (checkPizzaIndividual.Checked == true)
                {
                    calcular = calcular + 8000;
                }
                if (checkPizzaMediana.Checked == true)
                {
                    calcular = calcular + 12000;
                }
                if (checkPizzaFamiliar.Checked == true)
                {
                    calcular = calcular + 22000;
                }
                if (checkBebidaIndividual.Checked == true)
                {
                    calcular = calcular + 1500;
                }
                if (checkBebidaFamiliar.Checked == true)
                {
                    calcular = calcular + 5000;
                }
                lblTotalAgregado.Text = calcular.ToString();
            }
        /* ----- Check Pizzas ----- */
        private void checkPizzaIndividual_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPedido();
        }

        private void checkPizzaMediana_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPedido();
        }

        private void checkPizzaFamiliar_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPedido();
        }

        /* ----- Fin Check Pizzas ----- */

        /* ----- Check Bebidas ----- */

        private void checkBebidaIndividual_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPedido();
        }

        private void checkBebidaFamiliar_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPedido();
        }
        /* ----- Fin Check Bebidas ----- */


        /* ----- Boton Cerrar Caja ----- */

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {

            Registro registro = new Registro();
            MessageBox.Show("El Total es :" + registro.SumaTotal());
            Login login = new Login();
            registro.Show();
            this.Hide();
        }

        /* ----- Fin Boton Cerrar Caja -----*/


        private void AgregarPedido()
        {
            using (Prueba_net_2_.Modelo.PizzeriaDbEntities bd = new Prueba_net_2_.Modelo.PizzeriaDbEntities())
            {
                Producto producto = new Producto();
                producto.id = Contador();
                producto.nombre = NombreProducto();
                producto.precio = PrecioProducto();
                producto.cantidad = CantidadProducto();


                bd.Producto.Add(producto);
                bd.SaveChanges();

            }

        }

        private int Contador()
        {
            using (Prueba_net_2_.Modelo.PizzeriaDbEntities bd = new Prueba_net_2_.Modelo.PizzeriaDbEntities())
            {
                int LastRecord = (from c in bd.Producto orderby c.id descending select c.id).Count();
                return LastRecord;
            }
        }

        private string NombreProducto()
        {

        }

        private int PrecioProducto()
        {

        }
        private int CantidadProducto()
            {

            }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }
    }
    }
} 

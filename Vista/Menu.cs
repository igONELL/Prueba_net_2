using Prueba_net_2_;
using Prueba_net_2_.Modelo;
using Prueba_net_2_.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_net_2.Vista
{

    /*PizzeriaDbEntities*/
    public partial class Menu : Form
    {
        private int id, cantidad;
        private float precio;
        private string nombre;

        public Menu()
        {
            InitializeComponent();
        }


        /* ----- Check Pizzas ----- */
        private void checkPizzaIndividual_CheckedChanged(object sender, EventArgs e)
        {
            bool pizzaInd = checkPizzaIndividual.Checked;
        }
        private void checkPizzaMediana_CheckedChanged(object sender, EventArgs e)
        {
            bool pizzaMed = checkPizzaMediana.Checked;
        }
        private void checkPizzaFamiliar_CheckedChanged(object sender, EventArgs e)
        {
            bool pizzaFam = checkPizzaFamiliar.Checked;
        }
        /* ----- Fin Check Pizzas ----- */


        /* ----- Check Bebidas ----- */
        private void checkBebidaIndividual_CheckedChanged(object sender, EventArgs e)
        {
            bool bebidaInd = checkBebidaIndividual.Checked;
        }

        private void checkBebidaFamiliar_CheckedChanged(object sender, EventArgs e)
        {
            bool bebidaFam = checkBebidaFamiliar.Checked;
        }
        /* ----- Fin Check Bebidas ----- */


        /* ----- Boton Agregar Pedido ----- */
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {   
            /* ----- Pizza ----- */
            lblTotalPedido.Text = checkPizzaIndividual.Checked.ToString();
            lblTotalPedido.Text = checkPizzaMediana.Checked.ToString();
            lblTotalPedido.Text = checkPizzaFamiliar.Checked.ToString();
            /* ----- Fin Pizza -----*/

            /* ----- Bebida ----- */
            lblTotalPedido.Text = checkBebidaIndividual.Checked.ToString();
            lblTotalPedido.Text = checkBebidaFamiliar.Checked.ToString();
            /* ----- Fin Bebida -----*/
            
            if ((checkPizzaIndividual.Checked && checkPizzaMediana.Checked)
                || (checkPizzaIndividual.Checked && checkPizzaFamiliar.Checked)
                || (checkPizzaMediana.Checked && checkPizzaFamiliar.Checked))

            {
                MessageBox.Show("Puedes elegir solo 1 pizza");
            }
            else
            {
                MessageBox.Show("Se ha realizado su solicitud");
            }
        }
        /* ----- Fin Agregar Pedido ----- */

        /* ----- Boton Caja ----- */
        
        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {

        }

        /* ----- Fin Boton Caja -----*/


        /* private void AgregarPedido()
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

         }*/

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();

        }
       private int Contador()
        {
            using (Prueba_net_2_.Modelo.PizzeriaDbEntities bd = new Prueba_net_2_.Modelo.PizzeriaDbEntities())
            {
                int LastRecord = (from c in bd.Producto orderby c.id descending select c.id).Count();
                return LastRecord;
            }
        }
        /*private string NombreProducto()
        {

        }

        private float PrecioProducto()
        {
            
        }

        private int CantidadProducto()
        {

        }*/
    }
}

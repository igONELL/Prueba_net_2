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
            int calcular = 0;

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
            Login login = new Login();
            registro.Show();
            this.Hide();
        }

        /* ----- Fin Boton Cerrar Caja -----*/


        private void AgregarPedido()
        {
            if (((checkPizzaIndividual.Checked && checkPizzaMediana.Checked)
                || (checkPizzaIndividual.Checked && checkPizzaFamiliar.Checked)
                || (checkPizzaMediana.Checked && checkPizzaFamiliar.Checked)))
            {

            }
            else { 
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
            if (checkPizzaIndividual.Checked == true)
            {
                return "Pizza individual";
            }
            
            else if ( checkPizzaMediana.Checked == true)
            {
                return "Pizza mediana";
            }
            else if (checkPizzaFamiliar.Checked == true)
            {
                return "Pizza familiar";
            }
            else if (checkBebidaIndividual.Checked == true)
            {
                return "Bebida Individual";
            }
            else if (checkBebidaFamiliar.Checked == true)
            {
                return "Bebida familiar";
            }
            else
            {
               return "0";
            }
        }

        private int PrecioProducto()
        {
            if (checkPizzaIndividual.Checked == true)
            {
                return 8000;
            }
            else if (checkPizzaMediana.Checked == true)
            {
                return 12000;
            }
            else if (checkPizzaFamiliar.Checked == true)
            {
                return 22000;
            }
            else
            {
                return 0;
            }
        }
        private int CantidadProducto()
        {
            if (((checkPizzaIndividual.Checked == true) && (checkBebidaIndividual.Checked == true)
                && (checkPizzaFamiliar.Checked == true)) || ((checkPizzaMediana.Checked == true)
                && (checkBebidaIndividual.Checked == true) && (checkPizzaFamiliar.Checked == true)) ||
                ((checkPizzaFamiliar.Checked == true) && (checkBebidaIndividual.Checked == true)
                && (checkPizzaFamiliar.Checked == true)))
            {
                return 3;
            }

            else if (((checkPizzaIndividual.Checked == true) && (checkBebidaIndividual.Checked == true))
                || ((checkPizzaMediana.Checked == true) && (checkBebidaIndividual.Checked == true))
                || ((checkPizzaFamiliar.Checked == true) && (checkBebidaIndividual.Checked == true))
                || ((checkPizzaIndividual.Checked == true) && (checkBebidaFamiliar.Checked == true))
                || ((checkPizzaMediana.Checked == true) && (checkBebidaFamiliar.Checked == true))
                || ((checkPizzaFamiliar.Checked == true) && (checkBebidaFamiliar.Checked == true)))
            {
                return 2;
            }
            else if ((checkPizzaIndividual.Checked == true) || (checkPizzaMediana.Checked == true) 
                || ((checkPizzaFamiliar.Checked == true) || (checkBebidaIndividual.Checked == true))
                || (checkBebidaFamiliar.Checked == true))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        } 

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }
    }
    }
 

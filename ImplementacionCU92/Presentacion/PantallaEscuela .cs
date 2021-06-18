using ImplementacionCU92.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementacionCU92.Presentacion
{
    public partial class PantallaEscuela : Form
    {


        private GestorRegistroReservaVisitaGuiada gestor;



        public PantallaEscuela()
        {
            InitializeComponent();
            gestor = new GestorRegistroReservaVisitaGuiada();


        }

     


        public void tomarOpcionRegReservaVisita(Form pantalla)
        {
            pantalla.Show();

            gestor.tomarOpcionRegReservaVisita(pantalla);
        }


        public void mostrarEscuelas(string[] nombres)
        {

            for (int i = 0; i < nombres.Length; i++)
            {
                cmbEscuela.Items.Add(nombres[i]);
                
            }

        }
        public void tomarSeleccionEscuela(string nomEscuela)
        {
            gestor.tomarEscuela(nomEscuela);

        }
       public void solicitarCantidadVisitantes()
        {
            lblCantidad.Visible = true;
            txtCantidadVisitantes.Visible = true;
            btnConfirmarVisitantes.Visible = true;

        }

        public void mostrarSedes(string[] nombreSedes)
        {
            lblSede.Visible = true;
            cmbSede.Visible = true;

            for (int i = 0; i < nombreSedes.Length; i++)
            {
                cmbSede.Items.Add(nombreSedes[i]);

            }

        }



        public void tomarCantidadVisitantes()
        {
            gestor.tomarCantidadVisitantes(int.Parse(txtCantidadVisitantes.Text));

        }
        private void cmbEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {

            tomarSeleccionEscuela(cmbEscuela.SelectedItem.ToString());
           solicitarCantidadVisitantes();
            
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }



        private void btnConfirmarVisitantes_Click(object sender, EventArgs e)
        {

            tomarCantidadVisitantes();
        }

        private void cmbSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            tomarSeleccionSede();
        }


        public void tomarSeleccionSede()
        {
            gestor.tomarSede(cmbEscuela.SelectedItem.ToString());

        }

      public void  mostrarTiposVisita(string[] nombreTipoVisita)
        {

            cmbTipoVisita.Visible = true;
            lblTipoVisita.Visible = true;

           for (int i = 0; i < nombreTipoVisita.Length; i++)
            {
                cmbTipoVisita.Items.Add(nombreTipoVisita[i]);

            }
        }

        private void cmbTipoVisita_SelectedIndexChanged(object sender, EventArgs e)
        {
            tomarSeleccionTipoVisita();
        }
       public void tomarSeleccionTipoVisita()
        {
            gestor.tomarTipoVisita(cmbTipoVisita.SelectedItem.ToString());
        }
    }
}

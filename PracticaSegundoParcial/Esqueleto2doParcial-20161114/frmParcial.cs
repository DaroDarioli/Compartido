using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace Esqueleto2doParcial_20161114
{
    public partial class frmParcial : Form
    {
        Empleado e1 = new Empleado("Juan", "Rojas", 4);

        public frmParcial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                e1.Guardar("ArchivoEmpleados.txt", e1.ToString());
            }
            catch
            {
                throw new NoGuardoException("Error al guardar");

            }   
            
            
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string retorno;

            try
            {
                e1.Leer("ArchivoEmpleados.txt", out retorno);
            }
            catch(Exception a)
            {
                retorno = a.Message;
                throw new NoLeeException("Error al guardar",a);
               
            }

            MessageBox.Show(retorno);
        }
    }
}

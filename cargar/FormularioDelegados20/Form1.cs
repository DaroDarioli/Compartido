using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDelegados20
{
    public partial class Form1 : Form
    {
        public string textbox;
        //public event DelegadoActualizarNombre ActualizarNombreEvent;
        //FrmDatos frmdatos = new FrmDatos();
        FrmTestDelegados frmtest = new FrmTestDelegados();
        public Form1()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmtest.Show(this);
            this.textbox = frmtest.textBox;          
        }

        private void frmDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                frmtest.frmdatos.Show();


            //frmdatos.Show();
            //ActualizarNombreEvent += frmdatos.ActualizarNombre;
            //ActualizarNombreEvent(textbox);
        }
    }
}

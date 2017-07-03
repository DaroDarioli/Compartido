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
    public partial class FrmTestDelegados : Form
    {
        public event DelegadoActualizarNombre ActualizarNombreEvent;
        public FrmDatos frmdatos;

        public string textBox;

        public FrmTestDelegados()
        {
            InitializeComponent();
             this.frmdatos = new FrmDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox == null)
            {              
                frmdatos.Show();
            }
            textBox = textBox1.Text;                 

            ActualizarNombreEvent += frmdatos.ActualizarNombre;
            ActualizarNombreEvent(textBox);
        }
    }
}

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
    public partial class FrmDatos : Form
    {
       
        public FrmDatos()
        {
            InitializeComponent();        
        }

        public void ActualizarNombre(string a)
        {

            try
            {
                //                label1.Text = ((FrmTestDelegados)o).textBox;
                label1.Text = a;
            }
            catch(Exception c)
            {
                MessageBox.Show(c.Message);
            }

        }
    }
}

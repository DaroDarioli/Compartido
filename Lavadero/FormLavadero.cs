using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavadero
{
    public partial class FormLavadero : Form
    {
        // List<Vehiculo> nuevaLista = new List<Vehiculo>();
        public string lista;

        public FormLavadero()
        {
            InitializeComponent();
        }

        public FormLavadero(string _listProductos): this ()
        {
            lista = _listProductos;
            richTextBox1.AppendText(lista);
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(lista);
            //foreach (Vehiculo t in nuevaLista)
            //{
            //    richTextBox1.AppendText(t.ToString());
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //nuevaLista.Sort(Lavadero1.OrdenarVehiculosPorPatente);


            //foreach (Vehiculo t in nuevaLista)
            //{
            //    richTextBox1.AppendText(t.ToString());
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}






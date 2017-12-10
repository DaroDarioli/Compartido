using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial
{
    delegate void CargarRichTextBoxCallback(string datos);
    public delegate void CargarBase(List<Base> lista);
    public delegate Queue<Base> TraerLista();

    public partial class FRMPrincipal : Form
    {

        List<Base> listaElementos;

        public CargarBase CargarBaseEvent;
        

        public FRMPrincipal()
        {
            InitializeComponent();
            this.Text = "Sabado";
            this.listaElementos = new List<Base>();
           
        }

        private void btnPunto1_Click(object sender, EventArgs e)
        {
            Base derUno1 = new DerivadaUno(10, 11, 12);
            DerivadaUno derUno2 = new DerivadaUno(1, 2, 3);
            Base derDos1 = new DerivadaDos();

            listaElementos.Add(derUno1);
            listaElementos.Add(derUno2);
            listaElementos.Add(derDos1);

            StringBuilder sb = new StringBuilder();
            foreach(Base b in listaElementos)
            {
                sb.AppendLine(b.VersionFull);
            }
            CargarRichTextBox(sb.ToString());


        }

        private void btnPunto2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sólo para quienes recuperan");
        }

        private void btnPunto3_Click(object sender, EventArgs e)
        {
            CargarBaseEvent = Base.EjecutarEvento;
            CargarBaseEvent(listaElementos);
            

        }

        private void btnPunto4_Click(object sender, EventArgs e)
        {

            //Thread hilo = new Thread(Base.EjecutarEvento);
            //hilo.Start(listaElementos);


        }

        private void btnPunto5_Click(object sender, EventArgs e)
        {

        }

        public void CargarRichTextBox(string datos)
        {

            if (rtbTextoSalida.InvokeRequired)
            {
                CargarRichTextBoxCallback d = new CargarRichTextBoxCallback(CargarRichTextBox);
                this.Invoke(d, new object[] { datos });
            }
            else
            {
                rtbTextoSalida.AppendText(datos);

            }


             
            
        }

       

    }
}

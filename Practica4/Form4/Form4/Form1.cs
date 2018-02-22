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
using EntidadesPP;

namespace Form4
{
    public delegate void CargarRichTextBoxCallback(string datos);

    public partial class Form1 : Form
    {
        public event CargarRichTextBoxCallback evento;
        public List<Base> listaElementos;

        public Form1()
        {
            InitializeComponent();
            this.Name = "Practica Daro";
            this.btnPunto1.Click += ClickPuntoUno;
            this.btnPunto2.Click += ClickSegundoPunto;
        }

        public void ClickSegundoPunto(object o, EventArgs e)
        {
            MessageBox.Show("Para primer parcial", "!!");
        }

        public void ClickPuntoUno(object o, EventArgs e)
        {
            Base derUno1 = new DerivadaUno(10, 11, 12);
            DerivadaUno derUno2 = new DerivadaUno(1, 2, 3);
            Base derDos1 = new DerivadaDos();

            listaElementos.Add(derUno1);
            listaElementos.Add(derUno2);
            listaElementos.Add(derDos1);

            StringBuilder sb = new StringBuilder();

            foreach(Base miBase in listaElementos)
            {
                sb.AppendLine(miBase.VersionFull);
            }
            CargarRichTextBox(sb.ToString();         


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
                evento.Invoke();
                // Código del alumno!!!!

            }
        }

    }
}
}

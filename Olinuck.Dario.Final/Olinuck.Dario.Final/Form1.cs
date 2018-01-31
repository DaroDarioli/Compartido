using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

using System.Data.SqlClient;
using System.Threading;

namespace Olinuck.Dario.Final
{
    public partial class Form1 : Form
    {
        private Mascotera<Mascota> _listaMascotas; 

        private SqlConnection _connection;

        private SqlCommand _command;
        
        public Form1()
        {
            InitializeComponent();
            this._listaMascotas = new Mascotera<Mascota>();
            this._connection = new SqlConnection(Properties.Settings.Default.Setting);
            this._command = new SqlCommand();
            this.btn01.Click += new EventHandler(this.CreoMascota);
            this.btn12.Click += new EventHandler(this.CerrarFormulario);
        }

        /// <summary>
        /// Btn01
        /// </summary>
        private void CreoMascota(object sender, EventArgs e)
        {
            Mascota a = new Mascota("Conejo");
            this._listaMascotas += a;
            this.btn02.Click += new EventHandler(this.CreoPerro);
        }     

        /// <summary>
        /// Btn02
        /// </summary>
        private void CreoPerro(object sender, EventArgs e)
        {
            Perro b = new Perro("Spiderman");
            this._listaMascotas += b;
            this.btn03.Click += new EventHandler(this.GuardarBinario);
        }

        /// <summary>
        /// Btn03
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void GuardarBinario(object sender, EventArgs e)
        {                    
            FileStream fs = new FileStream("Mascotas.dat", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try 
            {
                formatter.Serialize(fs, this._listaMascotas[0]);
            }
            catch (Exception error) 
            {
                MessageBox.Show(error.Message);
            }
            finally 
            {
                this.btn04.Click += new EventHandler(this.TraerArchivoBinario);
                fs.Close();
            }
        }        

        /// <summary>
        /// Btn04
        /// </summary>
       private void TraerArchivoBinario(object sender, EventArgs e)
       {
            Mascota aux = new Mascota();          
            FileStream fs = new FileStream("Mascotas.dat", FileMode.Open);
        
            try 
            {
                BinaryFormatter formatter = new BinaryFormatter();                   
                aux = (Mascota)formatter.Deserialize(fs);
                this._listaMascotas += aux;
            }
            catch (SerializationException) 
            {
                MessageBox.Show("No se pudo deserializar");
            }
            finally 
            {
                fs.Close();
                this.btn06.Click += new EventHandler(this.FuncionMostar);
            }
        }
        

        /// <summary>
        /// Btn06
        /// </summary>        
       private void FuncionMostar(object sender, EventArgs e)
       {
           StringBuilder sb = new StringBuilder();
           foreach(Mascota a in this._listaMascotas.Lista)
           {              
               try{
                    sb.AppendLine(a.EmitirSonido());                   
               }
               catch (SinSonidoException error){
                    sb.AppendLine(error.Message);
               }              
           }
            MessageBox.Show(sb.ToString());
           // (Perro)(this.mascotas.Lista[1])handler;
            this.btn07.Click += new EventHandler(this.FuncionQuitarA);
        }
        
        /// <summary>
        /// Btn07
        /// </summary>
        private void FuncionQuitarA(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Mascota a in this._listaMascotas.Lista)
            {
                try{
                    sb.AppendLine(a.EmitirSonido());
                }
                catch (SinSonidoException error){

                    sb.AppendLine(error.Message);
                }
            }
            string resultado = Extensora.QuitarA(sb.ToString());

            MessageBox.Show(resultado);
            this.btn08.Click += new EventHandler(this.FuncionGuardarSQL);
        }

        /// <summary>
        /// Btn08
        /// </summary>
        private void FuncionGuardarSQL(object sender, EventArgs e)
       {
           foreach (Mascota a in this._listaMascotas.Lista)
           {
                try
                {
                    this._command.Connection = this._connection;
                    this._command.CommandType = CommandType.Text;
                    this._command.CommandText = "INSERT into Mascotas (Nombre,patas) VALUES ('" + a.Nombre + "','" + Mascota.Patas + "')";
                    this._connection.Open();
                    this._command.ExecuteNonQuery();
                    this._connection.Close();                  

                }
                catch (Exception error )
                {
                    this._connection.Close();
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    this.btn09.Click += new EventHandler(this.FuncionLeerSQL);
                }
            }
        }

        /// <summary>
        /// Btn09 Traigo Base
        /// </summary>
        private void FuncionLeerSQL(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            this._listaMascotas = new Mascotera<Mascota>();

            try
            {
                this._command.Connection = this._connection;
                this._command.CommandType = CommandType.Text;
                this._command.CommandText = "SELECT * FROM Mascotas";
                this._connection.Open();

                SqlDataReader sr = this._command.ExecuteReader();
                while (sr.Read())
                {
                    this._listaMascotas.Lista.Add(new Mascota(sr[1].ToString()));
                }
                sr.Close();             
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            finally{
                this._connection.Close();
            }
            
        }

        public static void FinLadrido()
        {
            Thread.Sleep(3000);
            MessageBox.Show("terminó");
        }

        /// <summary>
        /// Btn12 Cierro el formulario
        /// </summary>
        private void CerrarFormulario(object sender,EventArgs e)
        {
            this.Close();
        }  

    }
}





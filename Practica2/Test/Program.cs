using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Test
{

    public delegate void EventoClic(object o, EventHandler e);
    class Program
    {
        public EventoClic evento;

        static void Main(string[] args)
        {

            Queue<double> n = new Queue<double>();
            Queue<double> n2 = new Queue<double>();

            Queue<double> muestra = new Queue<double>();

            n.Enqueue(5);
            n.Enqueue(6);
            n.Enqueue(7);

            muestra.Enqueue(7);
            muestra.Enqueue(6);
            muestra.Enqueue(5);

            n2 = Extensora.Invierte(n);

            foreach (double d in n2)
            {
                Console.WriteLine(d);
            }

            foreach (double d in muestra)
            {
                Console.WriteLine(d);
            }
            


            Console.WriteLine(Extensora.EldelMedio(6, 5, 9));

            /*            Console.WriteLine("========1==========");
                        Extensora.CuentaLetras("Avellaneda"); 

                        Queue<double> fila = new Queue<double>();
                        Queue<double> fila2 = new Queue<double>();
                        Queue<double> fila3 = new Queue<double>();

                        fila2 = Extensora.Carga(fila);

                        Console.WriteLine("==================");
                        foreach(double d in fila2)
                        {
                            Console.WriteLine(d);
                        }
                        Console.WriteLine("=======Invierto==========");
                        fila3 = Extensora.Invierte(fila2);

                        foreach (double d in fila3)
                        {
                            Console.WriteLine(d);
                        }

                        Console.WriteLine("=========3=========");

                        Console.WriteLine(Extensora.EldelMedio(6, 5, 9));


                        Console.WriteLine("=========4=========");

                        Producto p1 = new Producto("Naranjas", 2);
                        Producto p2 = new Producto("Peras", 4);

                        Deposito<Producto> DepositoUno = new Deposito<Producto>();

                        DepositoUno += p1;
                        DepositoUno += p2;

                        Producto p3 = new Producto("Peras", 2);
                        Producto p4 = new Producto("Manzanas", 2);
                        Producto p5 = new Producto("Cerezas", 3);

                        Deposito<Producto> DepositoDos = new Deposito<Producto>();

                        DepositoDos += p3;
                        DepositoDos += p4;

                        try
                        {
                            DepositoDos += p5;
                        }
                        catch(DepositoCompletoException error)
                        {
                            Console.WriteLine(error.Message);
                        }

                        Console.WriteLine("=========7=========");


                        Producto pro = new Producto("lechuga", 22);
                        ProdImpuesto pI = new ProdImpuesto(pro.Nombre, pro.Stock, 600.33);
                        ProdExport pEX = new ProdExport(pI, "Argentina");
                        ProdVendido p = new ProdVendido(pEX, "Cliente Juan");  */

           /* Console.WriteLine("=========8=========");

            Program pr = new Program();

            Galpon gal = new Galpon();
            Form1 from = new Form1();
           
            gal.impar += from.TrataEsImpar;
            from.button1.Click += pr.RealizaTarea;
;
            from.ShowDialog();*/

           

            
                        

            Console.ReadLine();
        }


        public void RealizaTarea(object o, EventArgs e)
        {

        }


    }

   
}

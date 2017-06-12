using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Empleado e1 = new Empleado("Pedro", "Rojas", 4);
            try
            {
                e1.Guardar("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", e1.ToString());
            }
            catch
            {
                throw new NoGuardoException("Error al guardar");

            }

        }

        [TestMethod]
        public void TestMethod2()
        {
            Empleado e2 = new Empleado("Juan", "Rojas", 4);
            try
            {
                e2.Guardar("ArchivoEmpleados.txt", e2.ToString());
            }
            catch
            {
                throw new NoGuardoException("Error al guardar");

            }     

        
            string retorno;

            try
            {
                e2.Leer("ArchivoEmpleados.txt", out retorno);
            }
            catch (Exception a)
            {
                retorno = a.Message;
                throw new NoLeeException("Error al guardar", a);

            }
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test_Unitarios
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        [ExpectedException(typeof(PersonaSinDniException))]  //excepcion esperada
        public void PersonaSinDNI()
        {
            //Creo objeto a testear
            Alumno al = new Alumno("pepe", "peposo", 0, false, 1200, 100);
        }


        [TestMethod]
        public void PersonaDNIValido()
        {
            //Creo objeto a testear
            Alumno al = new Alumno("pepe", "peposo", 37018214, true, 1500, 200);

            //solo verifica que no sea null el objeto
            Assert.IsNotNull(al);



        }
    }
}

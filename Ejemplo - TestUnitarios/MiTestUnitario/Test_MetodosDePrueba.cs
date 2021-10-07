using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using Excepciones;

namespace MiTestUnitario
{
    [TestClass]
    public class Test_MetodosDePrueba
    {
        [TestMethod]
        //[ExpectedException(typeof(ApellidoONombreErroneoException))]
        [DataRow("Perez")]
        public void TestApellido(string value)
        {
            //Arrange
            Persona empleado = new Empleado("u111222", "Alejandro", "Bongioanni");
            //Act
            empleado.Apellido = value;

            //Assert
            Assert.AreEqual(empleado.Apellido,"Perez");
        }


        [TestMethod]
        [ExpectedException(typeof(ApellidoONombreErroneoException))]
        [DataRow("        ")]
        public void TestApellidoException(string value)
        {
            //Arrange
            Persona empleado = new Empleado("u111222", "Alejandro", "Bongioanni");
            //Act
            empleado.Apellido = value;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(DniErroneoException))]
        [DataRow("DNIIVALIDO")]
        public void TestDniException(string value)
        {
            //Arrange
            Persona empleado = new Empleado("u111222", "Alejandro", "Bongioanni");
            //Act
            empleado.Dni = value;

            //Assert
        }

        [TestMethod]
        [DataRow("DNIIVALIDO")]
        [DataRow("12345678")]
        [DataRow("00000001")]
        [DataRow("123A5678")]
        [DataRow("%123A8")]

        public void TestDniValidaPosibilidades(string value)
        {
            //Arrange
            Persona empleado = new Empleado("u111222", "Alejandro", "Bongioanni");
            //Act

            //Assert

            try
            {
                empleado.Dni = value;
                Assert.IsTrue((empleado.Dni == value));
            }
            catch (DniErroneoException ex)
            {
                Assert.AreEqual(empleado.DniNumero, -1);
            }


        }


        [TestMethod]
        [ExpectedException(typeof(FechaNacimientoErroneaException))]
        public void TestValidaFechaNac()
        {
            //Arrange
            Persona empleado = new Empleado("u111222", "Alejandro", "Bongioanni");
            DateTime fecha = new DateTime(2021, 11, 01);
            //Act

            empleado.FechaDeNacimiento = fecha;

            //Assert




        }
    }
}

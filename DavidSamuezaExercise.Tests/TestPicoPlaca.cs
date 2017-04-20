using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DavidSamuezaExercise.Task;

namespace UnitTestProject1
{
    [TestClass]
    public class TestPicoPlaca
    {
        [TestMethod]
        public void TestAutoPermitido()
        {
            Restriction rs = new Restriction();
      
        
            PicoPlaca model = new  PicoPlaca();
            model.Placa = "AZU0896";
            model.Fecha = "20/04/2016"; 
            model.Hora="19:29";
            var testpp = rs.IsAllowCar(model);
            // false se encuentra en pico y placa
            Assert.AreEqual(false, testpp);
        }
        [TestMethod]
        public void TestNoAutoPermitido()
        {
            Restriction rs = new Restriction();
            PicoPlaca model = new PicoPlaca();
            model.Placa = "AZU0896";
            model.Fecha = "20/04/2016";
            model.Hora = "19:31";
            var testpp = rs.IsAllowCar(model);
            // false no se encuentra en pico y placa
            Assert.AreEqual(true, testpp);
        }
    }
}

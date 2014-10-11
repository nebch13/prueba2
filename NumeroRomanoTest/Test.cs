using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumerosRomanos;

namespace NumeroRomanoTest
{
    [TestFixture]
   public class Test
    {

        [Test]
        public void TestNumero6()
        { 
            //arranque
            var roman = new CambioRomano();

            var num = roman.GetRomanStringNumber(6);
            Assert.AreEqual("VI", num);
        }
    }
}

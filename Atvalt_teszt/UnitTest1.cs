using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtvaltOOP;
using System;

namespace AtvaltOOP.Tests
{
    [TestClass]
    public class AtvaltTests
    {
        [TestMethod]
        public void BinToDecimal_ValidBinary_ReturnsDecimal()
        {

            var converter = new Atvalt();
            converter.SetSzam("1010");
            converter.Atvaltas();
            Assert.AreEqual("10", converter.GetEredmeny());
        }

        [TestMethod]
        public void DecimalToBin_ValidDecimal_ReturnsBinary()
        {
            var converter = new Atvalt();
            converter.SetSzam("10");
            converter.Atvaltas();
            Assert.AreEqual("1010", converter.GetEredmeny());
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidBinaryInput_ThrowsArgumentException()
        {
            var converter = new Atvalt();
            converter.SetSzam("10A01");
            converter.Atvaltas();
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidDecimalInput_ThrowsArgumentException()
        {
            var converter = new Atvalt();
            converter.SetSzam("A1001");
            converter.Atvaltas();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void MissingInput_ThrowsInvalidOperationException()
        {
            var converter = new Atvalt();
            converter.Atvaltas();
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void MissingConversionResult_ThrowsInvalidOperationException()
        {
            var converter = new Atvalt();
            converter.SetSzam("1010");
            converter.GetEredmeny();
        }
    }
}
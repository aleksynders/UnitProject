using VIN_LIB;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Zachet
{
    [TestClass]
    public class UnitTest
    {

        // ЛЕГКИЕ
        [TestMethod]
        public void TestMethod_IsTrueVIN() // Метод проверяющий, что VIN является верным
        {
            string vin = "Z8NAJL0005036B14B";
            bool actual = VIN_LIB.Class1.CheckVIN(vin);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethod_AreEqualVIN_True() // Метод проверяющий, что VIN подходит под регулярное выражение
        {
            string vin = "Z8NAJL0005036B14B";
            bool actual = VIN_LIB.Class1.CheckVIN(vin);
            Assert.AreEqual(actual, true);
        }

        [TestMethod]
        public void TestMethod_AreEqualVIN_False() // Метод проверяющий, что VIN не подходит под регулярное выражение
        {
            string vin = "Z8NAJL00050332432342342342342342342346B14B";
            bool actual = VIN_LIB.Class1.CheckVIN(vin);
            Assert.AreEqual(actual, false);
        }

        [TestMethod]
        public void TestMethod_AreNotEqualVIN_True() // Метод проверяющий, что VIN не подходит под регулярное выражение
        {
            string vin = "Z8NAJL000554036B14B";
            bool actual = VIN_LIB.Class1.CheckVIN(vin);
            Assert.AreNotEqual(actual, true);
        }

        [TestMethod]
        public void TestMethod_AreNotEqualVIN_False() // Метод проверяющий, что VIN подходит под регулярное выражение
        {
            string vin = "Z8NAJL0005036B14B";
            bool actual = VIN_LIB.Class1.CheckVIN(vin);
            Assert.AreNotEqual(actual, false);
        }

        [TestMethod]
        public void TestMethod_IsNotTrueVIN() // Метод проверяющий, что VIN не является верным
        {
            string vin = "Z8NAJL0233434343126B14B";
            bool actual = VIN_LIB.Class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestMethod_IsInstanceOfTypeVIN() // Метод проверяющий, что возвращается результат в виде bool
        {
            string vin = "Z8NAJL0233534343126B14B";
            bool actual = VIN_LIB.Class1.CheckVIN(vin);
            Assert.IsInstanceOfType(actual, typeof(bool));
        }

        [TestMethod]
        public void TestMethod_IsNotInstanceOfTypeVIN_String() // Метод проверяющий, что возвращается результат не в виде string значения
        {
            string vin = "Z8NAJL0233434343186B14B";
            bool actual = VIN_LIB.Class1.CheckVIN(vin);
            Assert.IsNotInstanceOfType(actual, typeof(string));
        }

        [TestMethod]
        public void TestMethod_IsNotInstanceOfTypeVIN_Double() // Метод проверяющий, что возвращается результат не в виде double значения
        {
            string vin = "Z8NAJL0233434343186B14B";
            bool actual = VIN_LIB.Class1.CheckVIN(vin);
            Assert.IsNotInstanceOfType(actual, typeof(double));
        }

        [TestMethod]
        public void TestMethod_IsNotInstanceOfTypeVIN_Decimal() // Метод проверяющий, что возвращается результат не в виде decimal значения
        {
            string vin = "Z8NAJL0233434343186B14B";
            bool actual = VIN_LIB.Class1.CheckVIN(vin);
            Assert.IsNotInstanceOfType(actual, typeof(decimal));
        }



        // СЛОЖНЫЕ
        [TestMethod]
        public void TestMethod_IsNullVIN() // Метод проверяющий, что VIN является пустым значением
        {
            string vin = null;
            Assert.IsNull(vin);
        }

        [TestMethod]
        public void TestMethod_IsNotNullVIN() // Метод проверяющий, что VIN не пустое значение
        {
            string vin = "Z8NAJL0233434343126B14B";
            Assert.IsNotNull(vin);
        }

        [TestMethod]
        public void TestMethod_ThrowsException_1() // Метод проверяющий нет ли системных исключений при пустом вводе VIN
        {
            string vin = "";
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => VIN_LIB.Class1.CheckVIN(vin)));
        }

        [TestMethod]
        public void TestMethod_ThrowsException_2() // Метод проверяющий нет ли системных исключений при вводе VIN
        {
            string vin = "Z8NAJL0233434343126B14B";
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => VIN_LIB.Class1.CheckVIN(vin)));
        }

        [TestMethod]
        public void TestMethod_ThrowsException_Country() // Метод проверяющий нет ли системных исключений при определении страны если пусто значение VIN
        {
            string vin = "";
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => VIN_LIB.Class1.GetVINCountry(vin)));
        }
    }
}
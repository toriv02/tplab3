using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2.Tests
{
    [TestClass()]
    public class TemperatureTests
    {
        [TestMethod()]
        public void VerboseTestdegC()//проверка метода для вывода для градусов Цельсия
        {
            var temperature = new Temperature(38, MeasureType.degC);
            Assert.AreEqual("38 °C", temperature.Verbose());
        }
        public void VerboseTestdegF()//проверка метода для вывода для градусов Фаренгейта
        {
            // тестируем все четыре типа
            var temperature = new Temperature(38, MeasureType.degF);
            Assert.AreEqual("38 °F", temperature.Verbose());
        }
        public void VerboseTestdegR()//проверка метода для вывода для градусов Рейлика
        {
            var temperature = new Temperature(38, MeasureType.degR);
            Assert.AreEqual("38 °R", temperature.Verbose());
        }
        public void VerboseTestK()//проверка метода для вывода для градусов Кельвина
        {
            var temperature = new Temperature(38, MeasureType.K);
            Assert.AreEqual("38 K", temperature.Verbose());
        }
        [TestMethod()]
        public void AddNumberTest()//проверка увелечения значения температуры
        {
            var temperature = new Temperature(1, MeasureType.degC);
            temperature = temperature + 4.25;
            Assert.AreEqual("5,25 °C", temperature.Verbose());
        }
        [TestMethod()]
        public void SubNumberTest()//проверка уменьшения значения температуры
        {
            var temperature = new Temperature(3, MeasureType.degC);
            temperature = temperature - 1.75;
            Assert.AreEqual("1,25 °C", temperature.Verbose());
        }

        [TestMethod()]
        public void MulByNumberTest()//проверка умножения значения температуры
        {
            var temperature = new Temperature(3, MeasureType.degC);
            temperature = temperature * 3;
            Assert.AreEqual("9 °C", temperature.Verbose());
        }

        [TestMethod()]
        public void DivByNumberTest()//проверка деления значения температуры
        {
            var temperature = new Temperature(3, MeasureType.degC);
            temperature = temperature / 3;
            Assert.AreEqual("1 °C", temperature.Verbose());
        }
        [TestMethod()]
        public void MeterToAnyTestfegF()//перевод из Цельсия в Фаренгейт
        {
            Temperature temperature;

            temperature = new Temperature(-17.222222222, MeasureType.degC);
            Assert.AreEqual("1,0000000004 °F", temperature.To(MeasureType.degF).Verbose());

        }
        public void MeterToAnyTestdegR()//перевод из Цельсия в Рейлика
        {
            Temperature temperature;

           

            temperature = new Temperature(-270.93, MeasureType.degC);
            Assert.AreEqual("3,9959999999999467 °R", temperature.To(MeasureType.degR).Verbose());


        }
        public void MeterToAnyTestK()//перевод из Цельсия в Кельвины
        {
            Temperature temperature;

            temperature = new Temperature(-270.15, MeasureType.degC);
            Assert.AreEqual("3 K", temperature.To(MeasureType.K).Verbose());
        }
        [TestMethod()]
        public void AnyToMeterTestdegF()//проверка Корректности конвертации для Фаренгейт
        {
            Temperature temperature;

            temperature = new Temperature(1, MeasureType.degC);
            Assert.AreEqual("33,8 °F", temperature.To(MeasureType.degF).Verbose());

        }
        [TestMethod()]
        public void AnyToMeterTestdegR()//проверка Корректности конвертации для Релика
        {
            Temperature temperature;
            temperature = new Temperature(1, MeasureType.degC);
            Assert.AreEqual("493,46999999999997 °R", temperature.To(MeasureType.degR).Verbose());
        }
        [TestMethod()]
        public void AnyToMeterTestK()//проверка Корректности конвертации для Кельвина
        {
            Temperature temperature;

            temperature = new Temperature(1, MeasureType.degC);
            Assert.AreEqual("274,15 K", temperature.To(MeasureType.K).Verbose());
        }
        [TestMethod()]
        public void AddKmMetersTest()//проверка сложения разных типов
        {
            var degC = new Temperature(100, MeasureType.degC);
            var degF = new Temperature(1, MeasureType.degF);

            Assert.AreEqual("82,77777777777777 °C", (degC + degF).Verbose());
            Assert.AreEqual("213 °F", (degF + degC).Verbose());

        }
        public void SubKmMetersTest()//проверка разности разных типов
        {
            var degC = new Temperature(100, MeasureType.degC);
            var degF = new Temperature(1, MeasureType.degF);

            Assert.AreEqual("-211 °F", (degF - degC).Verbose());
            Assert.AreEqual("117,22222222222223 °C", (degC - degF).Verbose());
        }
    }
}
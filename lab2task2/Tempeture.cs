using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2
{
  //Градус Цельсия обозначается как °C, градус Фаренгейта - °F, градус Ранкина - °R, Кельвины - K
    public enum MeasureType { degC, degF, degR, K };
    public class Temperature
    {
        private double value;
        private MeasureType type;
        public Temperature(double value, MeasureType type)
        {
            this.value = value;
            this.type = type;
        }
        public string Verbose()
        {
            string typeVerbose = "";
            switch (this.type)
            {
                case MeasureType.degC:
                    typeVerbose = "°C";
                    break;
                case MeasureType.degF:
                    typeVerbose = "°F";
                    break;
                case MeasureType.degR:
                    typeVerbose = "°R";
                    break;
                case MeasureType.K:
                    typeVerbose = "K";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeVerbose);
        }
        //сложение
        public static Temperature operator +(Temperature instance, double num) { return new Temperature(instance.value + num, instance.type); }

        public static Temperature operator +(double num, Temperature instance) { return instance + num; }
        //умножение
        public static Temperature operator *(Temperature instance, double num) { return new Temperature(instance.value * num, instance.type); }

        public static Temperature operator *(double num, Temperature instance) { return instance * num; }

        // вычитание
        public static Temperature operator -(Temperature instance, double num) { return new Temperature(instance.value - num, instance.type); }

        public static Temperature operator -(double num, Temperature instance) { return instance - num; }

        // деление
        public static Temperature operator /(Temperature instance, double num) { return new Temperature(instance.value / num, instance.type); }

        public static Temperature operator /(double num, Temperature instance) { return instance / num; }
        // сравнение
        public static bool operator <(Temperature instance, double num) { return (instance.value < num); }

        public static bool operator <(double num, Temperature instance) { return instance < num; }
        public static bool operator >(Temperature instance, double num) { return (instance.value > num); }

        public static bool operator >(double num, Temperature instance) { return instance > num; }
        public Temperature To(MeasureType newType)
        {
            var newValue = this.value;
            if (this.type == MeasureType.degC)
            {
                switch (newType)
                {
                    case MeasureType.degC:
                        newValue = this.value;
                        break;
                    // если в °F
                    case MeasureType.degF:
                        newValue = this.value * 1.8 + 32;
                        break;
                    // если в  °R
                    case MeasureType.degR:
                        newValue = (this.value + 273.15) * 1.8;
                        break;
                    // если в K
                    case MeasureType.K:
                        newValue = this.value + 273.15;
                        break;
                }
            }
            else if (newType == MeasureType.degC)
            {
                switch (this.type)
                {
                    case MeasureType.degC:
                        newValue = this.value;
                        break;
                    case MeasureType.degF:
                        newValue = (this.value - 32) / 1.8;
                        break;
                    case MeasureType.degR:
                        newValue = (this.value - 491.67) / 1.8;
                        break;
                    case MeasureType.K:
                        newValue = this.value - 273.15;
                        break;
                }
            }
            else { newValue = this.To(MeasureType.degC).To(newType).value; }
            return new Temperature(newValue, newType);
        }
        //сумма разных типов
        public static Temperature operator +(Temperature instance1, Temperature instance2) { return instance1 + instance2.To(instance1.type).value; }
        //оахность разных типов
        public static Temperature operator -(Temperature instance1, Temperature instance2) { return instance1 - instance2.To(instance1.type).value; }
        //произведение разных типов
        public static Temperature operator *(Temperature instance1, Temperature instance2) { return instance1 * instance2.To(instance1.type).value; }
        //деление разных типов
        public static Temperature operator /(Temperature instance1, Temperature instance2) { return instance1 / instance2.To(instance1.type).value; }
        //сравнение разных типов
        public static bool operator <(Temperature instance1, Temperature instance2) { return instance1 > instance2.To(instance1.type).value; }
        public static bool operator >(Temperature instance1, Temperature instance2) { return instance1 < instance2.To(instance1.type).value; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2Varian8
{
    [Serializable]
    /// <summary>
    /// Абстрактный класс IMotion
    /// </summary>
    public abstract class IMotion
    {
        /// <summary>
        /// Поле класса IMotion
        /// time время
        /// </summary>
        protected uint _time;

        /// <summary>
        /// Абстрактный метод Имя
        /// </summary>
        public abstract string Name { get; }
        /// <summary>
        /// Абстрактный метод
        /// параметры
        /// </summary>
        public abstract string Parametrs { get; }

        /// <summary>
        /// Поле класса IMotion.
        /// x0 стартавая координата.
        /// </summary>
        protected double _x0;

        /// <summary>
        /// Поле класса IMotion.
        /// x проекция на вектор
        /// </summary>
        protected double _x;

        /// <summary>
        /// Абстрактная функция Калькулятор.
        /// Выщитывает координату движения
        /// </summary>
        /// <returns>double</returns>
        abstract public double CalculateCoordination();

        /// <summary>
        /// Записывает значение переменой time
        /// </summary>
        public uint Time
        {
            set
            {

                if (value.GetType() == typeof(int) || value < 1)
                {
                    throw new FormatException();
                }
                _time = value;

            }
            get
            {
                return _time;
            }
        }
        /// <summary>
        /// Записывает значение переменой x0
        /// </summary>
        public double X0
        {
            set
            {

                _x0 = value;

            }
            get
            {
                return _x0;
            }
        }


    }

}



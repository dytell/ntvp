using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2Varian8
{

    [Serializable]
    /// <summary>
    /// Равноускореное движение
    /// Дочерний класс ISourse
    /// </summary>
    public class AcceleratedMotion : IMotion
    {
        /// <summary>
        /// Поля класса 
        /// _aX ускорение 
        /// </summary>
        private double _aX { get; set; }
        /// <summary>
        /// Поле класса
        /// v0X
        /// </summary>
        private double v0X;
        /// <summary>
        /// Конструктор класса AcceleratedMotion
        /// </summary>
        /// <param name="_x0"></param>
        /// <param name="_aX"></param>
        /// <param name="_time"></param>
        /// <param name="_v0X"></param>
        public AcceleratedMotion(double _x0, double _aX, uint _time, double _v0X)
        {
            base._x0 = _x0;

            base._time = _time;

            this._aX = _aX;

            v0X = _v0X;

        }
        /// <summary>
        /// Конструктор класса AcceleratedMotion
        /// </summary>
        public AcceleratedMotion() { }
        /// <summary>
        /// Метод класса Name
        /// </summary>
        public override string Name { get { return string.Format("Равноускореное движение"); } }
        /// <summary>
        /// Метод класса Parametrs
        /// </summary>
        public override string Parametrs { get { return string.Format("X0 {0:F} VX {1:F} time {2:F} AX {3:F} ", X0, V0X, Time, AX); } }

        /// <summary>
        /// записывает значение переменой _aX
        /// </summary>
        public double AX
        {
            set
            {
                _aX = value;

            }
            get
            {
                return _aX;
            }
        }
        /// <summary>
        /// записывает значение переменой v0X
        /// </summary>
        public double V0X
        {
            set
            {
                v0X = value;

            }

            get
            {
                return v0X;
            }
        }
        /// <summary>
        /// Считает координату равноускореного движения
        /// </summary>
        /// <returns>возвращает тип double</returns>
        public override double CalculateCoordination()
        {
            return _x = _x0 + v0X * _time + ((_aX * (_time * _time)) / 2);
        }

    }
}

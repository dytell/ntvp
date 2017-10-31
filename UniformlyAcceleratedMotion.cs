using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2Varian8
{
    [Serializable]
    /// <summary>
    /// Равномерное движение
    /// Дочерний класс ISourse
    /// </summary>
    public class UniformlyAcceleratedMotion : IMotion
    {

        /// <summary>
        /// Поле класса
        /// _vX проекция на вектор x
        /// </summary>
        private double _vX;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public UniformlyAcceleratedMotion() { }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="_x0"></param>
        /// <param name="_vX"></param>
        /// <param name="_time"></param>
        public UniformlyAcceleratedMotion(double _x0, double _vX, uint _time)
        {
            base._x0 = _x0;
            this._vX = _vX;
            base._time = _time;

        }
        /// <summary>
        /// Записывает значение переменой _vX 
        /// </summary>
        public double VX
        {
            set
            {
                _vX = value;
            }
            get
            {
                return _vX;
            }
        }
        /// <summary>
        /// Метод Name
        /// </summary>
        public override string Name { get { return string.Format("Равномерное движение"); } }
        /// <summary>
        /// Метод Paramters
        /// </summary>
        public override string Parametrs { get { return string.Format("X0 {0:F} VX {1:F} time {2:F}  ", X0, VX, Time); } }

        /// <summary>
        /// Калькулятор
        /// Считает координату движения
        /// </summary>
        /// <returns> Возращает тип double </returns>
        public override double CalculateCoordination()
        {
            return _x = _x0 + (_vX * _time);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2Varian8
{
    [Serializable]
    public class OscillatoryMotion : IMotion
    {
        /// <summary>
        /// Поле _xM
        /// </summary>
        private double _xM;
        /// <summary>
        /// Поле _w0
        /// </summary>
        private double _w0;
        /// <summary>
        /// поле _f0
        /// </summary>
        private double _f0;
        /// <summary>
        /// КОнструктор класса OscilatoryMotion
        /// </summary>
        /// <param name="_x0"></param>
        /// <param name="_XM"></param>
        /// <param name="_time"></param>
        /// <param name="_f0"></param>
        /// <param name="_w0"></param>
        public OscillatoryMotion(double _x0, double _XM, uint _time, double _f0, double _w0)
        {
            base._x0 = _x0;
            _xM = _XM;
            base._time = _time;
            this._w0 = _f0;
            this._f0 = _w0;

        }
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        public OscillatoryMotion() { }
        /// <summary>
        /// Метод Name
        /// </summary>
        public override string Name { get { return string.Format("Калебательное движение"); } }
        /// <summary>
        /// Метод Parametrs
        /// </summary>
        public override string Parametrs { get { return string.Format("XM {0:F} w0 {1:F} time {2} f0 {3:F} X0 {4:F} ", XM, W0, Time, F0, X0); } }
        /// <summary>
        /// Метод XM для считывания и видимости
        /// </summary>
        public double XM
        {
            set
            {
                if (value <= 0)
                    throw new TypeExeption();                
                _xM = value;
            }
            get
            {
                return _xM;
            }
        }
        /// <summary>
        ///метод W0 для считывания и видимости
        /// </summary>
        public double W0
        {
            set
            {
                _w0 = value;
            }
            get
            {
                return _w0;
            }
        }
        /// <summary>
        /// Метод F0 для считывания и видимости
        /// </summary>
        public double F0
        {
            set
            {
                _f0 = value;
            }
            get
            {
                return _f0;
            }
        }
        /// <summary>
        /// Метод Метод Калькулятор
        /// </summary>
        /// <returns>double x </returns>
        public override double CalculateCoordination()
        {
            return _x = _xM * Math.Cos(_w0 * _time + _f0) + _x0;
        }
    }
}

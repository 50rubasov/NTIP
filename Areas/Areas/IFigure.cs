using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    /// <summary>
    /// площадь фигуры
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Метод позволяет рассчитать площадь фигуры
        /// </summary>
        /// <returns> возвращает площадь фигуры </returns>
        double Area { get; }
        string Type { get; }
    }
}

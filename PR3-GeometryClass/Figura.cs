using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_GeometryClass
{
    /// <summary>
    /// Class Figura
    /// <remarks>
    /// Clase padre.
    /// </remarks>
    /// </summary>
    class Figura
    {
        protected float x, y;
        public Figura(float x, float y = 0) {
            this.x = x;
            this.y = y;
        }
        public virtual float perimetro() {
            return x * 4;   
        }
        public virtual float area() {
            return x * y;
        }
    }
}

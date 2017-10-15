using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_GeometryClass
{
    class Rectangulo : Figura
    {
        protected float a, b;

        public Rectangulo(float x, float y) : base(x, y)
        {
            this.a = x;
            this.b = y;
        }

        //calculamos el perimetro conociendo dos de sus lados y aplicando la formula
        public override float perimetro()
        {
            return (2 * a) + (2 * b);
        }
        //calculamos el area haciendo el calculo de lado por lado
        public override float area()
        {
            return a * b;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_GeometryClass
{
    class Triangulo : Figura
    {
        protected float b, h;
        //Clase hija triangulo
        public Triangulo(float x, float y) : base(x, y)
        {
            this.b = x;
            this.h = y;
        }

        //calculamos el perimetro conociendo uno de sus lados y multiplicando por 3
        public override float perimetro()
        {
            return x * 3;
        }
        //calculamos el area haciendo el calculo de la base por la altura partido por 2
        public override float area()
        {
            return (x * y) / 2;
        }

    }
}

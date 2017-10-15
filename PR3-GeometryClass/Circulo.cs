using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_GeometryClass
{
    class Circulo : Figura
    {
        protected float r;
        public Circulo(float x) : base(x , 0)
        {
            this.r = x;
        }

        //calculamos el perimetro conociendo su radio
        public override float perimetro()
        { 
            return (float)(2 * Math.PI * r);
        }
        //calculamos el area multiplicando el radio al cuadrado por pi y haciendo un casting a float
        public override float area()
        {
            return (float) (Math.PI * Math.Pow(r, 2));
        }
    }
}

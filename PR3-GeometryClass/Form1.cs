using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_GeometryClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Calcular el Triangulo
        /// </summary>
        /// <remarks>
        /// Calculamos el área y perímetro de un triángulo
        /// recogiendo sus datos primeros y, después, calculando 
        /// </remarks>
        /// <param name="sender"> btnTrigangulo</param>
        /// <param name="e"></param>
        private void btnCalcularTriangulo_Click(object sender, EventArgs e)
        {
            if (!comprobarBtn("triangulo"))
            {
                Triangulo triangulo;
                float b, h, perimetro, area;
                //recogemos los datos
                b = float.Parse(txtCateto1.Text.Replace('.', ','));
                h = float.Parse(txtCateto2.Text.Replace('.', ','));
                //creamos el objeto
                triangulo = new Triangulo(b, h);
                //hacemos los calculos
                perimetro = triangulo.perimetro();
                area = triangulo.area();
                //mostramos el resultado redondeado
                lblResultado.Text = String.Format("Perimetro del triangulo: {0};\n\nArea: {1}", Math.Round(perimetro, 3), Math.Round(area, 3));
            }
        }

        /// <summary>
        /// al pulsar una tecla, comprobamos si es numerico
        /// </summary>
        /// <remarks>
        /// Comprobaremos que no se introduzcan letras, que solo haya  un punto decimal y,
        /// que lo introducido, no sea negativo, ya que no podemos poner el menor. 
        /// </remarks>
        /// <param name="sender">textBox</param>
        /// <param name="e"></param>
        private void txtCateto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // hacer que solo pueda tener un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Calcular el Rectangulo
        /// </summary>
        /// <remarks>
        /// Calculamos el área y perímetro de un rectángulo
        /// recogiendo sus datos primeros y, después, calculando 
        /// </remarks>
        /// <param name="sender"> btnRectangulo</param>
        /// <param name="e"></param>
        private void btnCalcularRectangulo_Click(object sender, EventArgs e)
        {
            if (!comprobarBtn("rectangulo"))
            {
                Rectangulo rectangulo;
                float l1, l2, perimetro, area;
                //recogemos los datos
                l1 = float.Parse(txtLado1.Text.Replace('.', ','));
                l2 = float.Parse(txtLado2.Text.Replace('.', ','));
                //creamos el objeto
                rectangulo = new Rectangulo(l1, l2);
                //hacemos los calculos
                perimetro = rectangulo.perimetro();
                area = rectangulo.area();
                //mostramos el resultado redondeado
                lblResultado.Text = String.Format("Perimetro del rectángulo: {0};\n\n Area: {1}", Math.Round(perimetro, 3), Math.Round(area, 3));
            }
        }
        /// <summary>
        /// Calcular el Circulo
        /// </summary>
        /// <remarks>
        /// Calculamos el área y perímetro de un círculo
        /// recogiendo sus datos primeros y, después, calculando 
        /// </remarks>
        /// <param name="sender"> btnCalcularCirculo</param>
        /// <param name="e"></param>
        private void btnCalcularCirculo_Click(object sender, EventArgs e)
        {
            if (!comprobarBtn("circulo"))
            {
                Circulo circulo;
                float radio, perimetro, area;
                //recogemos los datos
                radio = float.Parse(txtRadio.Text.Replace('.', ','));
                //creamos el objeto
                circulo = new Circulo(radio);
                //hacemos los calculos
                perimetro = circulo.perimetro();
                area = circulo.area();
                //mostramos el resultado redondeado
                lblResultado.Text = String.Format("Perimetro del Círculo: {0};\n\n Area: {1}", Math.Round(perimetro, 3), Math.Round(area, 3));
            }
        }

        /// <summary>
        /// Comprobacion para saber si se han introducido datos
        /// </summary>
        /// <param name="message">Btn pulsado</param>
        /// <remarks>
        /// Comprobamos si los campos de texto están vacíos o no.
        /// </remarks>
        /// <returns>error</returns>
        private Boolean comprobarBtn(String message)
        {
            Boolean error = false;
            switch (message)
            {
                case "triangulo":
                    if (txtCateto1.TextLength == 0 || txtCateto2.TextLength == 0)
                    {
                        error = true;
                        lblResultado.Text = "Por favor, introduzca la base  y la altura";
                    }
                    break;
                case "rectangulo":
                    if (txtLado1.TextLength == 0 || txtLado2.TextLength == 0)
                    {
                        error = true;
                        lblResultado.Text = "Por favor, introduzca los dos lados";
                    }
                    break;
                case "circulo":
                    if (txtRadio.TextLength == 0)
                    {
                        error = true;
                        lblResultado.Text = "Por favor, introduzca el radio";
                    }
                    break;
            }

            return error;
        }
    }
}

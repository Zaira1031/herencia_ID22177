using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void restar_Click(object sender, EventArgs e)
        {
            // se le va a dar comportamiento
            //utilizando la clase hija (Restar)
            Restar resta = new Restar();// creé un nuevo objeto Resta
                                     // va a llamar al metodo de la clase resta Operar 
            resultado.Text = resta.operar(float.Parse(valor1.Text), float.Parse(valor2.Text)).ToString();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            // se le va a dar comportamiento
            //utilizando la clase hija (Sumar)
            Sumar suma = new Sumar();// creé un nuevo objeto SUMA
                                     // va a llamar al metodo de la clase suma Operar 
            resultado.Text = suma.operar(float.Parse(valor1.Text), float.Parse(valor2.Text)).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            // se le va a dar comportamiento
            //utilizando la clase hija (Multiplicar)
            Multiplicar multiplicacion = new Multiplicar();// creé un nuevo objeto multiplicacion
                                        // va a llamar al metodo de la clase multiplicacion Operar 
            resultado.Text = multiplicacion.operar(float.Parse(valor1.Text), float.Parse(valor2.Text)).ToString();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            valor1.Clear();
            valor2.Clear();
            resultado.Clear();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            // se le va a dar comportamiento
            //utilizando la clase hija (Multiplicar)
            // Crear una instancia de la clase Dividir
            // Crear una instancia de la clase Dividir
            Dividir division = new Dividir();

            // Llamar al método Operar de la clase Dividir
            float resultadoDivision = division.operar(float.Parse(valor1.Text), float.Parse(valor2.Text));

            // Verificar si el resultado de la división es válido (no es NaN)
            if (!float.IsNaN(resultadoDivision))
                resultado.Text = resultadoDivision.ToString(); // Mostrar el resultado en el cuadro de texto resultado
        }
    }
}

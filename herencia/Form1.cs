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
            //utilizando la clase hija (Sumar)
            Restar resta = new Restar();// creé un nuevo objeto SUMA
                                     // va a llamar al metodo de la clase suma Operar 
            resultado.Text = resta.operar(int.Parse(valor1.Text), int.Parse(valor2.Text)).ToString();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            // se le va a dar comportamiento
            //utilizando la clase hija (Sumar)
            Sumar suma = new Sumar();// creé un nuevo objeto SUMA
                                     // va a llamar al metodo de la clase suma Operar 
            resultado.Text = suma.operar(int.Parse(valor1.Text), int.Parse(valor2.Text)).ToString();
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
            //utilizando la clase hija (Sumar)
            Multiplicar multiplicacion = new Multiplicar();// creé un nuevo objeto SUMA
                                        // va a llamar al metodo de la clase suma Operar 
            resultado.Text = multiplicacion.operar(int.Parse(valor1.Text), int.Parse(valor2.Text)).ToString();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            valor1.Clear();
            valor2.Clear();
            resultado.Clear();
        }
    }
}

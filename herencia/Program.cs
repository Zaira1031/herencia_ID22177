using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    /* CLASE PRINCIPAL O CLASE PAPÁ QUE GUARDA LOS MÉTODOS DE LECTURA
     DE VALORES Y ALMACENADO DE VALORES EN VARIABLES
    - NOMBRE DE CLASE: operacion 
    // compartir informacion entre clases 
     */
    class operacion
    {
        // declaración der variables que se usa la clase 
        // clase principal que va a poder compartir (suma, resta, multi, division)
        // cajas de memoria que guardan los valores y las repuestas (resultado)
        // tipo de acceso      tipo de dato             nombre de dato 
        protected float valor1;
        protected float valor2;
        protected float resultado;

        // atributos  de la clase de operacion
        // metodos y funciones de la clase operacion 
        /* los metodos que se ponen son las funciones de obtener
         * el valor de la caja de texto y guardarlo en la memoria dentro de la 
         * variable indicada (CONSTRUCTORES- Dato valor 1)*/
        public float Valor1
        {
            get { return valor1; } //vamos por el valor de la caja de texto (OBTIENE)
            set { valor1 = value; } // se guarda en la memoria
        }

        public float Valor2
        {
            get { return valor2; } //vamos por el valor de la caja de texto
            set { valor2 = value; } // se guarda en la memoria
        }

        public float Resultado
        {
            get { return resultado; } //vamos por el valor de la caja de texto
            set { resultado = value; } // se guarda en la memoria
        }

    }
    // CALSE HIJO que utilizará metodos de crear datos
    // clase suma es hija de clase operacion (sumar: operacion)
    class Sumar : operacion // nos da permiso de usar lo que tiene operacion
    {
        //las clases hijas también tiene sus atributos metodos y atributos
        // al igial que variables de uso solamente para la clase hija
        // Declarar valores de esta clase
        // atributos de esta clase
        // metodos de la clase
        public float operar(float v1, float v2)
        {
            valor1 = v1; // accedemos al constructor de operacion
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
    }
    class Restar : operacion // nos da permiso de usar lo que tiene operacion
    {
        //las clases hijas también tiene sus atributos metodos y atributos
        // al igial que variables de uso solamente para la clase hija
        // Declarar valores de esta clase
        // atributos de esta clase
        // metodos de la clase
        public float operar(float v1, float v2)
        {
            valor1 = v1; // accedemos al constructor de operacion
            valor2 = v2;
            return resultado = valor1 - valor2;
        }


    }
    class Multiplicar : operacion // nos da permiso de usar lo que tiene operacion
    {
        //las clases hijas también tiene sus atributos metodos y atributos
        // al igial que variables de uso solamente para la clase hija
        // Declarar valores de esta clase
        // atributos de esta clase
        // metodos de la clase
        public float operar(float v1, float v2)
        {
            valor1 = v1; // accedemos al constructor de operacion
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }
    // Clase para realizar la operación de división
    class Dividir : operacion
    {
        // Método para realizar la división
        public float operar(float v1, float v2)
        {
            // Verificar si el divisor es cero
            if (v2 == 0)
            {
                // Mostrar un mensaje de alerta si se intenta dividir por cero
                MessageBox.Show("No se puede dividir por cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return float.NaN; // Retornar NaN (Not a Number) para indicar un valor inválido
            }
            else
            {
                valor1 = v1;
                valor2 = v2;
                return resultado = valor1 / valor2;
            }
        }

        static class Program
        {
            /// <summary>
            /// Punto de entrada principal para la aplicación. 
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}

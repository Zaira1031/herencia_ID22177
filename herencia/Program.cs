using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    static class Program
    {
        /* CLASE PRINCIPAL O CLASE PAPÁ QUE GUARDA LOS MÉTODOS DE LECTURA
         DE VALORES Y ALMACENADO DE VALORES EN VARIABLES
        - NOMBRE DE CLASE: operacion 
         */
        class operacion
        {
            // declaración der variables que se usa la clase 
            // tipo de acceso      tipo de dato             nombre de dato 
                protected                int                  valor1;
                protected                int                  valor2;
                protected                int                  resultado;
        }
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

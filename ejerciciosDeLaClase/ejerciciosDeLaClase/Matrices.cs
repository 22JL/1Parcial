using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciosDeLaClase
{
    public partial class Matrices : Form
    {
        public Matrices()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declarar Matriz
            listBox1.Items.Clear();
            Random random = new Random();
            int[,]matriz1 = new int[3, 3]{ {3,6,3},{6,9,7 },{8,9,4 } };

            //si el usuario desea ingresar los valores, agregar text box 
            // int ValorFila = Convert.ToInt32(filatextBox.Text); 
            // int ValorColumna = Convert.ToInt32(columnatextBox.Text);

            int ValorFila = random.Next(1,10); //.Next devuelve valores enteros
            int ValorColumna = random.Next(1,10);

            int[,] matriz2 = new int[ValorFila, ValorColumna];


            //Llenar la matriz
            for (int fila = 0; fila < matriz2.GetLength(0); fila++) //matriz2.GetLength(0) se obtiene el numero de filas, el cero representa las dimensiones
            {
                for (int colum = 0; colum < matriz2.GetLength(1); colum++) //matriz2.GetLength(0) se obtiene el numero de filas, el cero representa las dimensiones
                {
                    matriz2[fila, colum] = random.Next(1, 100);
                }
            }

            //Mostrar la matriz
            for (int fila = 0; fila < matriz2.GetLength(0); fila++) //matriz2.GetLength(0) se obtiene el numero de filas, el cero representa las dimensiones
            {
                for (int colum = 0; colum < matriz2.GetLength(1); colum++) //matriz2.GetLength(0) se obtiene el numero de filas, el cero representa las dimensiones
                {
                    listBox1.Items.Add("La posición: [" + fila + "," + colum + "] = " + matriz2[fila, colum]);
                }
            }

            textBox1.Text = matriz2.GetLength(0).ToString() + " x " + matriz2.GetLength(1).ToString();
        }
    }
}

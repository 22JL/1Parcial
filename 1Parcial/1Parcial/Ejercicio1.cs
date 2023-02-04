using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Parcial
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void validarbutton_Click(object sender, EventArgs e)
        {
            if (num1textBox.Text == "")
            {
                errorProvider1.SetError(num1textBox, "Ingrese un número");
                return;
            }
            errorProvider1.Clear();

            decimal numero = Convert.ToDecimal(num1textBox.Text);
            if (numero == 0)
            {
                MessageBox.Show("El número es cero");
            }
            else
            {
                String ValidarPar = ParImpar(numero);
                String ValidarPosNeg = PositivoNegativo(numero);
                MessageBox.Show($"El número es " + ValidarPar + " y es " + ValidarPosNeg);
            }

            
        }
        private String ParImpar(decimal num1)
        {
            String ParIm= "";           

            
            if (num1 % 2 == 0)
            {
                ParIm = "par";
            }
            else
            {
                ParIm = "impar";
            }
            return ParIm;
        }
        private String PositivoNegativo(decimal num1)
        {
            String PosNeg = "";

            if (num1 > 0)
            {
                PosNeg = "positivo";
            }
            else
            {
                PosNeg = "negativo";
            }
            return PosNeg;
        }
    }
}

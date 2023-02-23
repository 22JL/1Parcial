using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciosDeLaClase
{
    public partial class Recursividad : Form
    {
        public Recursividad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Recorrer de 1 en 1
            RecorrerDeUnoenUno(1,100);

        }
        private void RecorrerDeUnoenUno(int valInicial, int valFinal)
        {
            listBox1.Items.Add(valInicial);
            if (valInicial<valFinal)
            {
                RecorrerDeUnoenUno(valInicial, valFinal);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace ejerciciosDeLaClase
{
    public partial class POO : Form
    {
        public POO()
        {
            InitializeComponent();
        }
        Coche miCoche = null;

        List<Coche> cocheList = new List<Coche>();
        private void button1_Click(object sender, EventArgs e)
        {
            //Coche miCoche = new Coche(); //El nombre debe llevar la primera letra en minuscula, ya instanciamos el objeto
            //Coche miCoche2 = new Coche("Toyota", "22R");

            string marca = MarcatextBox.Text;
            string modelo = ModelotextBox.Text;
            decimal precio = Convert.ToDecimal(PreciotextBox.Text);

            //se utiliza operador terniario para validar si el campo está vacio
            int km = KmtextBox.Text == string.Empty ? 0 : Convert.ToInt32(KmtextBox.Text); 

            miCoche = new Coche(); //se instancia el objeto
            miCoche.Marca = marca;
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;    
            miCoche.kilometros = km;

            cocheList.Add(miCoche);
            cochesGridView.DataSource = null; // se usa para limpiar el dataGridView
            cochesGridView.DataSource = cocheList;
            LimpiarControles();
            MarcatextBox.Focus(); // para que el puntero se dirija automaticamente al text box
            //MessageBox.Show("Onjeto Coche -> Marca: " + miCoche.Marca + " Modelo: " + miCoche.Modelo);
        }


        private void LimpiarControles()
        {
            MarcatextBox.Clear();
            ModelotextBox.Text = String.Empty;
            PreciotextBox.Text = "";
            KmtextBox.Clear();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

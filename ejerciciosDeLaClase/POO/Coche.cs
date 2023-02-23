using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Coche
    {
        //Atributos: siempre deben ser privados
        private string marca;
        private string modelo;
        private decimal precio;

        //Propiedades: nos ayudan a poder acceder a los atributos
        public string Marca //Impotante que lleve la primera letra mayuscula
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo { get => modelo; set => modelo = value; }

        public decimal Precio { get; set; }
        public int kilometros { get; set; } 

        //constructores: siempre seran publicos y siempre tendrfan el mismo nombre
        public Coche() { }

        public Coche(string _marca, string _modelo) 
        { 
            Marca = _marca;  
            Modelo = _modelo;
        }

        // <=== si hacemos clic en la herramienta azul se genera automaticamente el construcctor
        public Coche(string marca, string modelo, decimal precio, int kilometros) : this(marca, modelo) // : this está heredando el constructor anterior, si lo borramos tendriamos que agregarlos manualmente dentro
        {
            Precio = precio;
            this.kilometros = kilometros;
        }

        //Metodos o acciones

        public string DevolverDatosBasicos()
        {
            return "Marca: " + Marca + " Modelo: " + Modelo + " Precio: " + Precio;
        }
        


    }
}

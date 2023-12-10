using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTelefono
{
    class Telefono
    {
        //CONSTRUCTORES
       public Telefono(string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }


        //ATRIBUTOS de la clase Telefono: modelo, marca, numeroTelefonico y codigoOperador
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        //PROPIEDADES
        public int CodigoOperador
        {
            get {return codigoOperador; }
            
            set 
            {
            if (value >= 1 && value <=3)
                codigoOperador = value;
            else
                codigoOperador = 0;
            }
        }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public string NumeroTelefonico { get; set; }

        //METODOS-COMPORTAMIENTOS
        
        public string llamar ()
        {
            return "Realizando llamada...";
        }

        public string llamar (string contacto)
        {
            return "llamando a " + contacto;
        }
    }
}

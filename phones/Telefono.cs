using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace phones
{
    class Telefono
    {
        //public int Llamar;
        private string marca;
        private int codigoOperador;
        private int numeroTelefonico;
        public string Modelo { get; }
        public string Marca { get; }
        public int NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }
        public int CodigoOperador
        {
            set
            {
                if (value <= 3)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }

            }
            get { return codigoOperador; }
        }
        public Telefono()
        {
            Modelo = String.Empty;
            marca = String.Empty;
            NumeroTelefonico = 0;
            CodigoOperador = 0;
        }
        public Telefono(string modelo, String marca)
        {
            Modelo = modelo;
            this.marca = marca;
            NumeroTelefonico = 0;
            CodigoOperador = 0;
        }
        //metodo llamar()
        public string Llamada()
        {
            if (codigoOperador == 1)
            { return "realizando llamada..."; }
            else
            { return "no se puede realizar la llamda.."; }
        }
        /*public string Llamada(string contacto);
        {
        return "llamando a " + contacto;
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.*/
namespace phones
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefono[] telefonos = new Telefono[10];
            for (int x = 0;x<10;x++)
            {
                Console.WriteLine("Ingrese Marca De Telefono...");
                string marca = Console.ReadLine();
                //telefonos[x] = new Telefono("Modelo X",marca);
                Console.WriteLine("Ingrese Modelo...");
                string modelo = Console.ReadLine();
                //telefonos[x] = new Telefono("Marca X", modelo);
                Console.WriteLine("Ingrese Codigo Operador 1,2 o 3...\n");
                string codigoOperador = Console.ReadLine();
                Console.WriteLine("Ingrese estado de llamada 1 positivo 0 falso");
                string llamada = Console.ReadLine();
                Console.WriteLine("Marca " + marca + " modelo " + modelo + " codigo operador " + codigoOperador + " realiza llamada? " + llamada);
                                
            }

        }
    }
}

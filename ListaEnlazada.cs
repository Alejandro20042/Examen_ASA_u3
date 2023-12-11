using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_ASA
{

    class Productos
    {
        public int Precio { get; set; }
        public string Nombre { get; set; }

        public Productos(int precio, string nombre) 
        { 
            Precio = precio;
            Nombre = nombre;
        
        }
    }

    class Nodo
    {
        public Productos Dato { get; set; }
        public Nodo Siguiente { get; set; }
    }


    internal class ListaEnlazada
    {
        private Nodo cabeza { get; set; }

        public void AgregarProducto(Productos producto)
        {
            Nodo nuevoNodo = new Nodo { Dato = producto, Siguiente = null };

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }

        }

        public int BuscarProductos(int precio)
        {
            Nodo actual = cabeza;
            int posicion = 0;

            while (actual != null)
            {
                if (actual.Dato.Precio == precio)
                {
                    Console.WriteLine($"El precio del producto:{actual.Dato.Precio}, con nombre: {actual.Dato.Nombre} esta en la posicion {posicion}");
                    return posicion;

                }
                actual = actual.Siguiente;
                posicion++;


            }
            return -1;

        }



        public void ImprimirProductos()
        {
            Nodo actual = cabeza;

            while (actual != null)
            {
                Console.WriteLine($"Nombre del producto: {actual.Dato.Nombre}, Precio del producto: {actual.Dato.Precio} ");

                actual = actual.Siguiente;
            }

        }

        public void OrdenarProductos()
        {
            bool bandera = true;

            while (bandera)
            {
                bandera = false;
                Nodo actual = cabeza;
                Nodo siguiente = cabeza.Siguiente;

                while (siguiente != null)
                {
                    if(actual.Dato.Precio < actual.Dato.Precio)
                    {

                    }

                }



            }

        }
    }
}


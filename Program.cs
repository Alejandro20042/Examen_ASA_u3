namespace Examen_ASA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada listaEnlazada = new ListaEnlazada();
            while (true)
            {


                Console.WriteLine("1. Agregar Producto");
                Console.WriteLine("2. Buscar Producto");
                Console.WriteLine("3. Imprimir lista de Productos");
                
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa el nombre del producto");
                        string? nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa el precio del producto");
                        int precio = int.Parse(Console.ReadLine());

                        Productos productoNuevo = new Productos(precio, nombre);
                        listaEnlazada.AgregarProducto(productoNuevo);

                        break;
                        case 2:
                        Console.WriteLine("Dame el precio a buscar ");
                        int precioBuscado = Convert.ToInt32(Console.ReadLine());

                        listaEnlazada.BuscarProductos(precioBuscado);
                        break;
                        case 3:
                        listaEnlazada.ImprimirProductos();
                        break;

                      

                   
                }


            }

        }
    }
}

using clasecliente.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasecliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el Cedula del cliente: ");
            string cedula = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el apellido del cliente: ");
            string apellido = Console.ReadLine();
            Console.WriteLine();
            
            Cliente objCliente = new Cliente(cedula, nombre, apellido);

            BaseDatos.BaseDeDatos.ImprimirCliente();

            Console.Write("Ingrese el cedula del cliente: " );
            cedula = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el nombre del cliente: ");
            nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el apellido del cliente: ");
            apellido = Console.ReadLine();
            Console.WriteLine();

            Cliente objCliente2 = new Cliente(cedula, nombre, apellido);

            BaseDatos.BaseDeDatos.ImprimirCliente();
            Console.ReadLine();
            


            Console.WriteLine();
            Console.Write("Ingrese la cedula del cliente a buscar: ");
            cedula=Console.ReadLine();
            Cliente objClienteBuscado = BaseDatos.BaseDeDatos.BuscarClientePorCedula(cedula);
            
            
            if(objClienteBuscado != null)
            {
                Console.WriteLine("cliente encontrado:");
                objClienteBuscado.imprimir();
            }
            else
            {
                Console.WriteLine("Cliente no encontrado: ");

            }
            Console.Write("Ingrese la ceduladel cliente a buscar: ");
            cedula = Console.ReadLine();
            objClienteBuscado = BaseDatos.BaseDeDatos.BuscarClientePorCedula(cedula);
            
            if (objClienteBuscado != null)
            {
                Console.WriteLine("Cliente encontrado: ");
                objClienteBuscado.imprimir();
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleColaCircular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  opcion;
            string dato;
            Cola cola = new Cola(4);
            do {
                Console.WriteLine("\t===================== [ MENU COLA CIRCULAR ] =====================");
                Console.WriteLine("\t\t1.- INSERTAR");
                Console.WriteLine("\t\t2.- ELIMINAR");
                Console.WriteLine("\t\t3.- LISTAR");
                Console.WriteLine("\t\t4.- SALIR");
                Console.Write("\tELIGIR UNA OPCION: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("\tDIGITE UN VALOR: ");
                        dato=Console.ReadLine();
                        cola.InsertarItem(dato);
                        break;
                    case 2:
                        cola.EliminarItem();
                        break;
                    case 3:
                        cola.ListarItems();
                        break;
                    case 4:
                        break;
                    default:
                        break;

                }
                Console.ReadKey(true);
                Console.Clear();
            } while (opcion != 4);
        }
    }
}

using System;
using GestorTareas.Clases;

namespace GestorTareasTest 
{
    class Program
    {
        static void Main()
        {
            GestorTareasS gestor = new GestorTareasS();

            while (true) 
            {
                Console.WriteLine("\nGestor de Tareas");
                Console.WriteLine("\n1. Agregar tarea");
                Console.WriteLine("\n2. Listar tarea");
                Console.WriteLine("\n3. Completar tarea");
                Console.WriteLine("\n4. Eliminar tarea");
                Console.WriteLine("\n5. Salir");
                Console.WriteLine("\n Selecciona una opcion");

                string opcion = Console.ReadLine();
                
                switch (opcion)
                {
                    case "1":
                        Console.Write("Descripción de la tarea: ");
                        string descripcion = Console.ReadLine();
                        gestor.AgregarTareas(descripcion);
                        break;
                    case "2":
                        gestor.ListarTareas();
                        break;
                    case "4":
                        Console.Write("ID de la tarea a eliminar: ");
                        int idEliminar = int.Parse(Console.ReadLine());
                        gestor.EliminarTarea(idEliminar);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
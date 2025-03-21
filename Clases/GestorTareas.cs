using System;

namespace GestorTareas.Clases 
{
    class GestorTareas 
    {
        private List<Tarea> tareas = new List<Tarea>();
        private int contadorId = 1;

        //Metodo para agregar tareas nuevas
        public void AgregarTareas(string descripcion) 
        {
            tareas.Add(new Tarea(contadorId, descripcion));
            contadorId++;
        }
        //Metodo para listar las tareas que se tienen
        public void ListarTareas() 
        {
            if (tareas.Count == 0) 
            {
                System.Console.WriteLine("No hay tareas registradas.");
            }

            foreach (var tarea in tareas)
            {
                System.Console.WriteLine(tarea);
            }
        }

        public void CompletarTarea(int id) 
        {
            var tarea = tareas.FirstOrDefault(t => t.Id == id);
            if (tarea != null)
            {
                tarea.MarcarComoCompletada();
            }
        }

        public void EliminarTarea(int id)
        {
            tareas.RemoveAll(t => t.Id == id);
        }
    }
    
}
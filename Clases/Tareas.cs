using System;

namespace GestorTareas.Clases 
{
    public class Tarea
    {
        //Propiedades basicas
        public int Id {get; set;}
        public string Descripcion {get; set;}
        public bool Completada {get; set;}
        
        //Constructor (Valores por defecto)
        public Tarea(int id, string descripcion) 
        {
            Id = id;
            Descripcion = descripcion;
            Completada = false;
        }

        //Si se completo la tarea, llamo esta funcion y la marca como true
        public void MarcarComoCompletada()
        {
            Completada = true;
        }
        
        public override string ToString() 
        {
            return $"{Id}: {Descripcion} - {(Completada ? "✅ Completada" : "❌ Pendiente")}"; // Esto es un simple if, nada mas que simplificado, si es true, devuelve "completada, sino pendiente
        }
    }
}
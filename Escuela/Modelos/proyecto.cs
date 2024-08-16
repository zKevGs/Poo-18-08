

namespace Escuela.Modelos
{
     
        public class Proyecto : EntidadConNombre
        {
            public string Descripcion { get; set; }

            public Proyecto(string descripcion, string nombre) : base(nombre)
            {
                Descripcion = descripcion;
            }

            public override void MostrarDetalles() 
            {
                base.MostrarDetalles();
                Console.WriteLine($"descripcion: {Descripcion}");
            }

            public void EvaluarProyecto(Evaluador evaluador) 
            {
                Console.WriteLine($"Nombre: {Nombre}, esta siendo evaluado por: {evaluador.Nombre}");            
            }
        }
}

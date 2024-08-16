using Escuela.Modelos;

namespace Escuela
{
    class Program
    {
        static void Main() 
        {

            Administrador admin = new Administrador("juan perez", 15);

            Modelos.Escuela angelistos = new Modelos.Escuela("escuela angelistos", admin);

            Profesor profe1 = new Profesor("maria lopez");

            profe1.Añadir(new Materia("matematicas", 5));
            profe1.Añadir (new Materia("historias", 6));

            Aula aula1 = new Aula("aula 1", profe1);
            aula1.Añadir(new Estudiante("ana", 10));
            aula1.Añadir(new Estudiante("luis", 11));

            Profesor profe2 = new Profesor("carlos garcia");
            profe2.Añadir(new Materia("ciencias", 3));

            Aula aula2 = new Aula("aula 2", profe2);
            aula2.Añadir(new Estudiante("elena", 10 ));

            angelistos.Añadir(aula1);
            angelistos.Añadir(aula2);

            angelistos.MostrarDetalles();

            Console.WriteLine("----------------------");

            Proyecto proyecto1 = new Proyecto("Proyecto de ciencias", "investigacion sobre la energia solar");

            Evaluador evaluador1 = new Evaluador("sofia alcaraz", "Matematicas");

            proyecto1.EvaluarProyecto(evaluador1);
        }
    }
}

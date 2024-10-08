/* El programa permite ingresar las notas de varios estudiantes, calcular su promedio y luego clasificar a cada estudiante en diferentes categorías de desempeño académico. Al final, se le pregunta al usuario si quiere ingresar otro grupo de estudiantes.
Reglas:
- Si el promedio del estudiante es mayor o igual a 4.5, está en la categoría Excelente.
- Si el promedio está entre 4.0 y 4.4, está en la categoría Sobresaliente.
- Si el promedio está entre 3.5 y 3.9, está en la categoría Bueno.
- Si el promedio es menor a 3.5, está en la categoría Insuficiente. */

public class Program
{
    private static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Ingrese el número de estudiantes:");
            int numEstudiantes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numEstudiantes; i++)
            {
                double sumaNotas = 0;

                Console.WriteLine($"Ingrese las 5 notas del estudiante {i + 1}:");
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Nota {j + 1}:");
                    sumaNotas += Convert.ToDouble(Console.ReadLine());
                }

                double promedio = sumaNotas / 5;
                string categoria;

                if (promedio >= 4.5)
                    categoria = "Excelente";
                else if (promedio >= 4.0)
                    categoria = "Sobresaliente";
                else if (promedio >= 3.5)
                    categoria = "Bueno";
                else
                    categoria = "Insuficiente";

                Console.WriteLine($"El estudiante {i + 1} tiene un promedio de {promedio:F2} y está en la categoría {categoria}");
            }
        }
    }
}
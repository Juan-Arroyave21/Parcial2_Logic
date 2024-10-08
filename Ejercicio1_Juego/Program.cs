/* Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo, consiste en adivinar un número ℕ aleatorio que el sistema escoge de un determinado rango y lo guarda en memoria sin ser revelado. 
 * El juego debe tener la funcionalidad de escoger el número de participantes que jugarán: mínimo 2 y máximo 4 integrantes. Dependiendo de la cantidad de jugadores, el número ℕ aleatorio se generará en los siguientes rangos:
- Si participan 2 jugadores, el número ℕ aleatorio se generará entre 0 y 50
- Si participan 3 jugadores, el número ℕ aleatorio se generará entre 0 y 100
- Si participan 4 jugadores, el número ℕ aleatorio se generará entre 0 y 200
Cada jugador comenzará su turno intentando adivinar ese número ℕ aleatorio. El programa deberá mostrarle al jugador la siguiente información:
- Si el número ingresado es mayor al número aleatorio, entonces mostrar por pantalla la palabra “MENOR” y darle la oportunidad al siguiente jugador.
- Si el número ingresado es menor al número aleatorio, entonces mostrar por pantalla la palabra “MAYOR” y darle la oportunidad al siguiente jugador.
- Si el número ingresado coincide con el número aleatorio, entonces mostrar por pantalla la palabra “¡HAS GANADO!”. Aquí ya finaliza el juego.
El programa deberá estar en capacidad de pedir a los jugadores si desean un nuevo “tirito” para volver a jugar y borrar consola, de lo contrario, finalizar el programa.*/

public class Program
{
    private static void Main(string[] args)
    {
        bool jugarDeNuevo = true;
        while (jugarDeNuevo)
        {
            Console.WriteLine("Bienvenido a Adivina el número");
            Console.WriteLine();
            int numParticipantes;
            while (true)
            {
                Console.Write("Ingrese el número de jugadores de 2 a 4: ");
                string entrada = Console.ReadLine();
                if (int.Parse(entrada) >= 2 && int.Parse(entrada) <= 4)
                {
                    numParticipantes = int.Parse(entrada);
                    break;
                }
                else
                {
                    Console.WriteLine("Número de jugadores inválido. Debe ser entre 2 y 4.");
                }
            }
            int rangoNumeros;
            switch (numParticipantes)
            {
                case 2:
                    rangoNumeros = 50;
                    break;
                case 3:
                    rangoNumeros = 100;
                    break;
                case 4:
                    rangoNumeros = 200;
                    break;
                default:
                    throw new Exception("Error inesperado");
            }
            Random random = new Random();
            int numeroAleatorio = random.Next(0, rangoNumeros + 1);

            int jugadorActual = 1;
            while (true)
            {
                Console.WriteLine($"Es el turno del jugador {jugadorActual}");
                Console.Write("Ingrese un número: ");
                int numeroIngresado = Convert.ToInt32(Console.ReadLine());

                if (numeroIngresado < numeroAleatorio)
                {
                    Console.WriteLine("MAYOR");
                }
                else if (numeroIngresado > numeroAleatorio)
                {
                    Console.WriteLine("MENOR");
                }
                else
                {
                    Console.WriteLine("¡HAS GANADO!");
                    break;
                }

                jugadorActual = (jugadorActual % numParticipantes) + 1;
            }
            Console.Write("¿Desea jugar de nuevo? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (respuesta != "s")
            {
                jugarDeNuevo = false;
                Console.WriteLine("¡Gracias por jugar, hasta luego!");
            }
            else
            {
                Console.Clear();
            }
        }
    }
}
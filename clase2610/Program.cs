using System;

namespace clase2610
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo de dato - nombre variable
            int numero;
            string nombre;
            bool isVerdader;
            char algo;

            int[] arrayNumeros; //****
            string[] nombres;
            bool[] listaBooleanos;


            //inicializo mi array de int con 3 espacios (largo = 3)
            arrayNumeros = new int[3];
            //puedo declarar e inicializar en la misma línea
            //int[] arrayNumerosEjemplo = new int[3];

            //mostrando los elementos solo incializados
            Console.WriteLine(arrayNumeros[0]);
            Console.WriteLine(arrayNumeros[1]);
            Console.WriteLine(arrayNumeros[2]);

            Console.WriteLine("*****");

            int numero1 = 20;
            int numero2 = 40;
            int numero3 = 60;

            //le entrego los valores a cada índice del array,
            arrayNumeros[0] = 20;
            arrayNumeros[1] = 40;
            arrayNumeros[2] = numero3;

            Console.WriteLine(arrayNumeros[0]);
            Console.WriteLine(arrayNumeros[1]);
            Console.WriteLine(arrayNumeros[2]);

            string nombreEjemplo = "diego";

            string[] listaDias = new string[] { "lunes", "martes", "sábado", "domingo" };

            Console.WriteLine(listaDias[0]);
            Console.WriteLine(listaDias[1]);
            Console.WriteLine(listaDias[2]);
            Console.WriteLine(listaDias[3]);

            //ARRAY IMPLIÍCITOS
            var marcas = new[] {"Sony", "LG", "Lenovo" };
            //los array implicitos comienzan originalmente sin un tipo de daro específico, y lo decide el compilador, de acuerdo a
            //la matriz entregada.

            Videojuego[] listaDeConsolas = new Videojuego[2];

            Videojuego consola1 = new Videojuego("Play Station 5");

            listaDeConsolas[0] = consola1;
            listaDeConsolas[1] = new Videojuego("XBOX Series X");

            Console.WriteLine("****VideoJuegos");
            Console.WriteLine(listaDeConsolas[0].Nombre);
            Console.WriteLine(listaDeConsolas[1].Nombre);

            //array Clases ANónimas

            var listaDeCiudades = new[] {
                new {Nombre= "", Posicion= 13},
                new {Nombre = "Rancagua", Posicion= 6},
                new {Nombre = "Concepción", Posicion = 8}
            };

            Console.WriteLine("ACA COMIENZO el 28/10");//Aquí quedamos el 26/10
            Console.WriteLine(arrayNumeros.Length);
            //iteramos la lista de números
            for (int i = 0; i < arrayNumeros.Length; i++) {
                Console.WriteLine(arrayNumeros[i]);
            }

            //iteramos la lista de consolas
            for (int i = 0; i < listaDeConsolas.Length; i++)
            {
                Console.WriteLine(listaDeConsolas[i]);
            }

            //iteramos la lista de números
            foreach (int numerito in arrayNumeros)
            {
                Console.WriteLine(numerito);
            }

            //iteramos la lista de consolas
            int indice = 0;
            foreach(Videojuego elemento in listaDeConsolas)
            {
                Console.WriteLine(elemento.Nombre);
                indice++;
            }


        }
    }
}

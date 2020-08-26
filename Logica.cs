using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deteccion
{
    class Logica
    {
       public void DETECTAR()
       {
            string palabra;
            string letra;
            var comparador = StringComparer.InvariantCultureIgnoreCase;
            var cuenta = 0;

            Console.WriteLine("Por favor digite una palabra:");
            while ((palabra = Console.ReadLine()) != null)
            {
                var conjunto = new HashSet<string>(new string[] { }, comparador);
                for (int x = 0; x < palabra.Length; x++)
                {
                    letra = palabra[x].ToString();
                    if (conjunto.Add(letra))
                    {
                        int contador = 1;
                        for (int y = x + 1; y < palabra.Length; y++)
                        {
                            if (comparador.Equals(letra, palabra[y].ToString()))
                            {
                                contador++;
                                cuenta = contador;
                            }
                        }
                    }
                }
                if (cuenta >= 2)
                {
                    Console.WriteLine("Verdadero");
                    DETECTAR();
                }
                else
                {
                    Console.WriteLine("Falso");
                    DETECTAR();
                }
            }
       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalV2
{
    internal class Metodos
    {
        public string SecuenciaNumeros(int numeroBase, int numeroFinal)
        {
            if (numeroFinal == numeroBase)
            {
                Console.WriteLine("LOS NUMEROS SON IGUALES");
            }
            else if (numeroFinal != numeroBase)
            {
                for (int i = 0; i < numeroBase; i++)
                {
                    if (numeroBase < numeroFinal)
                    {

                        Console.WriteLine("la secuencia de los numeros son " + numeroBase++);
                    }
                    for (int j = 0; j < numeroFinal; j++)
                    {
                        if (numeroFinal < numeroBase)
                        {
                            Console.WriteLine("la secuencia de los numeros son " + numeroBase--);

                        }

                    }
                }
            }
            return "" + numeroFinal;
        }

        public string Curp(string sentencia)
        {
            char fechaDiaUno = sentencia[4];
            char fechaDiaDos = sentencia[5];
            char mesUno = sentencia[6];
            char mesDos = sentencia[7];
            char añoUno = sentencia[8];
            char añoDos = sentencia[9];
            //LARO990208HFGLYD02
            //LOLI050825MFGLYD02
            char Sexo = sentencia[10];
            if (Sexo != 'H')
            {
                Console.WriteLine("usted es mujer");
            }
            else
            {
                Console.WriteLine("Usted es hombre");
            }

            if (añoUno >= 0)
            {
                Console.WriteLine($"y su fecha de nacimiento es {fechaDiaUno}{fechaDiaDos}/{mesUno}{mesDos}/20{añoUno}{añoDos}");
            }
            else
                Console.WriteLine($"y su fecha de nacimiento es {fechaDiaUno}{fechaDiaDos}/{mesUno}{mesDos}/19{añoUno}{añoDos}");
            return "";
        }
        public string RecursivoTablas(int numero, int contador)
        {
            contador++;
            if (contador > 10)
            {
                return "saliendo";

            }
            else
                Console.WriteLine($"{numero}* {contador}= {numero * contador}");
            return RecursivoTablas(numero, contador);

        }

    }
}

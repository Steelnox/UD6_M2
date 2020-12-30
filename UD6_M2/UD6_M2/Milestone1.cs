using System;
using System.Collections.Generic;
using System.Text;

namespace UD6_M2
{
    public class Milestone1
    {
        public void Principal()
        {
            char[] nombre = { 'E', 'R', 'I', 'C' };

            List<char> nombre_lista = new List<char>();
            nombre_lista.Add('E');
            nombre_lista.Add('R');
            nombre_lista.Add('I');
            nombre_lista.Add('C');

            List<char> apellido_lista = new List<char>();
            apellido_lista.Add('P');
            apellido_lista.Add('A');
            apellido_lista.Add('S');
            apellido_lista.Add('T');
            apellido_lista.Add('O');
            apellido_lista.Add('R');

            List<char> nombreCompleto_lista = new List<char>();

            Console.WriteLine("-----------FASE 1----------");
            for (int i = 0; i < nombre.Length; i++)
            {
                if (i < nombre.Length - 1) Console.Write(nombre[i]);
                else Console.WriteLine(nombre[i]);
            }

            Console.WriteLine("-----------FASE 2----------");

            foreach (char letra in nombre_lista)
            {
                if(letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                {
                    Console.WriteLine("VOCAL");
                }
                else if (char.IsNumber(letra))
                {
                    Console.WriteLine("Los nombres no contienen numeros!!");
                }
                else
                {
                    Console.WriteLine("CONSONANTE");
                }
            }

            Console.WriteLine("-----------FASE 3----------");

            Dictionary<char, int> numero_letras = new Dictionary<char, int>();
            numero_letras.Add('E', 0);
            foreach (char letra in nombre_lista)
            {
                if (numero_letras.ContainsKey(letra))
                {
                    numero_letras[letra]++;
                }
                else
                {
                    numero_letras.Add(letra, 1);
                }
            }

           foreach(KeyValuePair<char,int> result in numero_letras)
            {
                Console.WriteLine(result.Key + " " + result.Value);
            }

            Console.WriteLine("-----------FASE 4----------");

            foreach (char letra in nombre_lista)
            {
                nombreCompleto_lista.Add(letra);
            }

            nombreCompleto_lista.Add(' ');

            foreach (char letra in apellido_lista)
            {
                nombreCompleto_lista.Add(letra);
            }

            foreach (char letra in nombreCompleto_lista)
            {
                Console.Write(letra);
            }
        }
    }
}

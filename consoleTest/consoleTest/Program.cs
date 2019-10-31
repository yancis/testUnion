using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace consoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Program c = new Program();
            int[] lista1 = { 10, 15, 3, 7 };
            int[] lista2 = { 1, 2, 3, 4, 5 };
            bool res1 = c.resolverProblema1(lista1, 17);
            int[] res2 = c.resolverProblema2(lista2);

            Console.WriteLine("RESULTADO PROBLEMA 1:");
            Console.WriteLine(res1);

            Console.WriteLine("RESULTADO PROBLEMA 2:");
            for(int i=0; i<res2.Length;i++)
            {
                Console.Write(res2[i] + ",");
            }
            Console.Read();



        }

        public bool resolverProblema1(int[] lista, int k)
        {
            int primero;
            int segundo;
            Boolean encontrado = false;
            for (int i=0; i<lista.Length-1;i++)
            {
                primero = lista[i];
                for(int j=i+1;j<lista.Length;j++)
                {
                    segundo = lista[j];
                    if((primero+segundo)==k)
                    {
                        encontrado = true;
                        break;
                    }
                    if (encontrado)
                        break;
                }
            }
            return encontrado;
        }

        public int[] resolverProblema2(int[]lista)
        {
            List<int> lresult = new List<int>();
            for (int i=0; i<lista.Length;i++)
            {
                int producto = 1;
                for (int j=0;j<lista.Length;j++)
                {
                    if(j!=i)
                    {
                        producto *= lista[j];
                    }
                }
                lresult.Add(producto);
            }
            int[] result = lresult.ToArray();
            return result;
        }
    }
}

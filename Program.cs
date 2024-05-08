using System;
using System.Collections.Generic;
using Nodi;
using lista;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaConcatenata lista = new ListaConcatenata();
            ListaConcatenata lista1 = new ListaConcatenata();
            lista.Aggiungi(5);
            lista.Aggiungi(10);
            lista.Aggiungi(15);

            lista1.Aggiungi(5);
            lista1.Aggiungi(9);
            lista1.Aggiungi(176);

            int a = 0;
            int b = 0;

            for (int l = 0; l < 3; l++)
            {

                if(lista.get(l).CompareTo(lista1.get(l)) == -1)
                {
                    a++;
                }else{
                    b++;
                }

            }
            if (a > b)
            {
            Console.WriteLine(a);
            }
            else
            {
            Console.WriteLine(b);
            }
        }
    }
}



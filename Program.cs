using System;
using System.Collections.Generic;

namespace Laboratorio8
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> listaStrings = new List<string>();
            // listaStrings.Add("Um");
            // listaStrings.Add("Hello");
            // listaStrings.Add("World");
            // Console.WriteLine(listaStrings[0]);
            // Console.WriteLine(listaStrings[1]);
            // Console.WriteLine(listaStrings[2]);
            // listaStrings.Add("10");
            // Console.WriteLine(listaStrings[3]);

            // Queue<Object> q = new Queue<Object>();
            // q.Enqueue(".Net Framework");
            // q.Enqueue(new Decimal(123.456));
            // q.Enqueue(654.321);
            // Console.WriteLine(q.Dequeue());
            // Console.WriteLine(q.Dequeue());
            // Console.WriteLine(q.Dequeue());

            // Dictionary<int, string> paises = new Dictionary<int, string>();
            // paises[44] = "Reino Unido";
            // paises[33] = "França";
            // paises[55] = "Brasil";
            // Console.WriteLine("O código 55 é: {0}", paises[55]);
            // foreach (KeyValuePair<int, string> item in paises)
            // {
            //     int codigo = item.Key;
            //     string pais = item.Value;
            //     Console.WriteLine("Código {0} = {1}", codigo, pais);
            // }

            // int? getDDI(string pais){
            //     foreach (KeyValuePair<int, string> item in paises)
            //     {
            //         if(item.Value == pais)
            //             return item.Key;
            //     }
            //     return null;
            // }

            // Console.WriteLine(getDDI("Brasil"));


            List<double> l = new List<double>{10, 7, 8.5, 6, 4};

            // int TotalAcimaMedia(List<double> lista){
            //     double total = 0;

            //     foreach (var item in lista)
            //     {
            //         total += item;
            //     }

            //     double media = total / lista.Count;
            //     int counter = 0;

            //     foreach (var item in lista)
            //     {
            //         if(item > media)
            //             counter++;
            //     }
                
            //     return counter;
            // }

            // Console.WriteLine(TotalAcimaMedia(l));

            List<double> ListaAcimaMedia(List<double> lista){
            double total = 0;

                foreach (var item in lista)
                {
                    total += item;
                }

                double media = total / lista.Count;
                List<double> acimaDaMedia = new List<double>();

                foreach (var item in lista)
                {
                    if(item > media)
                        acimaDaMedia.Add(item);
                }
                
                return acimaDaMedia;
            }

            List<double> teste = ListaAcimaMedia(l);

            foreach (var item in teste)
            {
                Console.WriteLine(item);
            }
        }
    }
}

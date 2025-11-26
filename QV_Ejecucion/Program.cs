using QV_Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QV_Ejecucion
{
    public class Program
    {
        public static void Main(string[] args)
        {
           QV_Grafo grafo  = new QV_Grafo(5);

            grafo.AgregarVertice(0, "A");
            grafo.AgregarVertice(1, "B");
            grafo.AgregarVertice(2, "C");
            grafo.AgregarVertice(3, "D");
            grafo.AgregarVertice(4, "E");

            grafo.AgregarArista(0, 1, 4);
            grafo.AgregarArista(0, 2, 2);
            grafo.AgregarArista(1, 2, 3);
            grafo.AgregarArista(1, 3, 2);
            grafo.AgregarArista(2, 3, 4);
            grafo.AgregarArista(3, 4, 1);

            Console.WriteLine("Dijkstra desde A:");
            grafo.Dijkstra(0);

            Console.ReadLine();
        }
    }

}


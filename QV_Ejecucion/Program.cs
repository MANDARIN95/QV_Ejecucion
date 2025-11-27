using QV_Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QV_Clases.QV_Grafo;

namespace QV_Ejecucion
{
    public class Program
    {
        public static void Main(string[] args)
        {
                Grafo g = new Grafo();

                QV_Vertice A = g.AgregarVertice("A");
                QV_Vertice B = g.AgregarVertice("B");
                QV_Vertice C = g.AgregarVertice("C");
                QV_Vertice D = g.AgregarVertice("D");

                g.AgregarArista(A, C, 2);
                g.AgregarArista(C, B, 3);
                g.AgregarArista(C, D, 6);

                g.Dijkstra(A);
                g.MostrarRutas();

                Console.ReadLine();
            
        }

    }
}



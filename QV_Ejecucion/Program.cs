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
            QV_Grafo g = new QV_Grafo();

            QV_Vertice A = g.AgregarVertice("A");
            QV_Vertice B = g.AgregarVertice("B");
            QV_Vertice C = g.AgregarVertice("C");
            QV_Vertice D = g.AgregarVertice("D");

            g.AgregarArista(A, C, 2);
            g.AgregarArista(C, B, 3);
            g.AgregarArista(C, D, 6);

            g.Dijkstra(A);
            g.MostrarMatrices();

            Console.Write("Ingrese destino (A, B, C, D): ");
            string destino = Console.ReadLine();

            QV_Vertice vDestino = null;
            if (destino == "A") vDestino = A;
            if (destino == "B") vDestino = B;
            if (destino == "C") vDestino = C;
            if (destino == "D") vDestino = D;

            if (vDestino != null)
            {
               g.MostrarRuta(vDestino);
            }
            else
            {
               Console.WriteLine("Destino no válido.");
            }

            Console.ReadLine();
            
        }
    }

}




   




using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QV_Clases
{
    public class QV_Grafo
    {
       public int[,] Matriz;
       public QV_Vertice[] Vertices;
       public int CantidadQV_Vertices;

       public QV_Grafo(int cantidad)
       {
         CantidadQV_Vertices = cantidad;
         Matriz = new int[cantidad, cantidad];
         Vertices = new QV_Vertice[cantidad];

            for (int i = 0; i < CantidadQV_Vertices; i++)
            {
                for (int j = 0; j < CantidadQV_Vertices; j++)
                {
                    Matriz[i, j] = 0;
                }
            }
       }

        public void AgregarVertice(int indice, string dato)
        {
          Vertices[indice] = new QV_Vertice(dato, indice);
        }

        public void AgregarArista(int origen, int destino, int peso)
        {
           Matriz[origen, destino] = peso;
           Matriz[destino, origen] = peso; 
        }

        public void Dijkstra(int inicio)
        {
                int[] dist = new int[CantidadQV_Vertices];
                bool[] visitado = new bool[CantidadQV_Vertices];

               
                for (int i = 0; i < CantidadQV_Vertices; i++)
                {
                    dist[i] = 9999;
                    visitado[i] = false;
                }

                dist[inicio] = 0;

                for (int contador = 0; contador < CantidadQV_Vertices - 1; contador++)
                {
                    int u = MinDistancia(dist, visitado);
                    visitado[u] = true;

                    for (int v = 0; v < CantidadQV_Vertices; v++)
                    {
                        if (!visitado[v] &&
                            Matriz[u, v] > 0 &&
                            dist[u] != 9999 &&
                            dist[u] + Matriz[u, v] < dist[v])
                        {
                            dist[v] = dist[u] + Matriz[u, v];
                        }
                    }
                }
            MostrarResultado(dist, inicio);
        }

            private int MinDistancia(int[] dist, bool[] visitado)
            {
                int min = 9999;
                int idx = -1;

                for (int i = 0; i < CantidadQV_Vertices; i++)
                {
                    if (!visitado[i] && dist[i] <= min)
                    {
                        min = dist[i];
                        idx = i;
                    }
                }

                return idx;
            }

            private void MostrarResultado(int[] dist, int inicio)
            {
                Console.WriteLine("\nDistancias desde " + Vertices[inicio].Dato + ":");
                for (int i = 0; i < CantidadQV_Vertices; i++)
                {
                    Console.WriteLine(Vertices[inicio].Dato + " - " +
                                      Vertices[i].Dato + " = " + dist[i]);
                }
            }
        
    }
}
   



using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static QV_Clases.QV_ListaEnlazadaSimple;

namespace QV_Clases
{
    public class QV_Grafo
    {
        public class Grafo
        {
            public QV_Vertice Cabeza;

            public Grafo()
            {
                Cabeza = null;
            }

            public QV_Vertice AgregarVertice(string dato)
            {
                QV_Vertice nuevo = new QV_Vertice(dato);

                if (Cabeza == null)
                {
                    Cabeza = nuevo;
                }
                else
                {
                    QV_Vertice temp = Cabeza;
                    while (temp.siguiente != null)
                    {
                        temp = temp.siguiente;
                    }
                    temp.siguiente = nuevo;
                }

                return nuevo;
            }

            public void AgregarArista(QV_Vertice origen, QV_Vertice destino, int peso)
            {
                QV_Arista nueva = new QV_Arista(destino, peso);
                origen.ListaAristas.Agregar(nueva);
            }

           
            private void InicializarDijkstra()
            {
                QV_Vertice v = Cabeza;
                while (v != null)
                {
                    v.Visitado = false;
                    v.Distancia = int.MaxValue;
                    v.Anterior = null;
                    v = v.siguiente;
                }
            }

            private QV_Vertice ObtenerVerticeMenor()
            {
                QV_Vertice temp = Cabeza;
                QV_Vertice menor = null;

                while (temp != null)
                {
                    if (!temp.Visitado)
                    {
                        if (menor == null || temp.Distancia < menor.Distancia)
                        {
                            menor = temp    ;
                        }
                    }
                    temp = temp.siguiente;
                }

                return menor;
            }

            public void Dijkstra(QV_Vertice inicio)
            {
                InicializarDijkstra();
                inicio.Distancia = 0;

                while (true)
                {
                    QV_Vertice actual = ObtenerVerticeMenor();
                    if (actual == null) break;

                    actual.Visitado = true;

                    NodoLista nodo = actual.ListaAristas.Cabeza;
                    while (nodo != null)
                    {
                    QV_Arista arista = nodo.Dato;

                        int nuevo = actual.Distancia + arista.Peso;

                        if (nuevo < arista.Destino.Distancia)
                        {
                            arista.Destino.Distancia = nuevo;
                            arista.Destino.Anterior = actual;
                        }

                        nodo = nodo.Siguiente;
                    }
                }
            }

            
            public void MostrarRutas()
            {
                QV_Vertice v = Cabeza;

                while (v != null)
                {
                    Console.Write("Vertice " + v.Dato + " - Ruta: ");
                    ImprimirRuta(v);
                    Console.WriteLine(" (Costo: " + v.Distancia + ")");
                    v = v.siguiente;
                }
            }

            
            private void ImprimirRuta(QV_Vertice v)
            {
                if (v.Anterior != null)
                {
                    ImprimirRuta(v.Anterior);
                    Console.Write(" -> ");
                }

                Console.Write(v.Dato);
            }
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QV_Clases
{
    public class QV_ListaEnlazadaSimple
    {
        private NodoLista cabeza; 

        public QV_ListaEnlazadaSimple()
        {
            cabeza = null;
        }

        public void Agregar(QV_Arista a)
        {
            NodoLista nuevo = new NodoLista(a);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoLista temp = cabeza;
                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevo;
            }
        }
        public class NodoLista
        {
            public QV_Arista Dato;
            public NodoLista Siguiente;
            public NodoLista(QV_Arista dato)
            {
                Dato = dato;
                Siguiente = null;
            }
        }
    }
}

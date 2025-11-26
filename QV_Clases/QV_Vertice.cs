using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QV_Clases
{
    public class QV_Vertice
    {
        public string Dato;
        public bool visitado;
        public int  Distancia;
        public QV_Vertice Anterior;

        public QV_Vertice(string dato)
        {
           Dato = dato;
            Visitado = flase;
            Distancia = int.MaxValue;
            Anterior= null;
        }
    }
}

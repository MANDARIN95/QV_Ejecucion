using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QV_Clases
{
    public class QV_Arista
    {
        public int Origen;
        public int Destino;
        public int Peso;

        public QV_Arista(int origen, int destino, int peso)
        {
            Origen = origen;
            Destino = destino;
            Peso = peso;
        }
    }
}

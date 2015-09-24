using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2SisOpe
{
    public class Proceso
    {
        public int Identificador;
        public int Tiempo_servicio;
        public string TipoMoneda;


        public Proceso()
        {
            

        }


        public Proceso(Proceso InObj )
        {
            this.Identificador = InObj.Identificador;
            this.Tiempo_servicio = InObj.Tiempo_servicio;
            this.TipoMoneda = InObj.TipoMoneda;
        }
        
        
    }
}

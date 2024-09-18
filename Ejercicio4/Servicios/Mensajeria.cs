using Ejercicio4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Servicios
{
    public class Mensajeria
    {
        private readonly IMensaje mensaje;

        public Mensajeria(IMensaje mensaje)
        {
            this.mensaje = mensaje;
        }

        public string EnviarMensaje()
        {
            return mensaje.EnviarMensaje();
        }
    }
}

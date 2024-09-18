using Ejercicio4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Servicios
{
    public class SmsMensaje : IMensaje
    {
        public string EnviarMensaje()
        {
            return "Se envío el mensaje por SMS";
        }
    }
}

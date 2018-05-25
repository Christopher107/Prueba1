using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    public class Garzon : Empleado //Asociacion de tipo herencia con la clase padre Empleado, clase hijo Garzon
    {
        //Asociacion agregacion
        private Pedido pedido;
        //Constructor de la clase Garzon que asocia asia la clase Pedido con agregacion
        public Garzon(Pedido pedido)
        {
            this.pedido = pedido;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    public class Mesa
    {
        private int numero;
        private int cantidadPersonas;
        private Boolean estado;
        //Asociacion agregacion
        private Pedido Pedido;

        //Conostructor de la clase Mesa para asociacion de agregacion con la clase Pedido
        public Mesa(Pedido pedido, int numero, int cantidad, Boolean estado)
        {
            this.Pedido = pedido;
            this.numero = numero;
            this.estado = estado;
            this.cantidadPersonas = cantidad;
        }

        public void Registrar(Boolean tipo)
        {

        }

        public bool ConsultaEstado()
        {
            return true;
        }
        //Receptor de asociacion dependencia de la clase Cliente
        public List<Mesa> Disponibles()
        {
            return new List<Mesa>();
        }
    }
}

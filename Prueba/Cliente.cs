using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    public class Cliente : Persona //Asociacion tipo herencia clase padre Persona, clase hijo Cliente
    {
        //Asocacion con clase Pedido
        private Pedido pedido;

        //Constructor de la asociacion de agregacion con la clase Pedido
        public Cliente(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public bool Registrase(string[] param)
        {
            return true;
        }

        //Asociacion de tipo dependencia con la clase Mesa
        public void ReservaMesa()
        {
            Mesa mesa = new Mesa();
            mesa.Disponibles();
        }

        public void QuitaMesa()
        {

        }
    }
}

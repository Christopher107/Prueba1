using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    public class Pedido
    {
        //Receptor agregacion de la clase cliente
        private Cliente cliente;
        //receptor agregacion de la clase Garzon
        private Garzon garzon;
        //Receptor agregacion de la clas Menu
        private List<Menu> menu;
        //Receptor agrgacion de la clase Alimento
        private List<Alimento> alimentos;
        //Receptor agregacion de la clase Mesa
        private Mesa mesa;
        private DateTime fecha;
        private DateTime hora;
        private Boolean estado;

        //Constructor de la clase Pedido
        public Pedido(DateTime fecha, DateTime hora, Boolean estado)
        {
            this.fecha = fecha;
            this.hora = hora;
            this.estado = estado;
        }

        public bool Registrarse(string[] param)
        {
            return true;
        }
    }
}

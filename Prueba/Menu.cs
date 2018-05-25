using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    public class Menu
    {
        //Asociacion de tipo compocicion con la clase Alimento
        private List<Alimento> alimentos = new List<Alimento>();       
        private int precio;
        private string Nombre;
        //Asociacion agregacion
        private Pedido pedido;

        //Constructor de la clase Menu que asocia con agregacion a la clase Pedido
        public Menu(Pedido pedido, int precio, string nombre)
        {
            this.pedido = pedido;
            this.precio = precio;
            this.Nombre = nombre;
        }

        public void AgregarAlimento(Alimento alimento)
        {

        }

        public void QuitarAlimento(Alimento alimento)
        {

        }

        public int ObtienePercio()
        {
            return 10;
        }

        public void CambiarPrecio(int precio)
        {
           
        }
    }
}

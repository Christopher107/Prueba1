using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    public class Alimento
    {
        //Atributos de la clase Alimento
        private string nombre;
        private int precio;
        //Asociacion de agregacion
        private Pedido pedido;

        //Constructor de la clase Alimento que asocia con agregacion a la clase Pedido
        public Alimento(Pedido pedido, string nombre)
        {
            this.pedido = pedido;
            this.nombre = nombre;
        }

    }

    //Asociacion herencia dentro de la clase Alimento ya que no interactua con otra clase
    public class Plato
    {

    }
    //Asociacion herencia dentro de la clase Alimento ya que no interactua con otra clase
    public class Bebida
    {

    }
    //Asociacion herencia dentro de la clase Alimento ya que no interactua con otra clase
    public class Postre
    {

    }
    //Asociacion herencia dentro de la clase Alimento ya que no interactua con otra clase
    public class Ensalada
    {

    }
    //Asociacion herencia dentro de la clase Alimento ya que no interactua con otra clase
    public class Agregado
    {

    }
}

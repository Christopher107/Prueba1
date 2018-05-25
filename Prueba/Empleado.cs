using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    public class Empleado : Trabajador //asociacion de tipo herencia con la clase padre Trabajador y la clase hijo Empleado
    {
        private DateTime HoraIngreso;
        private DateTime HoraSalida;

        public void RegistrarIngreso(DateTime HoraIngreso)
        {

        }

        public void RegistrarSalida(DateTime HoraSalida)
        {

        }
    }
    //asociacion de tipo herencia dentro de la clase padre Empleado ya que la clase hijo Chef no interactua con niguna clase mas
    public class Chef
    {

    }
}

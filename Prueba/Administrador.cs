using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    public class Administrador : Trabajador //Asociacion de tipo herencia clase padre Trabajador, clase hijo Administrador
    {
        public void AgregarEmpleado(Empleado empleado)
        {

        }

        public void QuitarEmpleado(Empleado empleado)
        {

        }

        public void AgregarBonificasion(Empleado empleado, int Monto)
        {

        }

        //Asociacion de tipo dependencia con la clase pedido
        public List<Pedido> VisualizaVentas(DateTime Inicio, DateTime Termino)
        {
            List<Pedido> pedido = new List<Pedido>();
            return new List<Pedido>();   
        }

        //Asociacion de tipo dependencia con la clase pedido
        public List<Pedido> VisualizaVentas()
        {
            List<Pedido> pedido = new List<Pedido>();
            return new List<Pedido>();
        }

        public void PagarEmpleados(Empleado empleado, int Mes, int Año)
        {

        }
    }
}

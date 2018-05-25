using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    public class Trabajador : Persona //Asociacion de tipo herencia, clse padre Persona, clase hijo Trabajador
    {
        //atributos de la clase hijo Trabajdor
        private int sueldo;
        private DateTime fechaContratacion;

        public void AregarBono(int bono)
        {

        }

        public int ObtieneSueldo(Trabajador trabajador)
        {
            return 10;
        }
    }
}

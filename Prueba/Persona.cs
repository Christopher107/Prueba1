using System;

namespace Prueba
{
    public class Persona
    {
        //Atributos de la clase padre Persona
        private int run;
        private string nombre;
        private int celular;
        private string email;
        private string clave;
        
        protected void ReiniciarClave(Persona persona)
        {
            
        }

        public bool IniciarSesion(string[] param)
        {
            return true;
        }
    }
}

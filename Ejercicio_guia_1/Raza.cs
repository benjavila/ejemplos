using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_guia_1
{
    class Raza
    {
        private string nombre;
        private int tamano;
        private List<Perro> perros = new List<Perro>();

        public enum estatura : int { pequeno = 1, mediano = 2, grande = 3 };

        public Raza(string nombre, int tamano)
        {
            this.nombre = nombre;
            this.tamano = tamano;
        }
        
        public string obtieneNombre()
        {
            return nombre;
        }

        public int obtieneTamano()
        {
            return tamano;
        }

        public void agregaPerro(Perro perro)
        {
            perros.Add(perro);
        }
    }
      
}

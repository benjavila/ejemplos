using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_guia_1
{
    class Perro
    {
        private string nombre;
        private int anoNacimiento;
        private Raza raza;


        public Perro(string nombre, int anoNac, Raza raza)
        {
            this.nombre = nombre;
            this.anoNacimiento = anoNac;
            this.raza = raza;
        }

        public string obtieneNombre()
        {
            return nombre;
        }

        public int obtieneEdad()
        {
            DateTime ano = new DateTime();
            return ano.Year - anoNacimiento;
        }

        public Raza obtieneRaza()
        {
            return raza;
        }
    }
}

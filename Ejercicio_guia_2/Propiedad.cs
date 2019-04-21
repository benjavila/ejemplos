using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_guia_2
{
    class Propiedad
    {
        private string direccion;
        private int valorArriendo;
        private byte numeroDormitorios;
        private Propietario propiedad;
        private List<Contrato> contratos = new List<Contrato>();

        public Propiedad(string dir, int vArr, byte nDorm, Propietario dueno)
        {
            this.direccion = dir;
            this.valorArriendo = vArr;
            this.numeroDormitorios = nDorm;
            this.propiedad = dueno;
            
        }

        public bool estaArrendada()
        {
            return false;
        }

        protected byte obtieneNumeroDormitorios()
        {
            return numeroDormitorios;
        }

        protected int obtieneValorArriendo()
        {
            return valorArriendo;
        }

        protected void agregarContrato(Contrato cArr)
        {
            contratos.Add(cArr);
        }

        protected Propietario obtienePropietario()
        {
            return this.propiedad;
        }
    }
}

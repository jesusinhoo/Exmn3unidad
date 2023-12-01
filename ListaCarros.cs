using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmn3unidad
{
    internal class ListaCarros
    {
        private Nodo primero;
        

        public void AgregarCarro(string marca, string modelo, int año)
        {
            Nodo nodo = new Nodo();

            nodo.AñoLanzamiento = año;
            nodo.Marca = marca;
            nodo.Modelo = modelo;

            if (primero == null)
            {
                primero = nodo;
            }
            else
            {
                Nodo actual = primero;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nodo;
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_simples
{
    class Lista
    {
        private Auto primero;
        private Auto ultimo;
        public Lista()
        {
            primero = null;
            ultimo = null;
        }
        public void agregarInicio(Auto nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
                primero.siguiente = null;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.siguiente = null;
            }
            ultimo = nuevo;
        }
        public void eliminarPrimero()
        {
            Auto actual = primero;
            Auto anterior;
            if (actual != null)
            {
                primero = actual.siguiente;
                actual = primero.siguiente;
            }
        }
        public void eliminarUltimo()
        {
            Auto actual = primero;
            Auto anterior = null;
            while (actual != null)
            {
                if (actual == ultimo)
                {
                    anterior.siguiente = null;
                    ultimo = anterior;
                }
                anterior = actual;
                actual = actual.siguiente;
            }
        }
        public string reporteInverso()
        {
            string cadena = "";
            Auto actual = primero;
            //Auto anterior = null;
            while (actual != null)
            {
                cadena = actual.ToString() + cadena;
                actual = actual.siguiente;
            }

            return cadena;
        }
        public string Listar()
        {
            string cadena = "";
            Auto actual = primero;
            if (primero != null)
            {
                while (actual != null)
                {
                    cadena += actual.ToString();
                    actual = actual.siguiente;
                }
            }
            else
            {
                cadena = "Lista vacia";
            }
            return cadena;
        }
    }
}

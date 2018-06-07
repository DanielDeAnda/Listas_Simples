using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_simples
{
    class Auto
    {
        private string _Placa { get; }
        private string _Marca { get; }
        private string _Modelo { get; }
        private string _Telefono { get; }
        private string _Año { get; }
        //public Auto anterior;
        public Auto siguiente;//Hace referencia al siguiente objeto que se desea agregar
        public Auto(string placa, string marca, string modelo, string telefono, string año)
        {
            this._Placa= placa;
            this._Marca = marca;
            this._Modelo = modelo;
            this._Año = año;
            this._Telefono = telefono;
            siguiente = null;
        }

        public string placa()
        {
            return _Placa;
        }
        public string marca()
        {
            return _Marca;
        }
        public string modelo()
        {
            return _Modelo;
        }
        public string telefono()
        {
            return _Telefono;
        }
        public string año()
        {
            return _Año;
        }

        public override string ToString()
        {
            return "Placa: " + _Placa + "\n Marca: " + _Marca + "\n Modelo: " + _Modelo + "\n Año: " + _Año + "\n Teléfono: " + _Telefono + Environment.NewLine + Environment.NewLine;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpMVVM.Clase
{
    class Persona
    {
        public string _nombres;
        public string Nombres
        {
            get { return this._nombres; }
            set { this._nombres = value; }
        }
        public string _apellidos;
        public string Apellidos
        {
            get { return this._apellidos; }
            set { this._apellidos = value; }
        }
        public string _telefono;
        public string Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
        public string _Correo;
        public string Correo
        {
            get { return this._Correo; }
            set { this._Correo = value; }
        }

    }
}

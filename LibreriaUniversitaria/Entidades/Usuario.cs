using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _clave;

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        //POSIBLES ATRIBUTOS

        //private int _dni;

        //public int dni
        //{
        //	get { return _dni; }
        //	set { _dni = value; }
        //}

        //private int _correoelectronico;

        //public int correo
        //{
        //	get { return _correoelectronico; }
        //	set { _correoelectronico = value; }
        //}
    }
}

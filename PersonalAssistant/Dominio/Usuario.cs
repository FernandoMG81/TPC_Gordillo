﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public long ID { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public char Sexo { get; set; }
        public string Descripcion { get; set; }
        public TipoUsuario Tipo { get; set; }
        public string Imagen { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return Nombre + "";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programex2021
{
    public class Integrantes
    {
       public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int edad { get; set; }
    

        public string NombreCompletoyCorreoedad()
        {
            return Nombre + "," + Apellido + "," + Correo + "," + edad;
        }

       
    }
}



   

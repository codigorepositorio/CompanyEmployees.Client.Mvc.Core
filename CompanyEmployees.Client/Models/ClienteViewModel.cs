﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployees.Client.Models
{
    public class ClienteViewModel
    {
        public int codigoCliente { get; set; }
        public string tipo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string documento { get; set; }
        public string numero { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
    }
}

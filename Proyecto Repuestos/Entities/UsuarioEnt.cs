﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Repuestos.Entities
{
    public class UsuarioEnt
    {
        public string usu_correo { get; set; }
        public string usu_clave { get; set; }
        public string usu_identificacion { get; set; }
        public string usu_nombre { get; set; }
        public string rol_descripcion { get; set; }
        public int rol_id { get; set; }

    }
}
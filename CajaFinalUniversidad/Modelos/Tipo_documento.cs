﻿using System.ComponentModel.DataAnnotations;

namespace UniversidadAPI.Models
{
    public class Tipo_documento
    {
        [Key]
        public int tipo_documento_id { get; set; }
        public string tipo_documento { get; set; }
    }
}

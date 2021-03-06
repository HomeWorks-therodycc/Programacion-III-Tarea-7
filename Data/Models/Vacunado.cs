using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tarea7.Data.Models
{
    public partial class Vacunado
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [StringLength(10)]
        public string Telefono { get; set; }
        public int ProvinciaId { get; set; }
        public int? Vacuna1Id { get; set; }
        public DateTime? Vacuna1Fecha { get; set; }
        public int? Vacuna2Id { get; set; }
        public DateTime? Vacuna2Fecha { get; set; }

        public virtual Provincia Provincia { get; set; }
        public virtual Vacuna Vacuna1 { get; set; }
        public virtual Vacuna Vacuna2 { get; set; }
    }
}

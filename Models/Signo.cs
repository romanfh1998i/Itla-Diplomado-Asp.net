namespace ItlaSigno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Signo")]
    public partial class Signo
    {
        [Key]
        [StringLength(50)]
        public string UsuarioId { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuarioNombre { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuarioApellido { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuarioCedula { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }
    }
}

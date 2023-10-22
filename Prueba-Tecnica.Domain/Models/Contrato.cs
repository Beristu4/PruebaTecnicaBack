using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_Tecnica.Domain.Models
{
    [Table("contrato")]
    public class Contrato : BaseModel
    {

        [Column("courseCode")]
        public string CourseCode { get; set; }

        [Column("fechaAlta")]
        public DateTime? FechaAlta { get; set; }

        [Column("estado")]
        public bool Estado { get; set; }

        [Column("cantidadEgresados")]
        public int CantidadEgresados { get; set; }

        [Column("fechaEntrega")]
        public DateTime? FechaEntrega { get; set; }

        [Column("medioEntrega")]
        public string? MedioEntrega { get; set; }

        [Column("vendedor")]
        public string? Vendedor { get; set; }

        [Column("colegioNivel")]
        public string ColegioNivel { get; set; }

        [Column("colegioNombre")]
        public string ColegioNombre { get; set; }

        [Column("colegioLocalidad")]
        public string ColegioLocalidad { get; set; }

        [Column("colegioCurso")]
        public string ColegioCurso { get; set; }

        [Column("comision")]
        public long Comision { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

    }
}

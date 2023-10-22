using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_Tecnica.Domain.Models;

[Table("articulo")]
public partial class Articulo : BaseModel
{
    [Column("nombre")]
    public string? Nombre { get; set; }

    [Column("precio")]
    public decimal? Precio { get; set; }
}

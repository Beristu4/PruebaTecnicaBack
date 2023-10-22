using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_Tecnica.Domain.Models
{
    [Table("pedido")]
    public class Pedido : BaseModel
    {
        [Column("contract_id")]
        public long ContractId { get; set; }

        [ForeignKey("ContractId")]
        public Contrato Contrato { get; set; }

        [Column("articulo_id")]
        public long ArticuloId { get; set; }

        [ForeignKey("ArticuloId")]
        public Articulo Articulo { get; set; }

        [Column("createDate")]
        public DateTime CreateDate { get; set; }

        [Column("updateDate")]
        public DateTime? UpdateDate { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }

        [Column("deleted")]
        public bool Deleted { get; set; }

        [Column("createBy")]
        public string CreatedBy { get; set; }
    }
}

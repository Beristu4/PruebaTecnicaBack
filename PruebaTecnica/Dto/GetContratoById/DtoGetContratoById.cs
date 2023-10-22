namespace PruebaTecnica.Dto.GetContratoById
{
    public class DtoGetContratoById
    {
        public string CodigoCurso { get; set; }
        public string FechaAlta { get; set; }
        public string Colegio { get; set; }
        public string Nivel { get; set; }
        public string Curso { get; set; }
        public string Localidad { get; set; }
        public List<PedidosDto> Pedidos { get; set; }
        public decimal MontoPagar { get; set; }
        public string FechaEntrega { get; set; }

    }

    public class PedidosDto
    {
        public int Cantidad { get; set; }
        public string Articulo { get; set; }
        public decimal? Precio { get; set; }
        public decimal? TotalArticulo { get; set; }
    }
}

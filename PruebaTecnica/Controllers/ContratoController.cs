using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba_Tecnica.Domain.Models;
using PruebaTecnica.Dto.GetContratoById;

namespace PruebaTecnica.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    public class ContratoController : Controller
    {

        private readonly PruebaTecnicaContext _context;

        public ContratoController(PruebaTecnicaContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("/contrato/{id}")]
        public async Task<DtoGetContratoById?> GetContratoById(long id)
        {
            try
            {

                var query = await _context.Contrato.FirstOrDefaultAsync(c => c.Id == id);

                if(query == null)
                {
                    return null;
                }

                var pedido = await _context.Pedido.Include(x => x.Articulo).Where(p => p.ContractId == id).ToListAsync();

                var dtoPedidoList = new List<PedidosDto>();


                foreach (var p in pedido)
                {
                    var dtoPedido = new PedidosDto();

                    dtoPedido.Cantidad = query.CantidadEgresados;
                    dtoPedido.Articulo = p.Articulo.Nombre;
                    dtoPedido.Precio = p.Articulo.Precio;
                    dtoPedido.TotalArticulo = p.Articulo.Precio * query.CantidadEgresados;

                    dtoPedidoList.Add(dtoPedido);
                }

                var dto = new DtoGetContratoById
                {
                    CodigoCurso = query.CourseCode,
                    Curso = query.ColegioCurso,
                    Colegio = query.ColegioNombre,
                    FechaAlta = query.FechaAlta.ToString(),
                    FechaEntrega = query.FechaEntrega.ToString(),
                    Localidad = query.ColegioLocalidad,
                    MontoPagar = query.Total,
                    Nivel = query.ColegioNivel,
                    Pedidos = dtoPedidoList
                };


                return dto;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}

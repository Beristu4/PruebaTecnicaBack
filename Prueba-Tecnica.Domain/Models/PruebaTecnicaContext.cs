using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Prueba_Tecnica.Domain.Models;

public partial class PruebaTecnicaContext : DbContext
{
    public PruebaTecnicaContext()
    {
    }

    public PruebaTecnicaContext(DbContextOptions<PruebaTecnicaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Articulo> Articulos { get; set; }
    public virtual DbSet<Contrato> Contrato { get; set; }
    public virtual DbSet<Pedido> Pedido { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuración de la relación entre Pedido y Contrato
        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Contrato)
            .WithMany()
            .HasForeignKey(p => p.ContractId);

        // Configuración de la relación entre Pedido y Articulo
        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Articulo)
            .WithMany()
            .HasForeignKey(p => p.ArticuloId);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

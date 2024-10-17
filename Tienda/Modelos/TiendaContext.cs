using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tienda.Modelos;

public partial class TiendaContext : DbContext
{
    public TiendaContext()
    {
    }

    public TiendaContext(DbContextOptions<TiendaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetProducto> DetProductos { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Foto> Fotos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-TEOJV65H\\MSSQLSERVER01;\nDatabase=Tienda;\nUser Id=sa;\nPassword=1701;\nEncrypt=True;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__cliente__C2FF245DB2876C69");

            entity.ToTable("cliente");

            entity.Property(e => e.ClienteId).HasColumnName("clienteId");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Direccion)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Member).HasColumnName("member");
            entity.Property(e => e.ModifiedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDateTime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<DetProducto>(entity =>
        {
            entity.HasKey(e => e.DetProductoId).HasName("PK__detProdu__8DFB521261CDED3E");

            entity.ToTable("detProducto");

            entity.Property(e => e.DetProductoId).HasColumnName("detProductoId");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Factura).HasColumnName("factura");
            entity.Property(e => e.ModifiedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDateTime");
            entity.Property(e => e.Producto).HasColumnName("producto");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.ProductoNavigation).WithMany(p => p.DetProductos)
                .HasForeignKey(d => d.Producto)
                .HasConstraintName("FK__detProduc__produ__4316F928");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.FacturaId).HasName("PK__factura__AAF90221995E86B1");

            entity.ToTable("factura");

            entity.Property(e => e.FacturaId).HasColumnName("facturaId");
            entity.Property(e => e.Cliente).HasColumnName("cliente");
            entity.Property(e => e.ModifiedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDateTime");
            entity.Property(e => e.Productos).HasColumnName("productos");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.ClienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Cliente)
                .HasConstraintName("FK__factura__cliente__45F365D3");

            entity.HasOne(d => d.ProductosNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Productos)
                .HasConstraintName("FK__factura__product__46E78A0C");
        });

        modelBuilder.Entity<Foto>(entity =>
        {
            entity.HasKey(e => e.FotoId).HasName("PK__foto__C435D5AF20DBA300");

            entity.ToTable("foto");

            entity.Property(e => e.FotoId).HasColumnName("fotoId");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("categoria");
            entity.Property(e => e.ModifiedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDateTime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Url)
                .IsUnicode(false)
                .HasColumnName("url");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__producto__69E6E154FC5F6A0D");

            entity.ToTable("producto");

            entity.Property(e => e.ProductoId).HasColumnName("productoId");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("categoria");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Foto).HasColumnName("foto");
            entity.Property(e => e.Inventario).HasColumnName("inventario");
            entity.Property(e => e.ModifiedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDateTime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.FotoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.Foto)
                .HasConstraintName("FK__producto__foto__403A8C7D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalWebMaycoholV3.Models
{
    public partial class BDMaycoholV3Context : DbContext
    {
        public BDMaycoholV3Context()
        {
        }

        public BDMaycoholV3Context(DbContextOptions<BDMaycoholV3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategorium> TblCategoria { get; set; } = null!;
        public virtual DbSet<TblCliente> TblClientes { get; set; } = null!;
        public virtual DbSet<TblDetalleVentum> TblDetalleVenta { get; set; } = null!;
        public virtual DbSet<TblEmpleado> TblEmpleados { get; set; } = null!;
        public virtual DbSet<TblProducto> TblProductos { get; set; } = null!;
        public virtual DbSet<TblProveedor> TblProveedors { get; set; } = null!;
        public virtual DbSet<TblVentum> TblVenta { get; set; } = null!;

      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-SJLTNMT;Initial Catalog=BDMaycoholV3;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCategorium>(entity =>
            {
                entity.HasKey(e => e.Idcategoria)
                    .HasName("PK__tblCateg__70E82E2811329BC6");

                entity.ToTable("tblCategoria");

                entity.Property(e => e.Idcategoria)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("IDCategoria");

                entity.Property(e => e.CatNombre)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("catNombre");
            });

            modelBuilder.Entity<TblCliente>(entity =>
            {
                entity.HasKey(e => e.Dni)
                    .HasName("PK__tblClien__C035B8DC6DDCE684");

                entity.ToTable("tblCliente");

                entity.Property(e => e.Dni)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.CliApellidoMaterno)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("cliApellidoMaterno");

                entity.Property(e => e.CliApellidoPaterno)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("cliApellidoPaterno");

                entity.Property(e => e.CliDireccion)
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("cliDireccion");

                entity.Property(e => e.CliEmail)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("cliEmail");

                entity.Property(e => e.CliFechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("cliFechaNacimiento");

                entity.Property(e => e.CliNombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cliNombres");

                entity.Property(e => e.CliSexo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("cliSexo");

                entity.Property(e => e.CliTelefono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cliTelefono");
            });

            modelBuilder.Entity<TblDetalleVentum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblDetalleVenta");

                entity.Property(e => e.DvenCantidad).HasColumnName("dvenCantidad");

                entity.Property(e => e.Idproducto)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("IDProducto");

                entity.Property(e => e.Idventa)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("IDVenta");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idproducto)
                    .HasConstraintName("FK__tblDetall__IDPro__33D4B598");

                entity.HasOne(d => d.IdventaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idventa)
                    .HasConstraintName("FK__tblDetall__IDVen__32E0915F");
            });

            modelBuilder.Entity<TblEmpleado>(entity =>
            {
                entity.HasKey(e => e.Idempleado)
                    .HasName("PK__tblEmple__50621DCDCD3875EC");

                entity.ToTable("tblEmpleado");

                entity.Property(e => e.Idempleado)
                    .ValueGeneratedNever()
                    .HasColumnName("IDEmpleado");

                entity.Property(e => e.EmpApellidoMaterno)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("empApellidoMaterno");

                entity.Property(e => e.EmpApellidoPaterno)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("empApellidoPaterno");

                entity.Property(e => e.EmpNombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empNombres");

                entity.Property(e => e.EmpNumSegSocial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("empNumSegSocial");

                entity.Property(e => e.EmpSueldo)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("empSueldo");
            });

            modelBuilder.Entity<TblProducto>(entity =>
            {
                entity.HasKey(e => e.Idproducto)
                    .HasName("PK__tblProdu__ABDAF2B4FEE66D10");

                entity.ToTable("tblProducto");

                entity.Property(e => e.Idproducto)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("IDProducto");

                entity.Property(e => e.Idcategoria)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("IDCategoria");

                entity.Property(e => e.ProNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("proNombre");

                entity.Property(e => e.ProPrecioVenta)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("proPrecioVenta");

                entity.Property(e => e.ProStock).HasColumnName("proStock");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("RUC");

                entity.HasOne(d => d.IdcategoriaNavigation)
                    .WithMany(p => p.TblProductos)
                    .HasForeignKey(d => d.Idcategoria)
                    .HasConstraintName("FK__tblProduc__IDCat__30F848ED");

                entity.HasOne(d => d.RucNavigation)
                    .WithMany(p => p.TblProductos)
                    .HasForeignKey(d => d.Ruc)
                    .HasConstraintName("FK__tblProducto__RUC__300424B4");
            });

            modelBuilder.Entity<TblProveedor>(entity =>
            {
                entity.HasKey(e => e.Ruc)
                    .HasName("PK__tblProve__CAF3326ACECF2F04");

                entity.ToTable("tblProveedor");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("RUC");

                entity.Property(e => e.ProvDireccion)
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("provDireccion");

                entity.Property(e => e.ProvEmail)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("provEmail");

                entity.Property(e => e.ProvNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("provNombre");

                entity.Property(e => e.ProvTelefono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("provTelefono");
            });

            modelBuilder.Entity<TblVentum>(entity =>
            {
                entity.HasKey(e => e.Idventa)
                    .HasName("PK__tblVenta__27134B82261773CC");

                entity.ToTable("tblVenta");

                entity.Property(e => e.Idventa)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("IDVenta");

                entity.Property(e => e.Dni)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.Idempleado).HasColumnName("IDEmpleado");

                entity.Property(e => e.VenFecha)
                    .HasColumnType("date")
                    .HasColumnName("venFecha");

                entity.HasOne(d => d.DniNavigation)
                    .WithMany(p => p.TblVenta)
                    .HasForeignKey(d => d.Dni)
                    .HasConstraintName("FK__tblVenta__DNI__2C3393D0");

                entity.HasOne(d => d.IdempleadoNavigation)
                    .WithMany(p => p.TblVenta)
                    .HasForeignKey(d => d.Idempleado)
                    .HasConstraintName("FK__tblVenta__IDEmpl__2D27B809");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Data;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication3.Models.Libro", b =>
                {
                    b.Property<int>("idLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Egresos")
                        .HasColumnType("int");

                    b.Property<int>("Ingresos")
                        .HasColumnType("int");

                    b.Property<int>("cantidadPago")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaVenta")
                        .HasColumnType("datetime2");

                    b.HasKey("idLibro");

                    b.ToTable("libros");
                });

            modelBuilder.Entity("WebApplication3.Models.Pago", b =>
                {
                    b.Property<int>("CodPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodPlato")
                        .HasColumnType("int");

                    b.HasKey("CodPago");

                    b.ToTable("pagos");
                });

            modelBuilder.Entity("WebApplication3.Models.Pedido", b =>
                {
                    b.Property<int>("NumPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("codCliente")
                        .HasColumnType("int");

                    b.Property<int>("codPlato")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("NumPedido");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("WebApplication3.Models.Producto", b =>
                {
                    b.Property<int>("Cod_Plato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NamePlato")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("precio")
                        .HasColumnType("int");

                    b.HasKey("Cod_Plato");

                    b.ToTable("productos");
                });

            modelBuilder.Entity("WebApplication3.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}

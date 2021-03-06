// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Model;

namespace Shop.Model.Migrations
{
    [DbContext(typeof(ShopEntities))]
    partial class ShopEntitiesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Shop.Model.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            FirstName = "wei",
                            LastName = "kun"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

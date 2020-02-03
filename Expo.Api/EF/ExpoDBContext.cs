using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Expo.Api.EF
{
    public partial class ExpoDBContext : DbContext
    {
        public ExpoDBContext() { }

        public ExpoDBContext(DbContextOptions<ExpoDBContext> options) : base(options) { }

        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Test> Test { get; set; }

        //         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //         {
        //             if (!optionsBuilder.IsConfigured)
        //             {
        // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                 optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=rootpassword;database=expo-db", x => x.ServerVersion("5.7.28-mysql"));
        //             }
        //         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.IdValue)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdValue)
                    .HasColumnName("id.value")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Cell)
                    .HasColumnName("cell")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DobAge)
                    .HasColumnName("dob.age")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DobDate)
                    .HasColumnName("dob.date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdName)
                    .HasColumnName("id.name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LocationCity)
                    .HasColumnName("location.city")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LocationCoordinatesLatitude).HasColumnName("location.coordinates.latitude");

                entity.Property(e => e.LocationCoordinatesLongitude).HasColumnName("location.coordinates.longitude");

                entity.Property(e => e.LocationCountry)
                    .HasColumnName("location.country")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LocationPostcode)
                    .HasColumnName("location.postcode")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LocationState)
                    .HasColumnName("location.state")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LocationStreetName)
                    .HasColumnName("location.street.name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LocationStreetNumber)
                    .HasColumnName("location.street.number")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LocationTimezoneDescription)
                    .HasColumnName("location.timezone.description")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LocationTimezoneOffset)
                    .HasColumnName("location.timezone.offset")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LoginMd5)
                    .HasColumnName("login.md5")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LoginPassword)
                    .HasColumnName("login.password")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LoginSalt)
                    .HasColumnName("login.salt")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LoginSha1)
                    .HasColumnName("login.sha1")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LoginSha256)
                    .HasColumnName("login.sha256")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LoginUsername)
                    .HasColumnName("login.username")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LoginUuid)
                    .HasColumnName("login.uuid")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NameFirst)
                    .HasColumnName("name.first")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NameLast)
                    .HasColumnName("name.last")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NameTitle)
                    .HasColumnName("name.title")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nat)
                    .HasColumnName("nat")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PictureLarge)
                    .HasColumnName("picture.large")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PictureMedium)
                    .HasColumnName("picture.medium")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PictureThumbnail)
                    .HasColumnName("picture.thumbnail")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.RegisteredAge)
                    .HasColumnName("registered.age")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegisteredDate)
                    .HasColumnName("registered.date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
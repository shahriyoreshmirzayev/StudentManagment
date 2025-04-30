using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagment.Data;

#nullable disable

namespace StudentManagment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("00000000000000_CreateIdentitySchema")]
    partial class CreateIdentitySchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            // SQL Server uchun identity ustunini olib tashlaymiz
            // PostgreSQL uchun avtomatik identifikatorlar ishlatiladi
            modelBuilder.Entity("StudentManagment.Data.ApplicationUser", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("varchar(450)");  // SQL Server uchun nvarchar(450), PostgreSQL uchun varchar(450)

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("text");  // PostgreSQL uchun text

                b.Property<string>("Email")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)");  // SQL Server uchun nvarchar, PostgreSQL uchun varchar

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("boolean");  // PostgreSQL uchun boolean

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("boolean");  // PostgreSQL uchun boolean

                b.Property<DateTimeOffset?>("LockoutEnd")
                    .HasColumnType("timestamp with time zone");  // PostgreSQL uchun timestamp with time zone

                b.Property<string>("NormalizedEmail")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)");  // PostgreSQL uchun varchar

                b.Property<string>("NormalizedUserName")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)");  // PostgreSQL uchun varchar

                b.Property<string>("PasswordHash")
                    .HasColumnType("text");  // PostgreSQL uchun text

                b.Property<string>("PhoneNumber")
                    .HasColumnType("text");  // PostgreSQL uchun text

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("boolean");  // PostgreSQL uchun boolean

                b.Property<string>("SecurityStamp")
                    .HasColumnType("text");  // PostgreSQL uchun text

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("boolean");  // PostgreSQL uchun boolean

                b.Property<string>("UserName")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)");  // PostgreSQL uchun varchar

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasDatabaseName("EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .IsUnique()
                    .HasDatabaseName("UserNameIndex")
                    .HasFilter("[NormalizedUserName] IS NOT NULL");

                b.ToTable("AspNetUsers", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("varchar(450)");  // SQL Server uchun nvarchar(450), PostgreSQL uchun varchar(450)

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("text");  // PostgreSQL uchun text

                b.Property<string>("Name")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)");  // PostgreSQL uchun varchar

                b.Property<string>("NormalizedName")
                    .HasMaxLength(256)
                    .HasColumnType("varchar(256)");  // PostgreSQL uchun varchar

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasDatabaseName("RoleNameIndex")
                    .HasFilter("[NormalizedName] IS NOT NULL");

                b.ToTable("AspNetRoles", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("serial");  // PostgreSQL uchun serial

                b.Property<string>("ClaimType")
                    .HasColumnType("text");  // PostgreSQL uchun text

                b.Property<string>("ClaimValue")
                    .HasColumnType("text");  // PostgreSQL uchun text

                b.Property<string>("RoleId")
                    .IsRequired()
                    .HasColumnType("varchar(450)");  // PostgreSQL uchun varchar(450)

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("AspNetRoleClaims", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("serial");  // PostgreSQL uchun serial

                b.Property<string>("ClaimType")
                    .HasColumnType("text");  // PostgreSQL uchun text

                b.Property<string>("ClaimValue")
                    .HasColumnType("text");  // PostgreSQL uchun text

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("varchar(450)");  // PostgreSQL uchun varchar(450)

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserClaims", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.Property<string>("LoginProvider")
                    .HasColumnType("varchar(450)");  // PostgreSQL uchun varchar(450)

                b.Property<string>("ProviderKey")
                    .HasColumnType("varchar(450)");  // PostgreSQL uchun varchar(450)

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("text");  // PostgreSQL uchun text

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("varchar(450)");  // PostgreSQL uchun varchar(450)

                b.HasKey("LoginProvider", "ProviderKey");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserLogins", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("varchar(450)");  // PostgreSQL uchun varchar(450)

                b.Property<string>("RoleId")
                    .HasColumnType("varchar(450)");  // PostgreSQL uchun varchar(450)

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("AspNetUserRoles", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("varchar(450)");  // PostgreSQL uchun varchar(450)

                b.Property<string>("LoginProvider")
                    .HasColumnType("varchar(450)");  // PostgreSQL uchun varchar(450)

                b.Property<string>("Name")
                    .HasColumnType("varchar(450)");  // PostgreSQL uchun varchar(450)

                b.Property<string>("Value")
                    .HasColumnType("text");  // PostgreSQL uchun text

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("AspNetUserTokens", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.HasOne("StudentManagment.Data.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.HasOne("StudentManagment.Data.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("StudentManagment.Data.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.HasOne("StudentManagment.Data.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}

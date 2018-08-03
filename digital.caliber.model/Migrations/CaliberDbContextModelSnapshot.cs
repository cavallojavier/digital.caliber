﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using digital.caliber.model.Data;

namespace digital.caliber.model.Migrations
{
    [DbContext(typeof(CaliberDbContext))]
    partial class CaliberDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("digital.caliber.model.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<DateTime>("RegisteredOn");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("digital.caliber.model.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<int>("LogLevel");

                    b.Property<string>("Message");

                    b.Property<string>("StackTrace");

                    b.Property<DateTime>("SubmittedOn");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("digital.caliber.model.Models.Measures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateMessure");

                    b.Property<string>("HcNumber")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Measures");
                });

            modelBuilder.Entity("digital.caliber.model.Models.MeasuresMouth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("LeftInferiorCanine");

                    b.Property<decimal>("LeftInferiorIncisive");

                    b.Property<decimal>("LeftInferiorPremolar");

                    b.Property<decimal>("LeftSuperiorCanine");

                    b.Property<decimal>("LeftSuperiorIncisive");

                    b.Property<decimal>("LeftSuperiorPremolar");

                    b.Property<int>("MeasureId");

                    b.Property<decimal>("RightInferiorCanine");

                    b.Property<decimal>("RightInferiorIncisive");

                    b.Property<decimal>("RightInferiorPremolar");

                    b.Property<decimal>("RightSuperiorCanine");

                    b.Property<decimal>("RightSuperiorIncisive");

                    b.Property<decimal>("RightSuperiorPremolar");

                    b.HasKey("Id");

                    b.HasIndex("MeasureId")
                        .IsUnique();

                    b.ToTable("MeasuresMouth");
                });

            modelBuilder.Entity("digital.caliber.model.Models.MeasuresTeeths", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MeasureId");

                    b.Property<decimal>("Tooth11");

                    b.Property<decimal>("Tooth12");

                    b.Property<decimal>("Tooth13");

                    b.Property<decimal>("Tooth14");

                    b.Property<decimal>("Tooth15");

                    b.Property<decimal>("Tooth16");

                    b.Property<decimal>("Tooth17");

                    b.Property<decimal>("Tooth21");

                    b.Property<decimal>("Tooth22");

                    b.Property<decimal>("Tooth23");

                    b.Property<decimal>("Tooth24");

                    b.Property<decimal>("Tooth25");

                    b.Property<decimal>("Tooth26");

                    b.Property<decimal>("Tooth27");

                    b.Property<decimal>("Tooth31");

                    b.Property<decimal>("Tooth32");

                    b.Property<decimal>("Tooth33");

                    b.Property<decimal>("Tooth34");

                    b.Property<decimal>("Tooth35");

                    b.Property<decimal>("Tooth36");

                    b.Property<decimal>("Tooth37");

                    b.Property<decimal>("Tooth41");

                    b.Property<decimal>("Tooth42");

                    b.Property<decimal>("Tooth43");

                    b.Property<decimal>("Tooth44");

                    b.Property<decimal>("Tooth45");

                    b.Property<decimal>("Tooth46");

                    b.Property<decimal>("Tooth47");

                    b.HasKey("Id");

                    b.HasIndex("MeasureId")
                        .IsUnique();

                    b.ToTable("MeasuresTeeths");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("digital.caliber.model.Models.Measures", b =>
                {
                    b.HasOne("digital.caliber.model.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("digital.caliber.model.Models.MeasuresMouth", b =>
                {
                    b.HasOne("digital.caliber.model.Models.Measures", "Measure")
                        .WithOne("Mouth")
                        .HasForeignKey("digital.caliber.model.Models.MeasuresMouth", "MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("digital.caliber.model.Models.MeasuresTeeths", b =>
                {
                    b.HasOne("digital.caliber.model.Models.Measures", "Measure")
                        .WithOne("Teeths")
                        .HasForeignKey("digital.caliber.model.Models.MeasuresTeeths", "MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("digital.caliber.model.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("digital.caliber.model.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("digital.caliber.model.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("digital.caliber.model.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

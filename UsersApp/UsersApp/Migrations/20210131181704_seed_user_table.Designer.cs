﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UsersApp.Data;

namespace UsersApp.Migrations
{
    [DbContext(typeof(UsersAppContext))]
    [Migration("20210131181704_seed_user_table")]
    partial class seed_user_table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UsersApp.Models.Agenda", b =>
                {
                    b.Property<int>("IdAgenda")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("IdUser");

                    b.Property<int>("State");

                    b.HasKey("IdAgenda");

                    b.HasIndex("IdUser");

                    b.ToTable("Agendas");

                    b.HasData(
                        new { IdAgenda = 1, Date = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), IdUser = 2, State = 2 },
                        new { IdAgenda = 2, Date = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), IdUser = 2, State = 1 },
                        new { IdAgenda = 3, Date = new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), IdUser = 2, State = 2 },
                        new { IdAgenda = 4, Date = new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), IdUser = 2, State = 0 },
                        new { IdAgenda = 5, Date = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), IdUser = 2, State = 1 },
                        new { IdAgenda = 6, Date = new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), IdUser = 3, State = 2 },
                        new { IdAgenda = 7, Date = new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), IdUser = 3, State = 0 },
                        new { IdAgenda = 8, Date = new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), IdUser = 3, State = 1 },
                        new { IdAgenda = 9, Date = new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), IdUser = 3, State = 2 },
                        new { IdAgenda = 10, Date = new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), IdUser = 3, State = 0 }
                    );
                });

            modelBuilder.Entity("UsersApp.Models.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("ClientName");

                    b.Property<string>("Email");

                    b.Property<string>("LastNameClient");

                    b.Property<string>("Phone");

                    b.HasKey("IdClient");

                    b.ToTable("Clients");

                    b.HasData(
                        new { IdClient = 1, Address = "San Salvador", ClientName = "Paola", LastNameClient = "Franco" },
                        new { IdClient = 2, Address = "San Salvador", ClientName = "Maria", LastNameClient = "Gonzalez" },
                        new { IdClient = 3, Address = "San Salvador", ClientName = "Carlos", LastNameClient = "Gutierrez" }
                    );
                });

            modelBuilder.Entity("UsersApp.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int>("TypeUser");

                    b.Property<string>("UuserName");

                    b.HasKey("IdUser");

                    b.ToTable("Users");

                    b.HasData(
                        new { IdUser = 1, LastName = "admin1", Name = "admin 1", Password = "123", TypeUser = 1, UuserName = "admin" },
                        new { IdUser = 2, LastName = "testing", Name = "tester 1", Password = "123", TypeUser = 0, UuserName = "test" },
                        new { IdUser = 3, LastName = "test", Name = "tester 2", Password = "123", TypeUser = 0, UuserName = "test" }
                    );
                });

            modelBuilder.Entity("UsersApp.Models.Agenda", b =>
                {
                    b.HasOne("UsersApp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

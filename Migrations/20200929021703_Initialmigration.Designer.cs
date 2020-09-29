﻿// <auto-generated />
using System;
using Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace api_angular_task.Migrations
{
    [DbContext(typeof(bananContext))]
    [Migration("20200929021703_Initialmigration")]
    partial class Initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.banan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("makh")
                        .HasColumnType("int");

                    b.Property<int>("soghe")
                        .HasColumnType("int");

                    b.Property<int>("tinhtrang")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("banans");
                });
#pragma warning restore 612, 618
        }
    }
}
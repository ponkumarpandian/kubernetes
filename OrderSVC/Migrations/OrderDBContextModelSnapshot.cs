﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using OrderSVC.DAL;
using System;

namespace OrderSVC.Migrations
{
    [DbContext(typeof(OrderDBContext))]
    partial class OrderDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderSVC.DAL.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("OrderDate");

                    b.Property<decimal>("OrderTotal");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderSVC.DAL.OrderDetail", b =>
                {
                    b.Property<long>("OrderDetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<decimal>("LineItemTotal");

                    b.Property<long>("OrderId");

                    b.Property<long>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("OrderSVC.DAL.OrderDetail", b =>
                {
                    b.HasOne("OrderSVC.DAL.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

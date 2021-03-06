﻿// <auto-generated />
using System;
using HouseHoldMoney.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HouseHoldMoney.Model.Migrations
{
    [DbContext(typeof(HouseHoldContext))]
    [Migration("20190322214240_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("HouseHoldMoney.Model.HouseHoldMoney", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<bool>("Automatically");

                    b.Property<string>("Description");

                    b.Property<string>("Organisation");

                    b.Property<Guid?>("PaymentID");

                    b.HasKey("ID");

                    b.HasIndex("PaymentID");

                    b.ToTable("HouseHoldMoneys");
                });

            modelBuilder.Entity("HouseHoldMoney.Model.Payment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Apr");

                    b.Property<bool>("Aug");

                    b.Property<bool>("Dec");

                    b.Property<bool>("Feb");

                    b.Property<bool>("Jan");

                    b.Property<bool>("Jul");

                    b.Property<bool>("Jun");

                    b.Property<bool>("Mar");

                    b.Property<bool>("May");

                    b.Property<bool>("Nov");

                    b.Property<bool>("Oct");

                    b.Property<bool>("Sep");

                    b.Property<int>("TermOfPayment");

                    b.HasKey("ID");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            ID = new Guid("e2ac9866-2297-4c72-81c4-9603a5ef438b"),
                            Apr = true,
                            Aug = true,
                            Dec = true,
                            Feb = true,
                            Jan = true,
                            Jul = true,
                            Jun = true,
                            Mar = true,
                            May = true,
                            Nov = true,
                            Oct = true,
                            Sep = true,
                            TermOfPayment = 0
                        },
                        new
                        {
                            ID = new Guid("0d5de3a2-a0b9-446a-a720-a65f85f6e99e"),
                            Apr = false,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = true,
                            Jul = true,
                            Jun = false,
                            Mar = true,
                            May = true,
                            Nov = true,
                            Oct = false,
                            Sep = true,
                            TermOfPayment = 1
                        },
                        new
                        {
                            ID = new Guid("b4330895-361f-4add-bfdd-cd054ce8cced"),
                            Apr = true,
                            Aug = true,
                            Dec = true,
                            Feb = true,
                            Jan = false,
                            Jul = false,
                            Jun = true,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = true,
                            Sep = false,
                            TermOfPayment = 1
                        },
                        new
                        {
                            ID = new Guid("899ace4d-15cb-487e-bea3-4c80e14e24df"),
                            Apr = true,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = true,
                            Jul = true,
                            Jun = false,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = true,
                            Sep = false,
                            TermOfPayment = 2
                        },
                        new
                        {
                            ID = new Guid("5381016c-7432-43d7-9ba1-74d881dfef45"),
                            Apr = false,
                            Aug = true,
                            Dec = false,
                            Feb = true,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = false,
                            May = true,
                            Nov = true,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 2
                        },
                        new
                        {
                            ID = new Guid("328a473d-05ac-48b2-ad9f-d5fc9f1661c5"),
                            Apr = false,
                            Aug = false,
                            Dec = true,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = true,
                            Mar = true,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = true,
                            TermOfPayment = 2
                        },
                        new
                        {
                            ID = new Guid("ea86f497-5c68-4abe-b6cf-2c646f01cfe7"),
                            Apr = false,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = true,
                            Jul = true,
                            Jun = false,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 3
                        },
                        new
                        {
                            ID = new Guid("4eaae91a-384b-4b3b-b3a8-3350303a764e"),
                            Apr = false,
                            Aug = true,
                            Dec = false,
                            Feb = true,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 3
                        },
                        new
                        {
                            ID = new Guid("95056ead-6ab6-460c-b34f-db8c06d4963a"),
                            Apr = false,
                            Aug = true,
                            Dec = false,
                            Feb = true,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 3
                        },
                        new
                        {
                            ID = new Guid("dca67a07-52e1-46d4-8c63-00233436fb9f"),
                            Apr = true,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = true,
                            Sep = false,
                            TermOfPayment = 3
                        },
                        new
                        {
                            ID = new Guid("bc022a3d-d073-4053-9c7a-22ff7aa8213d"),
                            Apr = false,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = false,
                            May = true,
                            Nov = true,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 3
                        },
                        new
                        {
                            ID = new Guid("a49234d0-2716-4482-8e87-89a22a468cb1"),
                            Apr = false,
                            Aug = false,
                            Dec = true,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = true,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 3
                        },
                        new
                        {
                            ID = new Guid("f0e21bca-bab9-4f33-a440-3b27a5fc92ab"),
                            Apr = false,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = true,
                            Jul = true,
                            Jun = false,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 4
                        },
                        new
                        {
                            ID = new Guid("ae9833dd-c16e-4914-b25e-c7d22cd5f42f"),
                            Apr = false,
                            Aug = true,
                            Dec = false,
                            Feb = true,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 4
                        },
                        new
                        {
                            ID = new Guid("74641e6a-8b17-4b18-8c0c-f2f4491fa959"),
                            Apr = false,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = true,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = true,
                            TermOfPayment = 4
                        },
                        new
                        {
                            ID = new Guid("a7a20d55-863b-487a-94bc-b3ad61a29250"),
                            Apr = true,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = true,
                            Sep = false,
                            TermOfPayment = 4
                        },
                        new
                        {
                            ID = new Guid("8434d161-d135-4141-b605-b9adbc818c65"),
                            Apr = false,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = false,
                            May = true,
                            Nov = true,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 4
                        },
                        new
                        {
                            ID = new Guid("47467bf7-f553-42e9-afbd-497dea79d10c"),
                            Apr = false,
                            Aug = false,
                            Dec = true,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = true,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 4
                        },
                        new
                        {
                            ID = new Guid("13b180cd-50fb-4315-b823-d723d2a0ae83"),
                            Apr = false,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = true,
                            Jul = true,
                            Jun = false,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 4
                        },
                        new
                        {
                            ID = new Guid("bf41475c-5dc2-4db6-9139-9357eaf32ce9"),
                            Apr = false,
                            Aug = true,
                            Dec = false,
                            Feb = true,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 4
                        },
                        new
                        {
                            ID = new Guid("0ad69806-8d06-4cb5-a36c-b4020c23eeeb"),
                            Apr = false,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = true,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = true,
                            TermOfPayment = 4
                        },
                        new
                        {
                            ID = new Guid("55c03567-dc2e-4c24-916b-d097e0c53aab"),
                            Apr = true,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = true,
                            Sep = false,
                            TermOfPayment = 4
                        },
                        new
                        {
                            ID = new Guid("188e9bc4-fe07-4af7-9b92-e5a08943c3c2"),
                            Apr = false,
                            Aug = false,
                            Dec = false,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = false,
                            Mar = false,
                            May = true,
                            Nov = true,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 4
                        },
                        new
                        {
                            ID = new Guid("5c762dbf-2838-4c35-bec6-b45dce1c2f2a"),
                            Apr = false,
                            Aug = false,
                            Dec = true,
                            Feb = false,
                            Jan = false,
                            Jul = false,
                            Jun = true,
                            Mar = false,
                            May = false,
                            Nov = false,
                            Oct = false,
                            Sep = false,
                            TermOfPayment = 4
                        });
                });

            modelBuilder.Entity("HouseHoldMoney.Model.TestClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Text");

                    b.HasKey("ID");

                    b.ToTable("TestClasses");
                });

            modelBuilder.Entity("HouseHoldMoney.Model.HouseHoldMoney", b =>
                {
                    b.HasOne("HouseHoldMoney.Model.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentID");
                });
#pragma warning restore 612, 618
        }
    }
}
